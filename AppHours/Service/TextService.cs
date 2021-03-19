using AppHours.Interfaz;
using AppHours.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppHours.Service
{
    class TextService : ILectura
    {
        private readonly string _ruta;

        public TextService(string ruta)
        {
            _ruta = ruta;
        }

        public StreamReader Leer()
        {

            StreamReader file =
                new StreamReader(_ruta);
            return file;
        }

        public List<PersonaModel> SepararDatos(StreamReader file)
        {
            string line;
            List<PersonaModel> listaEmpleados = new List<PersonaModel>();

            while ((line = file.ReadLine()) != null)
            {
                PersonaModel empleado = new PersonaModel();

                string[] arrayNombre = Regex.Split(line, "=");
                empleado.strNombre = arrayNombre[0];

                string[] strHorarios = Regex.Split(arrayNombre[1], ",");

                foreach (var lsHorario in strHorarios)
                {
                    DatosModel datos = new DatosModel();

                    string strHoras = lsHorario.Substring(2, lsHorario.Length - 2);
                    string[] strHora = Regex.Split(strHoras, "-");

                    datos.dia = lsHorario.Substring(0, 2);
                    datos.desde = TimeSpan.Parse(strHora[0]);
                    datos.hasta = TimeSpan.Parse(strHora[1]);

                    empleado.lstDatos.Add(datos);
                }

                listaEmpleados.Add(empleado);
            }
            return listaEmpleados;

        }
    }
}
