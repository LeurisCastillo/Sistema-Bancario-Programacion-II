using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class AppMovil
    {
        public static void Menu()
        {
            FachadaAppMovil fachada = new FachadaAppMovil();
            int opcion;

            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("     ----Menu Bancario----\n");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("[1] Acceder a cuentas de ahorros\n" +
                                  "[2] Acceder a prestamos\n" +
                                  "[3] Acceder a certificados financieros\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Elija su opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        fachada.OperacionesCuentasDeAhorro();
                        break;

                    case 2:
                        fachada.OperacionesPrestamos();
                        break;

                    case 3:
                        fachada.OperacionesCertificadosFinancieros();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            } while (opcion <= 3 && opcion >= 1);

        }
    }
}
