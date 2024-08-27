using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            LisrtasEnlazadas ls = new LisrtasEnlazadas();
            ls.insertar(12);
            ls.insertar(5);
            ls.insertar(10);
            ls.insertar(23);
            int op=100;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------MENÚ-----------");
                Console.WriteLine("[1]Mostrar lista");
                Console.WriteLine("[2]Ingresar elemento");
                Console.WriteLine("[3]Actualizar lista");
                Console.WriteLine("[4]Eliminar elemento");
                Console.WriteLine("[5]Ordenar lista");
                Console.WriteLine("[0]Salir");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Opción: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("-----------LISTA-----------");
                        ls.mostrar();
                        Console.WriteLine(" ");
                        Console.WriteLine("---------------------------");
                        Console.ReadKey(); break;
                    case 2:
                        Console.WriteLine("-----------LISTA-----------");
                        Console.Write("Ingrese número a agregar: ");
                        int agregar = int.Parse((string) Console.ReadLine());
                        ls.insertar(agregar);
                        Console.WriteLine("Número agregado.");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Nueva lista: ");
                        ls.mostrar();
                        Console.WriteLine(" ");
                        Console.WriteLine("---------------------------");
                        Console.ReadKey(); break;
                    case 3:
                        Console.WriteLine("---------ACTUALIZAR--------");
                        Console.WriteLine("Ingrese número a reemplazar: ");
                        int busc = int.Parse(Console.ReadLine());
                        if (ls.buscar(busc)==false)
                        {
                            Console.WriteLine("Ingrese un número valido...");
                        }
                        else
                        {
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Ingrese el nuevo número: ");
                            int nunu = int.Parse(Console.ReadLine());
                            ls.actualizar(busc,nunu);
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Lista actualizada.");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Nueva lista: ");
                            ls.mostrar();
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine("---------------------------");
                        Console.ReadKey(); break;
                    case 4:
                        Console.WriteLine("---------ELIMINAR----------");
                        Console.WriteLine("Ingrese número a eliminar: ");
                        int el = int.Parse(Console.ReadLine());
                        ls.eliminar(el); 
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Lista actualizada.");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Nueva lista: ");
                        ls.mostrar();
                        Console.WriteLine(" ");
                        Console.WriteLine("---------------------------");
                        Console.ReadKey(); break;
                    case 5:
                        Console.WriteLine("----------ORDENAR----------");
                       
                       
                        Console.WriteLine("[1]Ordenar descendentemente");
                        Console.WriteLine("[2]Ordenar ascendentemente");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Seleccione una opción: ");
                        int opc = int.Parse(Console.ReadLine());
                        if (opc == 1 )
                        {
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Lista ordenada descendentemente");
                            ls.Ord_Desc();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Nueva lista: ");
                            ls.mostrar();
                            Console.WriteLine(" ");
                            Console.WriteLine("---------------------------");
                        }
                        else if(opc == 2)
                        {
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Lista ordenada ascendentemente");
                            ls.Ord_Asc();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Nueva lista: ");
                            ls.mostrar();
                            Console.WriteLine(" ");
                            Console.WriteLine("---------------------------");
                        }
                        Console.ReadKey(); break;
                }
                
            } while (op!=0);

            Console.WriteLine("Saliendo....");
            Console.ReadKey();

        }
    }
}
