using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ListaTareasMAUI.Models;

namespace ListaTareasMAUI.ViewModels
{
    public class ListaTareasViewModel : INotifyPropertyChanged
    {
        private string nuevaTareaTexto;
        private ObservableCollection<Tarea> tareas;

        public ObservableCollection<Tarea> Tareas
        {
            get => tareas;
            set
            {
                if (tareas != value)
                {
                    tareas = value;
                    OnPropertyChanged();
                }
            }
        }

        public string NuevaTareaTexto
        {
            get => nuevaTareaTexto;
            set
            {
                if (nuevaTareaTexto != value)
                {
                    nuevaTareaTexto = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand AgregarTareaCommand { get; }
        public ICommand EliminarTareaCommand { get; }

        public ListaTareasViewModel()
        {
            tareas = new ObservableCollection<Tarea>();
            nuevaTareaTexto = "";
            AgregarTareaCommand = new Command(AgregarTarea);
            EliminarTareaCommand = new Command<Tarea>(EliminarTarea);
        }

        private void AgregarTarea()
        {
            if (string.IsNullOrWhiteSpace(NuevaTareaTexto))
                return;

            var tarea = new Tarea
            {
                Titulo = NuevaTareaTexto,
                Fecha = DateTime.Now,
                Completada = false
            };

            Tareas.Add(tarea);
            NuevaTareaTexto = "";
        }

        private void EliminarTarea(Tarea tarea)
        {
            if (tarea != null)
                Tareas.Remove(tarea);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
