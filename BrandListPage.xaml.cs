using System.Collections.ObjectModel;

namespace MauiProject
{
    public partial class BrandListPage : ContentPage
    {
        public ObservableCollection<Brand> Brands { get; set; }

        public BrandListPage()
        {
            InitializeComponent();
            
            Brands = AppShell.SharedBrands;
            BindingContext = this;
        }

    }

    public class Brand
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

}


