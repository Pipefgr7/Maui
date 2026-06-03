using AgendaSQLiteMAUI.ViewModels;
using AgendaSQLiteMAUI.Services;

namespace AgendaSQLiteMAUI;

public partial class MainPage : ContentPage
{
	private AgendaViewModel viewModel;
	private BaseDatosService baseDatosService;

	public MainPage(AgendaViewModel viewModel, BaseDatosService baseDatosService)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		this.baseDatosService = baseDatosService;
		BindingContext = viewModel;
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		// Insertar datos de prueba si la BD está vacía
		await baseDatosService.InsertarDatosPrueba();

		await viewModel.CargarContactos();
	}

	private async void OnGuardarClicked(object sender, EventArgs e)
	{
		await viewModel.GuardarContacto();
	}

	private void OnCancelarClicked(object sender, EventArgs e)
	{
		viewModel.CancelarFormulario();
	}
}
