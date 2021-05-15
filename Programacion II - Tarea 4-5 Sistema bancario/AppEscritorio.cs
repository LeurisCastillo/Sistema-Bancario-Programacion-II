using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class AppEscritorio
    {
        public static void Menu()
        { 
            int opcion;
            do
            {
                Console.Clear();

                Console.WriteLine("----Menu Bancario - App de escritorio----\n");

                Console.Write("[1] Acceder a cuentas de ahorros\n" +
                                  "[2] Acceder a prestamos\n" +
                                  "[3] Acceder a tarjetas de creditos\n" +
                                  "[4] Acceder a certificados financieros\n" +
                                  "[5] Ir al menu principal\n" +
                                  "[6] Salir\n" +
                                  "\n" +
                                  "Elija su opcion: \n");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        FachadaEscritorio.OperacionCuentasDeAhorro();
                        break;

                    case 2:
                        FachadaEscritorio.OperacionesPrestamos();
                        break;

                    case 3:
                        FachadaEscritorio.OperacionTarjetasDeCredito();
                        break;

                    case 4:
                        FachadaEscritorio.OperacionesCertificadosFinancieros();
                        break;

                    case 5:
                        MenuTipoAplicacion.Menu();
                        break;

                    case 6:
                        Console.WriteLine("Saliendo....");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("OPCION INCORRECTA");
                        break;
                }

            } while (true);
        }
    }
}
