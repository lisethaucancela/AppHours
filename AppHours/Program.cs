using AppHours.Dao;
using AppHours.Interfaz;
using AppHours.Logica;
using AppHours.Model;
using AppHours.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppHours
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lectura = new TextService(@"d:\test.txt");

            var LecturaService = new LecturaService();

            var file = LecturaService.Leer(Lectura);

            List<PersonaModel> listaEmpleados = LecturaService.separarDatos(Lectura, file);

            ClsLogica objLogica = new ClsLogica();

            objLogica.Calculo(ref listaEmpleados);

            foreach (var lsE in listaEmpleados)
            {
                Console.WriteLine("The amount to pay " + lsE.strNombre + " is: " + lsE.intHoras + " USD");
            }

            Console.ReadKey();


        }
    }
}
