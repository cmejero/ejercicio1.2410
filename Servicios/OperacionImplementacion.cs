using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Ejercicio1._2410.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void menuBucle(int k)
        {
            MenuInterfaz mi = new MenuImplementacion();
            
            int suma = 0;
            
           k= Convert.ToInt32(Console.ReadLine());
           

            for (int i = 0; i <= k; i++)
            {
                i += suma;
                Console.WriteLine(i);
            }
            



        }

    }
}
