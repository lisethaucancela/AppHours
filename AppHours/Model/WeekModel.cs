using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHours.Model
{
    public class WeekModel : Week
    {
        public WeekModel()
        {
            lstRangos = new List<DatosModel>();
            lstRangos.Add(new DatosModel(TimeSpan.Parse("00:01"), TimeSpan.Parse("09:00"), 25));
            lstRangos.Add(new DatosModel(TimeSpan.Parse("09:01"), TimeSpan.Parse("18:00"), 15));
            lstRangos.Add(new DatosModel(TimeSpan.Parse("18:01"), TimeSpan.Parse("23:59"), 25));
        }
    }
}
