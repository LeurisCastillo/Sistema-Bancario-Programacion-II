using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class FachadaAppMovil
    {
        private CuentaAhorroNormal ahorroNormal = null;
        private AdaptadorCuentasDeAhorro superAhorro = null;
        private CertificadosFinancieros certificados = null;
        private Prestamos prestamos = null;


        #region Operaciones cuentas de ahorro
        public void OperacionesCuentasDeAhorro()
        {
            Console.WriteLine("Solo puede hacer consultas debido a que la app esta en fase de desarrollo\n" +
                "\n");

            Console.Write("[1]Ahorro normal [2]Super ahorro\n" +
                          "Que tipo es: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                ahorroNormal.Consulta();
            }
            else if(opcion == 2)
            {
                superAhorro.Consulta();
            }
            
        }

        #endregion

        #region Operaciones prestamos
        public void OperacionesPrestamos()
        {
            Console.WriteLine("Solo puede pagar prestamos debido a que la app esta en fase de desarrollo\n" +
                "\n");

            Console.Write("Introduzca el monto ha pagar");
            double pago = double.Parse(Console.ReadLine());
            prestamos.PagarPrestamo(pago);

        }
        #endregion

        #region Operaciones certificado financieros
        public void OperacionesCertificadosFinancieros()
        {
            Console.WriteLine("Solo puede Consultar interes debido a que la app esta en fase de desarrollo\n" +
                "\n");

            Console.Write("Introduzca el numero de certificado");
            string numeroCertificado = Console.ReadLine();

            certificados.ConsultarInteres(numeroCertificado);
        }
        #endregion

    }
}
