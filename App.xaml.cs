using MauiMemory.Pages;

namespace MauiMemory
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Page4();// new AppShell();
        }
    }
}
