using ClimaAppMAUI.ViewModels;

namespace ClimaAppMAUI;

public partial class MainPage : ContentPage
{
	private ClimaViewModel viewModel;

	public MainPage()
	{
		InitializeComponent();
		viewModel = new ClimaViewModel();
		BindingContext = viewModel;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		viewModel.CargarClimaInicial();
	}
}
