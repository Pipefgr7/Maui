namespace ClimaAppMAUI.Models
{
    public class Clima
    {
        public string Ciudad { get; set; } = "Ciudad Desconocida";
        public string Descripcion { get; set; } = "Nublado";
        public int Temperatura { get; set; }
        public int Humedad { get; set; }
        public int Velocidad_Viento { get; set; }
    }
}
