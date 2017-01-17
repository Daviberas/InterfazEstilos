using InterfazEstilos.Pages;
using InterfazEstilos.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace InterfazEstilos.ViewModels
{
    public class clsHabitacionesVM:INotifyPropertyChanged
    {
        private String _habitacionSeleccionada;
        private ObservableCollection<String> _listado;
        public event PropertyChangedEventHandler PropertyChanged;
        private int _intensidadLuces;
        private int _aperturaPersianas;

        public clsHabitacionesVM()
        {
            clsListados lista = new clsListados();
            _listado =  lista.getListado();
            _intensidadLuces = 0;
            _aperturaPersianas = 0;
        }

        public String habitacionSeleccionada
        {
            get
            {
                return _habitacionSeleccionada;
            }
            set
            {
                _habitacionSeleccionada = value;
                OnPropertyChanged("habitacionSeleccionada");
                ((Frame)Window.Current.Content).Navigate(typeof(AjustarLuces));
            }
        }

        public int aperturaPersianas
        {
            get
            {
                return _aperturaPersianas;
            }
            set
            {
                _aperturaPersianas = value;
                OnPropertyChanged("aperturaPersianas");
            }
        }

        public int intensidadLuces
        {
            get
            {
                return _intensidadLuces;
            }
            set
            {
                _intensidadLuces = value;
                OnPropertyChanged("intensidadLuces");
            }
        }

        public ObservableCollection<String> listado
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
