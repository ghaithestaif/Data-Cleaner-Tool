# Architecture Documentation

## Overview

Data Cleaner Tool follows a layered architecture pattern with clear separation of concerns. The application is designed to be maintainable, extensible, and testable.

## 🏗️ Architecture Layers

### 1. UI Layer (Presentation)
**Location**: `Data Clean Tool/`

**Responsibilities**:
- User interface and interaction
- Data visualization
- User input handling
- Progress indication

**Key Components**:
- `frmMain`: Main application window
- `Controls/`: Custom UI components
- `Features/`: Feature-specific forms

### 2. Cleaning Layer (Business Logic)
**Location**: `Cleaning Layer/`

**Responsibilities**:
- Core data processing logic
- Cleaning operations orchestration
- Configuration management
- Schema validation

**Key Components**:
- `clsClean`: Main orchestrator
- `Features/`: Cleaning feature implementations
- `Schema Classes/`: Data structure management
- `Report Classes/`: Operation reporting

### 3. Extraction Layer (Data Access)
**Location**: `Extraction layer/`

**Responsibilities**:
- File format handling
- Data import/export
- Format-specific operations

**Key Components**:
- `clsExtract`: Multi-format data extraction

## 🔄 Data Flow

```
┌─────────────────┐    ┌──────────────────┐    ┌─────────────────┐
│   UI Layer      │    │  Cleaning Layer  │    │ Extraction Layer│
│                 │    │                  │    │                 │
│ • User Input    │───▶│ • Data Cleaning  │───▶│ • File Reading  │
│ • Data Display  │    │ • Configuration  │    │ • Format Parse  │
│ • Progress UI   │    │ • Schema Mgmt    │    │ • Data Export   │
└─────────────────┘◀───└──────────────────┘◀───└─────────────────┘
        │                    │                    │
        ▼                    ▼                    ▼
   Events/Commands     Processed Data      Raw File Data
```

## 🎯 Design Patterns

### 1. Strategy Pattern
**Interface**: `ICleaningFeature`

**Purpose**: Allows different cleaning operations to be implemented as interchangeable strategies.

**Implementation**:
```csharp
public interface ICleaningFeature
{
    clsFeatureReport Apply(List<List<string>> data);
}

public class clsRemoveDuplicatesFeature : ICleaningFeature
{
    public clsFeatureReport Apply(List<List<string>> data)
    {
        // Duplicate removal logic
    }
}
```

### 2. Observer Pattern
**Events**: `DataUpdated` event in `clsClean`

**Purpose**: Notifies UI components when data processing is complete.

**Implementation**:
```csharp
public event EventHandler<DataUpdatedEventArgs> DataUpdated;

protected virtual void OnDataUpdated(DataUpdatedEventArgs e)
{
    DataUpdated?.Invoke(this, e);
}
```

### 3. Factory Pattern
**Method**: `_AddFeatures()` in `clsClean`

**Purpose**: Creates and configures cleaning features based on user settings.

## 📊 Class Responsibilities

### Core Classes

#### clsClean
**Role**: Main orchestrator
**Responsibilities**:
- Coordinate cleaning operations
- Manage configuration
- Handle state transitions
- Trigger events

#### clsConfiguration
**Role**: Settings management
**Responsibilities**:
- Store user preferences
- Validate configuration
- Provide default values

#### clsSchema
**Role**: Data structure management
**Responsibilities**:
- Define column schemas
- Manage data types
- Provide column metadata

#### clsExtract
**Role**: Data access
**Responsibilities**:
- Read different file formats
- Parse data structures
- Handle format-specific logic

## 🔄 State Management

### Application States
```csharp
public enum enStatus
{
    NoData,     // No file loaded
    Loading,    // Loading/cleaning in progress
    Ready,      // Data loaded, ready for cleaning
    Cleaning    // Cleaning operation in progress
}
```

### Cleaning States
```csharp
public enum enState
{
    NotStarted, // Cleaning not initiated
    InProgress, // Cleaning in progress
    Completed   // Cleaning completed
}
```

## 🔧 Configuration Management

### Configuration Options
- **File Settings**: Path, format, sheet selection
- **Cleaning Options**: Duplicates, null handling, standardization
- **Performance Options**: Parallel processing, chunk size (future)

### Validation Rules
- File existence and accessibility
- Format compatibility
- Parameter ranges
- Logical consistency

## 📈 Performance Considerations

### Current Implementation
- **Memory Usage**: Loads entire dataset into memory
- **Processing**: Parallel operations for supported features
- **UI Responsiveness**: Event-driven updates

### Future Improvements (Streaming)
- **Memory Efficiency**: Chunk-based processing
- **Scalability**: Handle large files
- **Progress Reporting**: Real-time updates
- **Cancellation**: Interrupt long operations

## 🧪 Testing Strategy

### Unit Testing
- Individual feature logic
- Configuration validation
- Schema management
- Error handling

### Integration Testing
- End-to-end workflows
- File format handling
- UI interaction
- Performance scenarios

### Performance Testing
- Large file processing
- Memory usage analysis
- Processing speed benchmarks
- UI responsiveness

## 🔌 Extensibility Points

### Adding New Cleaning Features
1. Implement `ICleaningFeature` interface
2. Add feature to `_AddFeatures()` method
3. Update configuration class if needed
4. Add reporting capabilities

### Supporting New File Formats
1. Extend `clsExtract` class
2. Add format detection logic
3. Implement parsing methods
4. Update UI file dialog filters

### UI Extensions
1. Create new custom controls
2. Add menu items or buttons
3. Implement event handlers
4. Update data binding

## 📋 Dependencies

### External Libraries
- **Guna.UI2.WinForms**: Modern UI components
- **CsvHelper**: CSV file processing
- **ExcelDataReader**: Excel file parsing

### .NET Framework
- **Windows Forms**: UI framework
- **System.Threading.Tasks**: Parallel processing
- **System.IO**: File operations

## 🔄 Future Architecture Evolution

### Streaming Implementation
**Planned Changes**:
- Add `IChunkProcessor` interface
- Implement `StreamExtractor` class
- Add progress reporting system
- Integrate cancellation tokens

**Architecture Impact**:
```
Current:  File → Memory → Process → Export
Future:   File → Stream → Process Chunks → Stream Export
```

### Plugin System (Future)
**Planned Features**:
- Dynamic feature loading
- Third-party extensions
- Configuration-based enablement

## 📊 Performance Metrics

### Current Capabilities
- **File Size**: Limited by available memory
- **Processing Speed**: Depends on data complexity
- **Memory Usage**: 2-3x file size during processing
- **UI Responsiveness**: Good for medium files

### Target Capabilities (Post-Streaming)
- **File Size**: Unlimited (within OS limits)
- **Processing Speed**: Consistent regardless of file size
- **Memory Usage**: Constant regardless of file size
- **UI Responsiveness**: Excellent for all file sizes

## 🔍 Debugging and Diagnostics

### Logging Strategy
- **EventLog Integration**: Windows Event logging
- **Error Context**: Detailed error information
- **Performance Metrics**: Operation timing

### Debug Information
- Configuration state
- Processing statistics
- Memory usage tracking
- Error stack traces

---

This architecture documentation serves as a guide for understanding the current implementation and planning future enhancements.
