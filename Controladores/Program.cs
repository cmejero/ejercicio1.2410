using edu.Ejercicio1._2410.Servicios;

namespace edu.Ejercicio1._2410.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();
            int numSelec = mi.pedirNumero();
            oi.menuBucle(numSelec);
          
            int opcionSeleccionada;
            bool cerrarMenu = false;

            while (!cerrarMenu) 
            {
                opcionSeleccionada = mi.pedirNumero(); ;
                Console.WriteLine(opcionSeleccionada);

                switch(opcionSeleccionada)
                    {
                    case 0:
                        Console.WriteLine("Se ha ejecutado la opción 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Se ha ejecutado la opción 1");
                        oi.menuBucle(numSelec);
                        break;
                    default:
                        Console.WriteLine("La opcion elejida no corresponde con ninguna");
                        break;

                
                }
            }
        }
    }
}