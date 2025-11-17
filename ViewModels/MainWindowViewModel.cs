using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;

namespace AvaloniaDemo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _greeting = "欢迎使用 Avalonia Demo";
    private string _statusMessage = "准备就绪";
    private int _selectedTabIndex;

    public string Greeting
    {
        get => _greeting;
        set => this.RaiseAndSetIfChanged(ref _greeting, value);
    }

    public string StatusMessage
    {
        get => _statusMessage;
        set => this.RaiseAndSetIfChanged(ref _statusMessage, value);
    }

    public int SelectedTabIndex
    {
        get => _selectedTabIndex;
        set => this.RaiseAndSetIfChanged(ref _selectedTabIndex, value);
    }

    public ObservableCollection<CardItem> CardItems { get; }
    public ObservableCollection<StatItem> StatItems { get; }

    public ReactiveCommand<Unit, Unit> RefreshCommand { get; }
    public ReactiveCommand<Unit, Unit> SettingsCommand { get; }

    public MainWindowViewModel()
    {
        CardItems = new ObservableCollection<CardItem>
        {
            new CardItem { Title = "项目总数", Value = "12", Icon = "📊", Color = "#3B82F6" },
            new CardItem { Title = "活跃用户", Value = "256", Icon = "👥", Color = "#10B981" },
            new CardItem { Title = "任务完成", Value = "89%", Icon = "✓", Color = "#8B5CF6" },
            new CardItem { Title = "系统状态", Value = "正常", Icon = "⚡", Color = "#F59E0B" },
        };

        StatItems = new ObservableCollection<StatItem>
        {
            new StatItem { Label = "今日访问", Value = 1234 },
            new StatItem { Label = "本周新增", Value = 567 },
            new StatItem { Label = "月度目标", Value = 89 },
            new StatItem { Label = "年度增长", Value = 45 },
        };

        RefreshCommand = ReactiveCommand.CreateFromTask(RefreshDataAsync);
        SettingsCommand = ReactiveCommand.Create(OpenSettings);
    }

    private async Task RefreshDataAsync()
    {
        StatusMessage = "正在刷新数据...";
        await Task.Delay(1000); // 模拟数据加载
        
        var random = new Random();
        foreach (var card in CardItems)
        {
            if (int.TryParse(card.Value, out int numValue))
            {
                card.Value = (numValue + random.Next(-10, 10)).ToString();
            }
        }
        
        StatusMessage = $"数据已更新 - {DateTime.Now:HH:mm:ss}";
    }

    private void OpenSettings()
    {
        StatusMessage = "设置功能即将推出...";
    }
}

public class CardItem : ViewModelBase
{
    private string _title = string.Empty;
    private string _value = string.Empty;
    private string _icon = string.Empty;
    private string _color = string.Empty;

    public string Title
    {
        get => _title;
        set => this.RaiseAndSetIfChanged(ref _title, value);
    }

    public string Value
    {
        get => _value;
        set => this.RaiseAndSetIfChanged(ref _value, value);
    }

    public string Icon
    {
        get => _icon;
        set => this.RaiseAndSetIfChanged(ref _icon, value);
    }

    public string Color
    {
        get => _color;
        set => this.RaiseAndSetIfChanged(ref _color, value);
    }
}

public class StatItem : ViewModelBase
{
    private string _label = string.Empty;
    private int _value;

    public string Label
    {
        get => _label;
        set => this.RaiseAndSetIfChanged(ref _label, value);
    }

    public int Value
    {
        get => _value;
        set => this.RaiseAndSetIfChanged(ref _value, value);
    }
}

