using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    // Interfaz que conoce el cliente
    interface ICuentaDeAhorro
    {
        string NumeroCuenta { get; set; }
        double Balance { get; set; }

        void CrearCuentaAhorro(string numeroCuenta, double montoApertura);
   
        double Deposito(double monto);

        double Retiro(double monto);

        void Consulta();
    }
}
