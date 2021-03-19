using AppHours.Dao;
using AppHours.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHours.Logica
{
    public class ClsLogica
    {
        public ClsLogica() { }

        public void Calculo(ref List<PersonaModel> listaEmpleados)
        {
            WeekModel week = new WeekModel();
            WeekendModel weekend = new WeekendModel();

            foreach (var lsE in listaEmpleados)
            {
                int TotalValor = 0;
                foreach (var lsHora in lsE.lstDatos)
                {
                    var num_horas = (lsHora.hasta - lsHora.desde).Hours;
                    
                    if (week.isWeek(lsHora.dia))
                    {
                        TotalValor += week.CalculoValor(lsHora.desde, lsHora.hasta) * num_horas;
                    }

                    if (weekend.isWeekend(lsHora.dia))
                    {
                        TotalValor += weekend.CalculoValor(lsHora.desde, lsHora.hasta) * num_horas;

                    }
                }
                lsE.intValorTotal = TotalValor;
            }
        }
    }
}
