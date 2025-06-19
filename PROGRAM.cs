using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_ALOIS
{
    internal class PROGRAM
    {
        

class Program
    {
        static void Main(string[] args)
        {
            GrafoT3 grafo = null;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1 - Agregar arista");
                Console.WriteLine("2 - Mostrar matriz");
                Console.WriteLine("3 - Cantidad de grupos");
                Console.WriteLine("4 - Es correlativo");
                Console.WriteLine("5 - Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (grafo == null)
                        {
                            Console.Write("Ingrese la cantidad de nodos: ");
                            int nodos = int.Parse(Console.ReadLine());
                            grafo = new GrafoT3(nodos);
                        }
                        Console.Write("Ingrese el nodo de origen: ");
                        int origen = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el nodo de destino: ");
                        int destino = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el peso de la arista: ");
                        int peso = int.Parse(Console.ReadLine());
                        grafo.AgregarArista(origen, destino, peso);
                        break;

                    case 2:
                        if (grafo != null)
                        {
                            grafo.MostrarMatriz();
                        }
                        else
                        {
                            Console.WriteLine("El grafo no ha sido creado.");
                        }
                        break;

                    case 3:
                        if (grafo != null)
                        {
                            int grupos = grafo.NumGrupos();
                            Console.WriteLine($"Cantidad de grupos: {grupos}");
                        }
                        else
                        {
                            Console.WriteLine("El grafo no ha sido creado.");
                        }
                        break;

                    case 4:
                        if (grafo != null)
                        {
                            Console.Write("Ingrese un nodo: ");
                            int nodo = int.Parse(Console.ReadLine());
                            bool correlativo = grafo.GrupoCorrelativo(nodo);
                            Console.WriteLine($"El grupo es correlativo: {correlativo}");
                        }
                        else
                        {
                            Console.WriteLine("El grafo no ha sido creado.");
                        }
                        break;

                    case 5:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }

}
}
