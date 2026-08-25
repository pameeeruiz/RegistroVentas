using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVentas
{
    internal class Program
    {

        /// <summary>
        /// GUTIERREZ RUIZ EVELYN PAMELA
        ///24/08/2026 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ///Solicitar la cantidad de ventas a registrar
            Console.WriteLine("Ingresa la cantidad de ventas a registrar: ");
            int cantidad = int.Parse(Console.ReadLine());


            ///arreglo para almacenar los nombres de los vendedores y las ventas
            string[] Nombreventas = new string[cantidad];
            double[] ventas = new double[cantidad];

            ///varaiables
            int totalVentas = 0;
            double suma = 0;
            double ventaMayor = 0;
            double ventaMenor = 0;

            ///ciclo, repite la captura de ventas y nombres de vendedores
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingresa el  nombre del vendedor:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingresa el monto de la venta:");
                double monto = double.Parse(Console.ReadLine());

                if (monto < 0)
                {
                    Console.WriteLine("El monto de la venta no puede ser negativo.");
                    ///control de flujo continue, para que vuelva a pedir el nombre y monto de la venta
                    continue;
                }

                if (monto ==0)
                {
                    Console.WriteLine("El monto de la venta no puede ser cero, Se finalizo el registro");
                    ///control de flujo break, para que salga del ciclo y finalice el registro
                    break;
                }

                ///guarda info
                Nombreventas[totalVentas] = nombre;
                ventas[totalVentas] = monto;


                ///Clasificar cada venta
                if (monto < 1000)
                {
                    Console.WriteLine("Es una Venta Baja");
                }
                else if (monto <5000)
                {
                    Console.WriteLine("Es una Venta Media");
                }
                else
                {
                    Console.WriteLine("Es una Venta Alta");
                }


                ///Estatisticas
                suma += monto;
                totalVentas++;

                //venta 1
                if (totalVentas == 1)
                {
                    ventaMayor = monto;
                    ventaMenor = monto;
                }
                else
                {
                    //venta mayor
                    if (monto > ventaMayor)
                    {
                        ventaMayor = monto;
                    }
                    //venta menor
                    if (monto < ventaMenor)
                    {
                        ventaMenor = monto;
                    }
                }
            }


            ///muestra estaidtsicos 

            Console.WriteLine("ESTADISTICAS");
            Console.WriteLine("Total de ventas: "+  totalVentas);
            Console.WriteLine("Suma de ventas acumuladas:"+ suma);


            if (totalVentas > 0)
            {
                double promedio = suma / totalVentas;

                Console.WriteLine("Promedio de ventas:"+ promedio);
                Console.WriteLine("Venta mayor:"+ ventaMayor);
                Console.WriteLine("Venta menor:"+ ventaMenor);
            }
            else
            {
                Console.WriteLine("No se registraron ventas.");
            }


            ///ITERADOR FOREACH

            Console.WriteLine("VENTAS REGISTRADAS:");

            foreach (string vndedor in Nombreventas)
            {
                if (vndedor != null)
                {
                    Console.WriteLine(vndedor);
                }
            }
            Console.WriteLine("programa finalizado...");

        }
    }
}
