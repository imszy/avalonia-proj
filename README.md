# Avalonia Demo - 现代化桌面应用

![Build Status](https://github.com/yourusername/avalonia-proj/workflows/Build/badge.svg)

这是一个使用 [Avalonia UI](https://avaloniaui.net/) 构建的现代化跨平台桌面应用程序示例，展示了如何创建美观、响应式的用户界面。

## ✨ 特性

- 🎨 **现代化 UI** - 使用 Fluent Design 设计语言
- 🔄 **响应式布局** - 自适应不同窗口大小
- 🌐 **跨平台** - 支持 Windows、macOS、Linux
- 🏗️ **MVVM 架构** - 使用 ReactiveUI 实现清晰的代码结构
- 🤖 **自动构建** - GitHub Actions 自动化 CI/CD
- 📊 **数据面板** - 交互式卡片和统计数据展示
- 🎭 **现代组件** - 标签页、按钮、卡片等丰富组件

## 🚀 快速开始

### 前置要求

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) 或更高版本

### 安装和运行

1. 克隆仓库：
```bash
git clone https://github.com/yourusername/avalonia-proj.git
cd avalonia-proj
```

2. 恢复依赖：
```bash
dotnet restore
```

3. 运行应用：
```bash
dotnet run
```

### 构建发布版本

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

## 📁 项目结构

```
avalonia-proj/
├── .github/
│   └── workflows/
│       └── build.yml          # GitHub Actions 构建配置
├── Assets/                    # 资源文件（图标等）
├── ViewModels/                # 视图模型（MVVM）
│   ├── ViewModelBase.cs
│   └── MainWindowViewModel.cs
├── Views/                     # 视图（XAML）
│   ├── MainWindow.axaml
│   └── MainWindow.axaml.cs
├── App.axaml                  # 应用程序样式和主题
├── App.axaml.cs               # 应用程序入口逻辑
├── Program.cs                 # 程序入口点
├── AvaloniaDemo.csproj        # 项目配置文件
└── README.md                  # 项目说明文档
```

## 🎨 UI 界面预览

应用包含以下主要界面元素：

- **欢迎页面** - 展示应用介绍和欢迎信息
- **统计卡片** - 四个彩色卡片展示关键指标
- **数据面板** - 详细的数据统计列表
- **内容管理** - 可扩展的内容管理功能
- **关于页面** - 应用信息和特性介绍

## 🛠️ 技术栈

- **UI 框架**: Avalonia UI 11.0
- **MVVM 框架**: ReactiveUI
- **语言**: C# 12 / .NET 8.0
- **设计系统**: Fluent Theme
- **字体**: Inter Font Family
- **CI/CD**: GitHub Actions

## 📦 依赖包

- `Avalonia` - 核心 UI 框架
- `Avalonia.Desktop` - 桌面平台支持
- `Avalonia.Themes.Fluent` - Fluent 设计主题
- `Avalonia.Fonts.Inter` - Inter 字体
- `Avalonia.ReactiveUI` - ReactiveUI 集成

## 🔧 开发指南

### 添加新页面

1. 在 `Views/` 目录创建新的 `.axaml` 文件
2. 在 `ViewModels/` 目录创建对应的 ViewModel
3. 在 ViewModel 中继承 `ViewModelBase`
4. 使用数据绑定连接 View 和 ViewModel

### 自定义样式

在 `App.axaml` 或各个 View 的 `Window.Styles` 中添加自定义样式：

```xml
<Style Selector="Button.custom">
    <Setter Property="Background" Value="#3B82F6"/>
    <Setter Property="CornerRadius" Value="8"/>
</Style>
```

### 添加新功能

1. 在 ViewModel 中使用 `ReactiveCommand` 创建命令
2. 使用 `RaiseAndSetIfChanged` 实现属性变更通知
3. 在 XAML 中使用 `{Binding}` 绑定数据

## 🤝 贡献

欢迎提交 Issue 和 Pull Request！

## 📄 许可证

本项目采用 MIT 许可证。

## 🔗 相关链接

- [Avalonia UI 官方文档](https://docs.avaloniaui.net/)
- [ReactiveUI 文档](https://www.reactiveui.net/)
- [.NET 官方网站](https://dotnet.microsoft.com/)

## 👨‍💻 作者

您的名字 - [@yourusername](https://github.com/yourusername)

---

⭐ 如果这个项目对您有帮助，请给它一个 Star！

