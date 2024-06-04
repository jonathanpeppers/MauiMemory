namespace MauiMemory.Pages;

public partial class Page4 : ContentPage
{
    private Timer? _timer;

    ~Page4() => Console.WriteLine("Page4 Destructor");

    public Page4()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        _timer = new Timer(callback =>
        {
            GC.Collect();

            Dispatcher.Dispatch(() =>
            {
                Blinker.IsVisible = !Blinker.IsVisible;
            });
        }, null, 0, 1000);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _timer?.Dispose();
    }
}