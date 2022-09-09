namespace QueryBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("MainPage/NewPage1", typeof(NewPage1));
	}
}
