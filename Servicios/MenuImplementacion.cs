using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Ejercicio1._2410.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirNumero()
        {
            int n;
            Console.WriteLine("Introduzca un número");
            n = Convert.ToInt32(Console.ReadLine());


            return n;

        }
    }
}
