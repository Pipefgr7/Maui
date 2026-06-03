namespace MiPrimeraAppMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSaludarClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                ResultadoLabel.Text = "Por favor, ingresa tu nombre";
                ResultadoLabel.TextColor = Colors.Red;
            }
            else
            {
                ResultadoLabel.Text = $"¡Hola, {nombre}! Bienvenido a MAUI";
                ResultadoLabel.TextColor = Colors.Green;
                NombreEntry.Text = string.Empty;
            }
        }
    }
}
