namespace MauiApp4StackLayoutGrid;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnVerticalStart_Clicked(object sender, EventArgs e)
	{
		Target.VerticalOptions = LayoutOptions.Start;
	}

	private void OnVerticalCenter_Clicked(object sender, EventArgs e)
	{
		Target.VerticalOptions = LayoutOptions.Center;
	}

	private void OnVerticalEnd_Clicked(object sender, EventArgs e)
	{
		Target.VerticalOptions = LayoutOptions.End;
	}

	private void OnHorizontalStart_Clicked(object sender, EventArgs e)
	{
		Target.HorizontalOptions = LayoutOptions.Start;
	}

	private void OnHorizontalCenter_Clicked(object sender, EventArgs e)
	{
		Target.HorizontalOptions = LayoutOptions.Center;
	}

	private void OnHorizontalEnd_Clicked(object sender, EventArgs e)
	{
		Target.HorizontalOptions = LayoutOptions.End;
	}
}

