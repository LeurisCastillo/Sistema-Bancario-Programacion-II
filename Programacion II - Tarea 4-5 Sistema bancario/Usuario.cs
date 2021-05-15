using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Usuario
    {
        
        public string NumeroCuentaAhorroNormal { get; set; }
        public double BalanceAhorroNormal { get; set; }

        public string NumeroCuentaSuperAhorro { get; set; }
        public double BalanceSuperAhorro { get; set; }

        public int NumeroPrestamo { get; set; }
        public double Prestamo { get; set; }

        public string NumeroTarjeta { get; set; }
        public double Limite { get; set; }
        public DateTime Expiracion { get; set; }

        public string NumeroCertificado { get; set; }
        public double Monto { get; set; }
        public DateTime TiempoDuracion { get; set; }
    }
}
