using System.Windows.Input;
using ClimaAppMAUI.Models;
using ClimaAppMAUI.Services;

namespace ClimaAppMAUI.ViewModels
{
    public class ClimaViewModel : BaseViewModel
    {
        private Clima clima;
        private readonly ClimaService climaService;

        public Clima Clima
        {
            get => clima;
            set => SetProperty(ref clima, value);
        }

        public ICommand ActualizarClimaCommand { get; }

        public ClimaViewModel()
        {
            climaService = new ClimaService();
            clima = new Clima();
            ActualizarClimaCommand = new Command(ActualizarClima);
        }

        private void ActualizarClima()
        {
            Clima = climaService.ObtenerClimaAleatorio();
        }

        public void CargarClimaInicial()
        {
            ActualizarClima();
        }
    }
}
