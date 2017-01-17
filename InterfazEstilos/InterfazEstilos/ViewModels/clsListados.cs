using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEstilos.ViewModels
{
   public class clsListados
    {
        public ObservableCollection<String> getListado()
        {
            ObservableCollection<String> lista = new ObservableCollection<String>();

            lista.Add("Cocina");
            lista.Add("Baño");
            lista.Add("Salón");
            lista.Add("Despacho");
            lista.Add("Habitación 1");
            lista.Add("Habitación 2");

            return lista;
        }
    }
}
