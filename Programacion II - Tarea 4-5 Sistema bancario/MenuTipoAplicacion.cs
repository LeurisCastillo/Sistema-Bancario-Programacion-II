using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class MenuTipoAplicacion
    {   
         public static void Menu()
         {
            int opcion;
            do
            {
                Console.Clear();

                Console.WriteLine("Que version desea utilizar?\n" +
                              "[1] App de escritorio  [2] App movil [3] Salir\n" +
                              "\n");
                Console.Write("Introduzca su opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AppEscritorio.Menu();
                        break;

                    case 2:
                        AppMovil.Menu();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo....");
                        Environment.Exit(1);
                        break;
                }
                    Console.ReadKey();
            } while (opcion != 3);
         }
    }
}