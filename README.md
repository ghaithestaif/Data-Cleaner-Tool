# Data Cleaner Tool

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![Platform](https://img.shields.io/badge/Platform-Windows-blue.svg)](https://www.microsoft.com/windows)
[![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen.svg)]()

A powerful, professional data cleaning tool built with .NET 8.0 and Windows Forms. Designed to clean, transform, and prepare data from Excel and CSV files with an intuitive user interface and robust processing capabilities.

## 🚀 Features

### Core Functionality
- **Multi-format Support**: Process Excel (.xlsx, .xls) and CSV files
- **Automatic Schema Detection**: Intelligent column type identification
- **Data Cleaning Operations**:
  - Remove duplicate rows with stable algorithms
  - Handle null/empty values (remove rows or replace with defaults)
  - Standardize text casing (Title Case, Upper Case, Lower Case)
  - Remove specified number of rows from top/bottom
- **Real-time Reporting**: Detailed operation statistics and change tracking
- **Modern UI**: Professional interface using Guna.UI2.WinForms components

### Architecture Highlights
- **Layered Architecture**: Clean separation between UI, business logic, and data extraction
- **Interface-based Design**: Extensible cleaning features using Strategy pattern
- **Event-driven Communication**: Reactive updates between components
- **Parallel Processing**: Multi-threaded data cleaning operations
- **Configuration Management**: Centralized settings and options

## 📋 Roadmap

### Current Status: ✅ Stable Release
- ✅ Basic data cleaning operations
- ✅ Multi-format file support
- ✅ Professional UI implementation
- ✅ Layered architecture
- ✅ Parallel processing

### 🚧 In Development
- 🔄 **Chunk-based Streaming Processing** (Major Enhancement)
  - Memory-efficient processing of large files
  - Progressive data loading and export
  - Real-time progress reporting
  - Cancellation support for long operations

### 📅 Planned Features
- [ ] Undo/redo functionality
- [ ] Export to additional formats (JSON, XML)
- [ ] Plugin system for custom cleaning features

## 🏗️ Architecture

### Project Structure
```
Data Cleaner Tool/
├── Data Clean Tool/              # UI Layer (Windows Forms)
│   ├── Controls/                 # Custom UI components
│   ├── Features/                 # Feature-specific forms
│   └── Utility/                  # Helper classes
├── Cleaning Layer/               # Business Logic
│   ├── Features/                 # Cleaning feature implementations
│   ├── Report Classes/           # Operation reporting
│   └── Schema Classes/           # Data schema management
└── Extraction layer/            # Data Import/Export
    └── clsExtract.cs             # File format handling
```

### Core Components

#### Cleaning Layer
- `clsClean`: Main orchestrator for cleaning operations
- `ICleaningFeature`: Strategy interface for cleaning features
- `clsConfiguration`: Centralized configuration management
- `clsSchema`: Data structure and type management

#### UI Layer
- `frmMain`: Main application window
- Custom controls for data presentation and navigation
- Real-time status updates and progress indication

#### Extraction Layer
- `clsExtract`: Multi-format data extraction
- Support for Excel and CSV files
- Automatic data type detection

## 🛠️ Installation

### Prerequisites
- Windows 10/11
- .NET 8.0 Runtime or SDK
- Visual Studio 2022 (for development)

### Build from Source
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/data-cleaner-tool.git
   cd data-cleaner-tool
   ```

2. Open the solution in Visual Studio 2022:
   ```
   Data Cleaner Tool (Console).sln
   ```

3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

4. Build the solution:
   ```bash
   dotnet build --configuration Release
   ```

5. Run the application:
   ```bash
   dotnet run --project "Data Clean Tool"
   ```

### Download Release
Download the latest release from the [Releases](https://github.com/ghaithestaif/data-cleaner-tool/releases) page and extract the zip file. Run `Data Clean Tool.exe`.

## 📖 Usage

### Basic Workflow
1. **Load Data**: Click "Open File" and select an Excel or CSV file
2. **Select Sheet**: Choose the specific sheet to clean (for Excel files)
3. **Configure Cleaning**: Set cleaning options in the configuration panel
4. **Execute Cleaning**: Click "Start Cleaning" to process the data
5. **Review Results**: View the cleaned data and operation report
6. **Export**: Save the cleaned data to your preferred format

### Cleaning Options
- **Remove Duplicates**: Eliminate duplicate rows while preserving order
- **Handle Missing Values**: 
  - Remove rows with empty/null values
  - Replace with default values per column
- **Standardize Data**: Apply consistent text casing across columns
- **Ignore Rows**: Skip specified number of rows from top or bottom

### Keyboard Shortcuts
- `Ctrl+O`: Open file
- `Ctrl+S`: Save current data
- `Ctrl+E`: Export data
- `F5`: Start cleaning process

## 🤝 Contributing

We welcome contributions from the community! Whether you're fixing bugs, adding features, or improving documentation, your help is appreciated.

### How to Contribute

#### 🚀 Priority: Streaming Implementation
Our most significant upcoming feature is **chunk-based streaming processing** to handle large files efficiently. This is a major architectural enhancement that will dramatically improve the tool's capabilities.

**Key Areas for Contribution:**
- **Streaming Architecture**: Design and implement chunk-based processing
- **Memory Optimization**: Reduce memory footprint for large datasets
- **Progress Reporting**: Real-time progress updates during long operations
- **Cancellation Support**: Allow users to interrupt long-running operations

#### Getting Started
1. Fork the repository
2. Create a feature branch: `git checkout -b feature/streaming-implementation`
3. Make your changes and commit: `git commit -m 'Add streaming support'`
4. Push to the branch: `git push origin feature/streaming-implementation`
5. Submit a pull request

#### Development Guidelines
- Follow existing code style and naming conventions
- Add appropriate comments and documentation
- Update documentation as needed

#### Code Style
- Use PascalCase for public members
- Use camelCase for private members and local variables
- Prefix class names with `cls` (existing convention)
- Include XML documentation for public APIs
- Follow .NET naming conventions

### Areas for Contribution

#### High Priority
- 🔄 **Streaming Implementation** (Major Feature)
- 🐛 Bug fixes and stability improvements
- 📝 Documentation improvements



## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- **[Guna.UI2](https://www.github.com/srsolutions/Guna.UI2)**: Modern UI components for Windows Forms
- **[CsvHelper](https://joshclose.github.io/CsvHelper/)**: CSV file reading and writing
- **[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)**: Excel file parsing

## 📞 Support

- 📧 Email: support@datacleanertool.com

## 📊 Project Statistics

- **Lines of Code**: ~15,000+
- **Development Time**: 6+ months
- **Supported Formats**: Excel (.xlsx, .xls), CSV
- **Max File Size**: Limited by available memory (streaming in development)
- **Programming Language**: C# (.NET 8.0)

---

**⭐ Star this repository if you find it useful!**

**🔄 Fork and contribute to help us build the best data cleaning tool!**
