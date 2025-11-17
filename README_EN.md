# Avalonia Demo - Modern Desktop Application

![Build Status](https://github.com/yourusername/avalonia-proj/workflows/Build/badge.svg)

A modern cross-platform desktop application built with [Avalonia UI](https://avaloniaui.net/), demonstrating how to create beautiful and responsive user interfaces.

## ✨ Features

- 🎨 **Modern UI** - Built with Fluent Design language
- 🔄 **Responsive Layout** - Adapts to different window sizes
- 🌐 **Cross-Platform** - Supports Windows, macOS, Linux
- 🏗️ **MVVM Architecture** - Clean code structure with ReactiveUI
- 🤖 **Auto Build** - Automated CI/CD with GitHub Actions
- 📊 **Dashboard** - Interactive cards and statistics display
- 🎭 **Modern Components** - Rich components including tabs, buttons, cards

## 🚀 Quick Start

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher

### Installation and Run

1. Clone the repository:
```bash
git clone https://github.com/yourusername/avalonia-proj.git
cd avalonia-proj
```

2. Restore dependencies:
```bash
dotnet restore
```

3. Run the application:
```bash
dotnet run
```

### Build for Release

#### Windows
```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:PublishTrimmed=true
```

#### Linux
```bash
dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true -p:PublishTrimmed=true
```

#### macOS
```bash
dotnet publish -c Release -r osx-x64 --self-contained true -p:PublishSingleFile=true -p:PublishTrimmed=true
```

## 📁 Project Structure

```
avalonia-proj/
├── .github/
│   └── workflows/
│       └── build.yml          # GitHub Actions build config
├── Assets/                    # Resource files (icons, etc.)
├── ViewModels/                # View Models (MVVM)
│   ├── ViewModelBase.cs
│   └── MainWindowViewModel.cs
├── Views/                     # Views (XAML)
│   ├── MainWindow.axaml
│   └── MainWindow.axaml.cs
├── App.axaml                  # Application styles and themes
├── App.axaml.cs               # Application entry logic
├── Program.cs                 # Program entry point
├── AvaloniaDemo.csproj        # Project configuration
└── README.md                  # Project documentation
```

## 🛠️ Tech Stack

- **UI Framework**: Avalonia UI 11.0
- **MVVM Framework**: ReactiveUI
- **Language**: C# 12 / .NET 8.0
- **Design System**: Fluent Theme
- **Font**: Inter Font Family
- **CI/CD**: GitHub Actions

## 📦 Dependencies

- `Avalonia` - Core UI framework
- `Avalonia.Desktop` - Desktop platform support
- `Avalonia.Themes.Fluent` - Fluent design theme
- `Avalonia.Fonts.Inter` - Inter font
- `Avalonia.ReactiveUI` - ReactiveUI integration

## 🤝 Contributing

Issues and Pull Requests are welcome!

## 📄 License

This project is licensed under the MIT License.

## 🔗 Links

- [Avalonia UI Documentation](https://docs.avaloniaui.net/)
- [ReactiveUI Documentation](https://www.reactiveui.net/)
- [.NET Official Website](https://dotnet.microsoft.com/)

---

⭐ If this project helps you, please give it a Star!

