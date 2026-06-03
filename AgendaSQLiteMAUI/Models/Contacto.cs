using SQLite;

namespace AgendaSQLiteMAUI.Models
{
    [Table("contactos")]
    public class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100), Unique]
        public string Nombre { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Direccion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public Contacto()
        {
            Nombre = "";
            Telefono = "";
            Email = "";
            Direccion = "";
            FechaCreacion = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Telefono}";
        }
    }
}
