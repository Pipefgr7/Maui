using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListaTareasMAUI.Models
{
    public class Tarea : INotifyPropertyChanged
    {
        private string titulo;
        private bool completada;
        private DateTime fecha;

        public string Titulo
        {
            get => titulo;
            set
            {
                if (titulo != value)
                {
                    titulo = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool Completada
        {
            get => completada;
            set
            {
                if (completada != value)
                {
                    completada = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime Fecha
        {
            get => fecha;
            set
            {
                if (fecha != value)
                {
                    fecha = value;
                    OnPropertyChanged();
                }
            }
        }

        public Tarea()
        {
            titulo = "";
            completada = false;
            fecha = DateTime.Now;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
