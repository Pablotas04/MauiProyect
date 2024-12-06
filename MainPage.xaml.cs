namespace MauiProject;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnNavigateToForm(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddBrandPage());
    }

	private async void OnNavigateToBrandList(object sender, EventArgs e)
	{
    	await Navigation.PushAsync(new BrandListPage());
	}
}