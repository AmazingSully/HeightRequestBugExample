using Microsoft.Extensions.DependencyInjection;
using TestMauiApp.ViewModels;
using TestMauiApp.Views;

namespace TestMauiApp;

public partial class App : Application
{
    public static IServiceProvider ServiceProvider { get; set; }

    public App()
	{
		InitializeComponent();

		MainPage = new TestPage();
	}

    public static BaseViewModel GetViewModel<TViewModel>() where TViewModel : BaseViewModel
    {
        return ServiceProvider.GetService<TViewModel>();
    }
}
