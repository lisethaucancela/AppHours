
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
    public class LecturaService
    {
        public StreamReader Leer(ILectura archivo)
        {
            return archivo.Leer();
        }

        public List<PersonaModel> separarDatos(ILectura archivo, StreamReader file)
        {          
            return archivo.SepararDatos(file);
        }
    }
}
