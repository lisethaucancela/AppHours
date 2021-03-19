using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHours.Model
{
    public class PersonaModel
    {
        public string strNombre { get; set; }
        public List<DatosModel> lstDatos { get; set; }

        public int intHoras { get; set; }

        public PersonaModel()
        {
            lstDatos = new List<DatosModel>();
            intHoras = 0;
            strNombre = "";
        }

    }
}
