# Contributing to Data Cleaner Tool

Thank you for your interest in contributing to the Data Cleaner Tool! This document provides guidelines and information to help you get started.

## 🚀 Current Focus: Streaming Implementation

Our highest priority is implementing **chunk-based streaming processing** to handle large files efficiently. This is a major architectural enhancement that will transform the tool's capabilities.

### What is Streaming Implementation?

Currently, the application loads entire datasets into memory, which limits file size handling. Streaming will enable:
- Processing files larger than available RAM
- Progressive data loading and export
- Real-time progress reporting
- Cancellation support for long operations

### Key Components Needed

1. **IChunkProcessor Interface**
   ```csharp
   public interface IChunkProcessor
   {
       Task ProcessChunkAsync(List<List<string>> chunk, IProgress<double> progress);
   }
   ```

2. **StreamExtractor Class**
   ```csharp
   public class StreamExtractor
   {
       public async IAsyncEnumerable<List<List<string>>> ReadFileInChunksAsync(string filePath, int chunkSize);
   }
   ```

3. **Progress Reporting System**
   ```csharp
   public class ProgressReporter : IProgress<double>
   {
       public void Report(double value);
   }
   ```

## 🛠️ Development Setup

### Prerequisites
- Windows 10/11
- Visual Studio 2022
- .NET 8.0 SDK
- Git

### Setup Steps
1. Fork the repository
2. Clone your fork locally
3. Open `Data Cleaner Tool (Console).sln` in Visual Studio
4. Restore NuGet packages
5. Build the solution to ensure everything works

## 📋 Contribution Types

### 🔄 Streaming Implementation (High Priority)
- Design streaming architecture
- Implement chunk-based data processing
- Add progress reporting
- Handle cancellation tokens
- Optimize memory usage

### 🐛 Bug Fixes
- Fix reported issues
- Add regression tests
- Update documentation

### ✨ New Features
- Data validation rules engine
- Custom transformation pipelines
- Batch processing capabilities
- Advanced reporting features

### 📝 Documentation
- Improve README
- Add API documentation
- Create tutorials and guides
- Update inline comments

## 🎯 Development Guidelines

### Code Style
- Follow existing naming conventions
- Use `cls` prefix for classes (current convention)
- PascalCase for public members, camelCase for private
- Include XML documentation for public APIs
- Use meaningful variable and method names

### Example Code Style
```csharp
/// <summary>
/// Processes data chunks for streaming operations
/// </summary>
public class clsChunkProcessor : IChunkProcessor
{
    private readonly clsConfiguration _config;
    
    public clsChunkProcessor(clsConfiguration config)
    {
        _config = config ?? throw new ArgumentNullException(nameof(config));
    }
    
    /// <summary>
    /// Processes a single chunk of data asynchronously
    /// </summary>
    /// <param name="chunk">Data chunk to process</param>
    /// <param name="progress">Progress reporter</param>
    /// <returns>Task representing the operation</returns>
    public async Task ProcessChunkAsync(List<List<string>> chunk, IProgress<double> progress)
    {
        // Implementation here
    }
}
```

### Testing Guidelines
- Write unit tests for new functionality
- Test edge cases and error conditions
- Ensure all tests pass before submitting PR
- Aim for high code coverage

### Commit Guidelines
- Use clear, descriptive commit messages
- Reference issue numbers when applicable
- Keep commits focused and atomic
- Use conventional commit format when possible

## 🔄 Pull Request Process

### Before Submitting
1. **Create a feature branch**: `git checkout -b feature/streaming-implementation`
2. **Make your changes**: Implement your feature or fix
3. **Test thoroughly**: Ensure all tests pass
4. **Update documentation**: Add relevant documentation
5. **Commit your changes**: Use clear commit messages

### Submitting PR
1. **Push to your fork**: `git push origin feature/streaming-implementation`
2. **Create Pull Request**: From your fork to main branch
3. **Fill PR template**: Provide detailed description
4. **Wait for review**: Respond to feedback promptly

### PR Template
```markdown
## Description
Brief description of changes

## Type of Change
- [ ] Bug fix
- [ ] New feature
- [ ] Breaking change
- [ ] Documentation update


## Checklist
- [ ] Code follows style guidelines
- [ ] Self-review completed
- [ ] Documentation updated
- [ ] Tests added/updated
```

## 🏗️ Architecture Guidelines

### Layer Separation
- **UI Layer**: Windows Forms and user interaction
- **Cleaning Layer**: Business logic and data processing
- **Extraction Layer**: File format handling and data import/export

### Design Patterns
- **Strategy Pattern**: For cleaning features (`ICleaningFeature`)
- **Observer Pattern**: For event-driven updates
- **Factory Pattern**: For feature creation and configuration

### Performance Considerations
- Use async/await for I/O operations
- Implement proper cancellation support
- Consider memory usage for large datasets
- Optimize algorithms for performance

## 📚 Resources

### Documentation
- [.NET 8.0 Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [Windows Forms Documentation](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
- [Async Programming Best Practices](https://docs.microsoft.com/en-us/archive/msdn-magazine/2013/march/async-await-best-practices-in-asynchronous-programming)

### Helpful Libraries
- [CsvHelper](https://joshclose.github.io/CsvHelper/) for CSV processing
- [ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader) for Excel files
- [System.IO.Pipelines](https://docs.microsoft.com/en-us/dotnet/standard/io/pipelines) for streaming

## 🤝 Getting Help

### Communication Channels
- **GitHub Issues**: For bug reports and feature requests
- **GitHub Discussions**: For general questions and ideas
- **Pull Requests**: For code review and collaboration

### Code Review Process
1. **Initial Review**: Automated checks and style validation
2. **Peer Review**: Community contributors review changes
3. **Maintainer Review**: Project maintainers provide final approval
4. **Merge**: Changes are integrated into main branch

## 📋 Contribution Checklist

### Before Starting
- [ ] Read project documentation
- [ ] Understand current architecture
- [ ] Check for existing issues or discussions
- [ ] Plan your approach

### During Development
- [ ] Follow coding standards
- [ ] Write tests for new functionality
- [ ] Update relevant documentation
- [ ] Test thoroughly

### Before Submitting
- [ ] All tests pass
- [ ] Code is well-documented
- [ ] PR description is complete
- [ ] No merge conflicts

## 🎉 Recognition

Contributors are recognized in several ways:
- **Contributors section** in README
- **Release notes** for significant contributions
- **Special recognition** for major features like streaming implementation
- **Community appreciation** through discussions and issues

Thank you for contributing to the Data Cleaner Tool! Your help makes this project better for everyone.
