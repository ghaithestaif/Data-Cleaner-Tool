# Streaming Implementation Guide

## Overview

This document outlines the design and implementation plan for chunk-based streaming processing in Data Cleaner Tool. This enhancement will enable the application to handle files larger than available memory while maintaining performance and user experience.

## 🎯 Objectives

### Primary Goals
- **Memory Efficiency**: Process files larger than available RAM
- **Scalability**: Handle datasets of any size
- **User Experience**: Maintain responsive UI during processing
- **Progress Visibility**: Real-time progress reporting

### Success Criteria
- Process 10GB+ files on systems with 8GB RAM
- Maintain processing speed comparable to current implementation
- Provide accurate progress indication
- Allow cancellation of long operations

## 🏗️ Architecture Design

### Current Architecture
```
File → Load to Memory → Process → Export to Memory → Save
```

### Target Architecture
```
File → Stream → Process Chunks → Stream Chunks → Save
```

## 📋 Core Components

### 1. IChunkProcessor Interface
```csharp
public interface IChunkProcessor
{
    /// <summary>
    /// Processes a chunk of data asynchronously
    /// </summary>
    /// <param name="chunk">Data chunk to process</param>
    /// <param name="progress">Progress reporter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Processed chunk with metadata</returns>
    Task<ProcessedChunk> ProcessChunkAsync(
        List<List<string>> chunk, 
        IProgress<double> progress, 
        CancellationToken cancellationToken);
}

public class ProcessedChunk
{
    public List<List<string>> Data { get; set; }
    public int OriginalRowCount { get; set; }
    public int ProcessedRowCount { get; set; }
    public TimeSpan ProcessingTime { get; set; }
    public Dictionary<string, int> OperationCounts { get; set; }
}
```

### 2. StreamExtractor Class
```csharp
public class StreamExtractor
{
    private readonly int _chunkSize;
    private readonly IProgress<double> _progress;
    private readonly CancellationToken _cancellationToken;

    public StreamExtractor(
        int chunkSize = 10000, 
        IProgress<double> progress = null,
        CancellationToken cancellationToken = default)
    {
        _chunkSize = chunkSize;
        _progress = progress;
        _cancellationToken = cancellationToken;
    }

    /// <summary>
    /// Reads file in chunks asynchronously
    /// </summary>
    public async IAsyncEnumerable<DataChunk> ReadFileInChunksAsync(
        string filePath,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        // Implementation based on file type
        var extension = Path.GetExtension(filePath).ToLower();
        
        switch (extension)
        {
            case ".csv":
                await foreach (var chunk in ReadCsvInChunksAsync(filePath, cancellationToken))
                    yield return chunk;
                break;
            case ".xlsx":
            case ".xls":
                await foreach (var chunk in ReadExcelInChunksAsync(filePath, cancellationToken))
                    yield return chunk;
                break;
            default:
                throw new NotSupportedException($"File format {extension} not supported for streaming");
        }
    }
}
```

### 3. ChunkCleaner Class
```csharp
public class ChunkCleaner : IChunkProcessor
{
    private readonly clsConfiguration _config;
    private readonly clsSchema _schema;
    private readonly List<ICleaningFeature> _features;

    public ChunkCleaner(clsConfiguration config, clsSchema schema)
    {
        _config = config;
        _schema = schema;
        _features = CreateFeatures();
    }

    public async Task<ProcessedChunk> ProcessChunkAsync(
        List<List<string>> chunk, 
        IProgress<double> progress, 
        CancellationToken cancellationToken)
    {
        var startTime = DateTime.UtcNow;
        var originalCount = chunk.Count;
        
        // Process each feature
        foreach (var feature in _features)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            // Apply feature to chunk
            var report = feature.Apply(chunk);
            
            // Update progress
            progress?.Report(0.0); // Will be calculated based on overall progress
        }

        return new ProcessedChunk
        {
            Data = chunk,
            OriginalRowCount = originalCount,
            ProcessedRowCount = chunk.Count,
            ProcessingTime = DateTime.UtcNow - startTime,
            OperationCounts = CalculateOperationCounts()
        };
    }
}
```

### 4. StreamExporter Class
```csharp
public class StreamExporter
{
    /// <summary>
    /// Exports processed chunks to file progressively
    /// </summary>
    public async Task ExportChunksAsync(
        IAsyncEnumerable<ProcessedChunk> chunks,
        string outputPath,
        IProgress<double> progress,
        CancellationToken cancellationToken)
    {
        var extension = Path.GetExtension(outputPath).ToLower();
        var totalProcessed = 0;
        var totalExpected = 0; // Will be estimated

        await using var fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
        
        switch (extension)
        {
            case ".csv":
                await ExportToCsvAsync(chunks, fileStream, progress, cancellationToken);
                break;
            case ".xlsx":
                await ExportToExcelAsync(chunks, fileStream, progress, cancellationToken);
                break;
            default:
                throw new NotSupportedException($"Export format {extension} not supported for streaming");
        }
    }
}
```

## 🔄 Implementation Strategy

### Phase 1: Core Streaming Infrastructure
1. **Create interfaces and base classes**
2. **Implement CSV streaming reader**
3. **Implement basic chunk processor**
4. **Add progress reporting framework**

### Phase 2: Excel Streaming Support
1. **Implement Excel streaming reader**
2. **Add Excel-specific optimizations**
3. **Handle multi-sheet scenarios**

### Phase 3: Integration and UI
1. **Integrate streaming into main application**
2. **Update UI for progress indication**
3. **Add cancellation support**
4. **Implement error handling**

### Phase 4: Optimization and Testing
1. **Performance optimization**
2. **Memory usage optimization**
3. **Comprehensive testing**
4. **Documentation updates**

## 📊 Performance Considerations

### Memory Management
- **Chunk Size**: Configurable based on available memory
- **Object Pooling**: Reuse objects to reduce GC pressure
- **Stream Buffers**: Optimize buffer sizes for I/O operations

### Processing Optimization
- **Parallel Features**: Process multiple features within chunks
- **Pipeline Processing**: Overlap reading, processing, and writing
- **Lazy Evaluation**: Process data only when needed

### File Format Optimizations
- **CSV**: Line-by-line reading with buffering
- **Excel**: SAX-based parsing for large files
- **Compression**: Optional output compression

## 🧪 Testing Strategy

### Unit Tests
```csharp
[Test]
public async Task ProcessChunkAsync_WithValidData_ReturnsProcessedChunk()
{
    // Arrange
    var config = new clsConfiguration();
    var schema = new clsSchema();
    var processor = new ChunkCleaner(config, schema);
    var chunk = CreateTestChunk(1000); // 1000 rows
    
    // Act
    var result = await processor.ProcessChunkAsync(chunk, null, CancellationToken.None);
    
    // Assert
    Assert.IsNotNull(result);
    Assert.AreEqual(chunk.Count, result.OriginalRowCount);
    Assert.IsTrue(result.ProcessingTime > TimeSpan.Zero);
}
```

### Integration Tests
- End-to-end streaming workflow
- Large file processing
- Cancellation scenarios
- Error handling

### Performance Tests
- Memory usage analysis
- Processing speed benchmarks
- Scalability testing
- UI responsiveness

## 🔄 Migration Path

### Backward Compatibility
- Existing API remains unchanged
- Streaming is opt-in feature
- Configuration controls streaming behavior

### Configuration Changes
```csharp
public class clsConfiguration
{
    // Existing properties...
    
    // New streaming properties
    public bool EnableStreaming { get; set; } = false;
    public int ChunkSize { get; set; } = 10000;
    public bool ShowProgress { get; set; } = true;
    public int MaxMemoryUsageMB { get; set; } = 1024;
}
```

### UI Changes
- Progress bar for streaming operations
- Cancel button for long operations
- Memory usage indicator
- Chunk size configuration

## 📈 Expected Benefits

### Performance Improvements
- **Memory Usage**: Constant regardless of file size
- **Scalability**: Process files of any size
- **Responsiveness**: UI remains responsive during processing

### User Experience
- **Progress Visibility**: Real-time progress indication
- **Cancellation**: Stop long operations
- **Configuration**: Adjustable performance settings

### Technical Benefits
- **Maintainability**: Cleaner separation of concerns
- **Testability**: Easier unit testing
- **Extensibility**: Foundation for future enhancements

## 🔧 Development Guidelines

### Code Style
- Follow existing naming conventions
- Use async/await for all I/O operations
- Implement proper cancellation support
- Add comprehensive error handling

### Performance Guidelines
- Minimize memory allocations
- Use object pooling where appropriate
- Optimize I/O buffer sizes
- Profile memory usage regularly

### Testing Guidelines
- Test with various file sizes
- Test cancellation scenarios
- Verify memory usage limits
- Validate progress reporting accuracy

## 📋 Implementation Checklist

### Core Components
- [ ] IChunkProcessor interface
- [ ] StreamExtractor class
- [ ] ChunkCleaner class
- [ ] StreamExporter class
- [ ] Progress reporting system

### File Format Support
- [ ] CSV streaming reader
- [ ] Excel streaming reader
- [ ] CSV streaming writer
- [ ] Excel streaming writer

### Integration
- [ ] UI integration
- [ ] Configuration updates
- [ ] Error handling
- [ ] Cancellation support

### Testing
- [ ] Unit tests
- [ ] Integration tests
- [ ] Performance tests
- [ ] Large file tests

### Documentation
- [ ] API documentation
- [ ] User guide updates
- [ ] Performance benchmarks
- [ ] Migration guide

---

This implementation plan provides a roadmap for adding streaming capabilities to Data Cleaner Tool while maintaining backward compatibility and improving overall performance.
