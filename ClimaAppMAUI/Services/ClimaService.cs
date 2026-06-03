using ClimaAppMAUI.Models;

namespace ClimaAppMAUI.Services
{
    public class ClimaService
    {
        private Random random = new Random();
        private string[] ciudades = { "Madrid", "Barcelona", "Valencia", "Sevilla", "Bilbao", "Málaga", "Zaragoza" };
        private string[] descripciones = { "Soleado", "Nublado", "Lluvia ligera", "Lluvia moderada", "Parcialmente nublado", "Despejado" };

        public Clima ObtenerClimaAleatorio()
        {
            return new Clima
            {
                Ciudad = ciudades[random.Next(ciudades.Length)],
                Descripcion = descripciones[random.Next(descripciones.Length)],
                Temperatura = random.Next(5, 40),
                Humedad = random.Next(30, 100),
                Velocidad_Viento = random.Next(0, 50)
            };
        }
    }
}
