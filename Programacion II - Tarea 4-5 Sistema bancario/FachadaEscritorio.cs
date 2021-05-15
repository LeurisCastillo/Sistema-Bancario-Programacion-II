using System;
using System.Collections.Generic;

namespace SistemaBancario
{
    static class FachadaEscritorio
    {
        private static CuentaAhorroNormal ahorroNormal = null;
        private static AdaptadorCuentasDeAhorro superAhorro = null;
        private static Prestamos prestamos = null;
        private static TarjetasDeCredito tarjetas = null;
        private static CertificadosFinancieros certificados = null;

       
        #region Operaciones Cuentas de Ahorro 

        public static void OperacionCuentasDeAhorro()
        {
            Console.WriteLine("--Tipo de cuenta--\n" +
                              "[1] Ahorro normal [2] super ahorro\n" +
                              "\n");
            Console.Write("Introduzca el tipo de cuenta: ");
            int tipoCuenta = int.Parse(Console.ReadLine());

            if (tipoCuenta.Equals(1))
            {
                Console.Write("Tiene una cuenta?\n" +
                              "[si] [no]\n" +
                              "\n" +
                              "Escriba su respuesta: ");
                string respuesta = Console.ReadLine();                  // Si el usuario no tiene cuenta y realiza una operacion se explota el programa XD.
                                                                        // Usar bajo sumo cuidado. En futuras versiones implementar try catch.
                switch (respuesta)
                {                
                    case "si":
                        MenuOperacionCuentaAhorroNormal();
                        break;

                    case "no":
                        Console.Write("Introduzca numero de cuenta: ");
                        string numeroCuenta = Console.ReadLine();

                        Console.Write("Introduzca monto de apertura:");
                        double montoApertura = double.Parse(Console.ReadLine());

                        ahorroNormal = new CuentaAhorroNormal();
                        ahorroNormal.CrearCuentaAhorro(numeroCuenta, montoApertura);

                        
                        MenuOperacionCuentaAhorroNormal();
                        break;
                }

            }

            else if (tipoCuenta.Equals(2))
            {
                Console.Write("Tiene una cuenta?\n" +
                              "[si] [no]\n" +
                              "\n" +
                               "Escriba su respuesta: ");
                string respuesta = Console.ReadLine();

                switch (respuesta)
                {

                    case "si":
                        MenuOperacionCuentaSuperAhorro();
                        break;

                    case "no":
                        Console.Write("Introduzca numero de cuenta: ");
                        string numeroCuenta = Console.ReadLine();

                        Console.Write("Introduzca monto de apertura:");
                        double montoApertura = double.Parse(Console.ReadLine());

                        superAhorro = new AdaptadorCuentasDeAhorro();
                        superAhorro.CrearCuentaAhorro(numeroCuenta, montoApertura);

                        MenuOperacionCuentaSuperAhorro();
                        break;
                }

            }

        }
        #endregion

        #region Operaciones Prestamos
        public static void OperacionesPrestamos()
        {
            Console.WriteLine("Que operacion desea realizar?\n" +
                              "[1]Hacer una apertura [2]Pagar Prestamo [3]Ir a menu principal\n" +
                              "\n");
            Console.Write("Introduzca su respuesta: ");
            int operacion = int.Parse(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    Console.Write("Introduzca numero de prestamo: ");
                    int numeroPrestamo = int.Parse(Console.ReadLine());

                    Console.Write("Introduzca numero de monto: ");
                    double monto = double.Parse(Console.ReadLine());

                    prestamos = new Prestamos();
                    prestamos.Apertura(numeroPrestamo, monto);
                    break;

                case 2:
                    Console.Write("Introduzca el monto ha pagar: ");
                    double pago = double.Parse(Console.ReadLine());

                    prestamos.PagarPrestamo(pago);
                    break;

                case 3:
                    MenuTipoAplicacion.Menu();
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    MenuTipoAplicacion.Menu();
                    break;
            }
            Console.ReadKey();
        }
        #endregion

        #region Operacion Tarjetas de credito

        public static void OperacionTarjetasDeCredito()
        {
            Console.WriteLine("Que operacion desea realizar?\n" +
                  "[1]Hacer una apertura de tarjeta [2]Consumir tarjeta [3]pagar tarjeta [4]Ir a menu principal\n" +
                  "\n");
            Console.Write("Introduzca su respuesta: ");
            int operacion = int.Parse(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    Console.WriteLine("Introduzca el numero de tarjeta: ");
                    string numeroTarjeta = Console.ReadLine();

                    Console.WriteLine("Introduzca el monto limite: ");
                    double limite = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca fecha de expiracion: ");
                    DateTime expiracion = DateTime.Parse(Console.ReadLine());

                    tarjetas = new TarjetasDeCredito();
                    tarjetas.Apertura(numeroTarjeta, limite, expiracion);
                    break;

                case 2:
                    Console.WriteLine("Introduzca el monto ha consumir: ");
                    double montoConsumido = double.Parse(Console.ReadLine());

                    numeroTarjeta = "";
                    Console.WriteLine("Ingrese su numero de tarjera: ");
                    numeroTarjeta = Console.ReadLine();

                    tarjetas.Consumos(montoConsumido, numeroTarjeta);
                    break;

                case 3:
                    Console.WriteLine("Introduzca el monto ha pagar: ");
                    double montoAPagar = double.Parse(Console.ReadLine());

                    numeroTarjeta = "";
                    Console.WriteLine("Ingrese su numero de tarjera: ");
                    numeroTarjeta = Console.ReadLine();

                    tarjetas.Pagos(montoAPagar, numeroTarjeta);
                    break;

                case 4:
                    MenuTipoAplicacion.Menu();
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    MenuTipoAplicacion.Menu();
                    break;
            }
            Console.ReadKey();

        }
        #endregion

        #region Operaciones Certificados financieros

        public static void OperacionesCertificadosFinancieros()
        {
            Console.WriteLine("Que operacion desea realizar?\n" +
                  "[1]Hacer una apertura de certificado [2]Consultar interes  [3]Ir a menu principal\n" +
                  "\n");
            Console.Write("Introduzca su respuesta: ");
            int operacion = int.Parse(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    Console.WriteLine("Introduzca el numero de tarjeta: ");
                    string numeroCertificado = Console.ReadLine();

                    Console.WriteLine("Introduzca el monto limite: ");
                    double monto = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca fecha de expiracion: ");
                    DateTime tiempoDuracion = DateTime.Parse(Console.ReadLine());

                    certificados = new CertificadosFinancieros();
                    certificados.Apertura(numeroCertificado, monto, tiempoDuracion);
                    break;

                case 2:
                    numeroCertificado = "";
                    Console.WriteLine("Ingrese su numero de certificado: ");
                    numeroCertificado = Console.ReadLine();
                    certificados.ConsultarInteres(numeroCertificado);
                    break;

                case 4:
                    MenuTipoAplicacion.Menu();
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    MenuTipoAplicacion.Menu();
                    break;
            }
            Console.ReadKey();

        }
        #endregion


        public static void MenuOperacionCuentaAhorroNormal()
        {
            do
            {
                Console.Clear();

                Console.Write("[1] Deposito [2] Retiro [3] Consulta [4] Ir al menu principal\n" +
                              "Elije la opcion ha realizar: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduzca el monto a depositar: ");
                        double montoDeposito = double.Parse(Console.ReadLine());
                        ahorroNormal.Deposito(montoDeposito);
                        break;

                    case 2:
                        Console.Write("Introduzca el monto a retirar: ");
                        double montoRetiro = double.Parse(Console.ReadLine());
                        ahorroNormal.Retiro(montoRetiro);
                        break;

                    case 3:
                         ahorroNormal.Consulta();
                        break;

                    case 4:
                        MenuTipoAplicacion.Menu();
                        break;
                }

                Console.ReadKey();

            } while (true);
        }

        public static void MenuOperacionCuentaSuperAhorro()
        {
            do
            {
                Console.Clear();

                Console.Write("[1] Deposito [2] Retiro [3] Consulta [4] Ir al menu principal\n" +
                              "Elije la opcion ha realizar: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduzca el monto a depositar: ");
                        double montoDeposito = double.Parse(Console.ReadLine());
                        superAhorro.Deposito(montoDeposito);
                        break;

                    case 2:
                        Console.Write("Introduzca el monto a retirar: ");
                        double montoRetiro = double.Parse(Console.ReadLine());
                        superAhorro.Retiro(montoRetiro);
                        break;

                    case 3:
                        superAhorro.Consulta();
                        break;

                    case 4:
                        MenuTipoAplicacion.Menu();
                        break;
                }

                Console.ReadKey();
            } while (true);
        }
    }
}
