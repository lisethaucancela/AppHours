using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHours.Model
{
    public class Week
    {
        public List<DatosModel> lstRangos;

        public int CalculoTotal(TimeSpan desde, TimeSpan hasta)
        { 
            foreach (var rangos in lstRangos)
            {
                if (desde >= rangos.desde && hasta <= rangos.hasta)
                {
                    return rangos.valor;
                }
            }
            return 0;
        }
    }
}
