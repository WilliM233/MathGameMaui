namespace MathGameMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		// forces light mode
		Application.Current.UserAppTheme = AppTheme.Light;
	}
}
