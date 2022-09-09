namespace QueryBug;

public partial class NewPage1 : ContentPage
{
	public NewPage1(NewPage1ViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}