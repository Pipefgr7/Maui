using ListaTareasMAUI.ViewModels;

namespace ListaTareasMAUI;

public partial class MainPage : ContentPage
{
	private ListaTareasViewModel viewModel;

	public MainPage()
	{
		InitializeComponent();
		viewModel = new ListaTareasViewModel();
		BindingContext = viewModel;
	}
}
