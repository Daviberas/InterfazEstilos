using InterfazEstilos.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEstilos.ViewModels
{
    public class clsHabitacionesVM:INotifyPropertyChanged
    {
        private clsPersona _personaSeleccionada;
        private ObservableCollection<clsPersona> _listado;
        public event PropertyChangedEventHandler PropertyChanged;

        public clsHabitacionesVM()
        {
            clsListados lista = new clsListados();
            _listado =  lista.getListado();
        }

        public clsPersona personaSeleccionada
        {
            get
            {
                return _personaSeleccionada;
            }
            set
            {
                _personaSeleccionada = value;
                OnPropertyChanged("personaSeleccionada");
            }
        }
        public ObservableCollection<clsPersona> listado
        {
            get
            {
                return _listado;
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
