using System.Collections.ObjectModel;


namespace MauiProject;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


	}

	public static ObservableCollection<Brand> SharedBrands { get; set; } = new ObservableCollection<Brand>();


}
