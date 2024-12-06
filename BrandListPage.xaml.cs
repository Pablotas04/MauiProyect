using System.Collections.ObjectModel;

namespace MauiProject
{
    public partial class BrandListPage : ContentPage
    {
        public ObservableCollection<Brand> Brands { get; set; }

        public BrandListPage()
        {
            InitializeComponent();

            // Inicializar la lista de marcas
            /*Brands = new ObservableCollection<Brand>
            {
                new Brand { Name = "Nike", Description = "Marca deportiva internacional" },
                new Brand { Name = "Adidas", Description = "Competidor líder en calzado y ropa deportiva" },
                new Brand { Name = "Puma", Description = "Innovación en deportes y estilo" },
            };
            */
            
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


