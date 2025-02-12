using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAM_Leccion_HAOV.Model;

namespace DAM_Leccion_HAOV.ViewModel
{
    public class MainPageViewModel
    {
        public PersonasModel personasModel { get; set; }
    
        public MainPageViewModel() {
            Consultar();
        }
        public void Consultar()
        {
            personasModel = new PersonasModel()
            {
                Nombre = "Alondra",
                Apellido = "Montalvo",
                Edad = "24"
            };
           

        }
    }


}
