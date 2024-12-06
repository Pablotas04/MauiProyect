namespace MauiProject;

public partial class AddBrandPage : ContentPage
{
    public AddBrandPage()
    {
        InitializeComponent();
    }

    private async void OnSaveBrand(object sender, EventArgs e)
    {
        string brandName = BrandNameEntry.Text;
        string brandDescription = BrandDescriptionEditor.Text;

        if (string.IsNullOrWhiteSpace(brandName))
        {
            await DisplayAlert("Error", "El nombre de la marca es obligatorio.", "OK");
            return;
        }

        AppShell.SharedBrands.Add(new Brand
        {
            Name = brandName,
            Description = brandDescription
        });

            
        await DisplayAlert("Éxito", $"Marca '{brandName}' guardada con éxito.", "OK");
        await Navigation.PopAsync();
    }
}