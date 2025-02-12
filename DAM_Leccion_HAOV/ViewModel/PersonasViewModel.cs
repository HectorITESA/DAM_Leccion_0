using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAM_Leccion_HAOV.Model;
using FoundationStandard.ObjectHydrator;

namespace DAM_Leccion_HAOV.ViewModel
{
    public class PersonasViewModel
    {
        public ObservableCollection <PersonasModel> Personas { get; set; }
        public PersonasViewModel()
        {
            Consultar();
        }
        public void Consultar() {

            var listado = new Hydrator<PersonasModel>().WithFirstName(n=>n.Nombre);
            Personas = new ObservableCollection<PersonasModel>(listado.GetList(20));
        }
    }
}
