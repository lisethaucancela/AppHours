using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHours.Model
{
    public class DatosModel
    {
        public string dia { get; set; }
        public TimeSpan desde { get; set; }
        public TimeSpan hasta { get; set; }
        public int valor { get; set; }

        public DatosModel(string _dia, TimeSpan _desde, TimeSpan _hasta, int _valor)
        {
            dia = _dia;
            desde = _desde;
            hasta = _hasta;
            valor = _valor;
        }
        public DatosModel( TimeSpan _desde, TimeSpan _hasta, int _valor)
        { 
            desde = _desde;
            hasta = _hasta;
            valor = _valor;
        }
        public DatosModel() { }

    }
}
