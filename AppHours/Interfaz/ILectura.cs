using AppHours.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHours.Interfaz
{
    public interface ILectura
    {
        StreamReader Leer();

        List<PersonaModel> SepararDatos(StreamReader file);
       

    }


}
