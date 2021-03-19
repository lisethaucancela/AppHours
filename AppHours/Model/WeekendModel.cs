using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHours.Model
{
    class WeekendModel:Week
    {
        private string[] weekend = { "SA", "SU" };

        public WeekendModel()
        {
            lstRangos = new List<DatosModel>();
            lstRangos.Add(new DatosModel(TimeSpan.Parse("00:01"), TimeSpan.Parse("09:00"), 30));
            lstRangos.Add(new DatosModel(TimeSpan.Parse("09:01"), TimeSpan.Parse("18:00"), 20));
            lstRangos.Add(new DatosModel(TimeSpan.Parse("18:01"), TimeSpan.Parse("23:59"), 25));

        }

        public bool isWeekend(string dia)
        {
            return weekend.ToList().Contains(dia);
        }
    }
}
