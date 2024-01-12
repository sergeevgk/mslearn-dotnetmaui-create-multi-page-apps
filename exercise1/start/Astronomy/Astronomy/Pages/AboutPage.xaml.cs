namespace Astronomy.Pages;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		Shell.Current.FlyoutIcon = ImageSource.FromFile("question.png");
	}
}