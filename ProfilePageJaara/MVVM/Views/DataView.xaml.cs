using ProfilePageJaara.MVVM.ViewModels;

namespace ProfilePageJaara.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}