using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class AdaptadorCuentasDeAhorro : ICuentaDeAhorro
    {
        CuentaSuperAhorro superAhorro = new CuentaSuperAhorro();

        Usuario usuario = new Usuario();

        List<Usuario> listaUsuarios = new List<Usuario>();

        public string NumeroCuenta { get; set; }
        public double Balance { get; set; }

        #region Consulta
        public void Consulta()
        {
            Console.WriteLine("Ingrese su numero de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            foreach (var user in listaUsuarios)
            {
                if (numeroCuenta.Equals(user.NumeroCuentaSuperAhorro))
                {
                    Console.WriteLine($"Su balance es: {user.BalanceSuperAhorro}");
                }
            }

        }
        #endregion

        #region Crear cuenta super ahorro
        public void CrearCuentaAhorro(string numeroCuenta, double montoApertura)
        {
            NumeroCuenta = numeroCuenta;
            Balance = montoApertura;
            usuario.NumeroCuentaSuperAhorro = numeroCuenta;
            usuario.BalanceSuperAhorro = montoApertura;

            listaUsuarios.Add(usuario);

        }

        #endregion

        #region Deposito
        public double Deposito(double monto)
        {
            Console.WriteLine("Ingrese su numero de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            foreach (var user in listaUsuarios)
            {
                if (numeroCuenta.Equals(user.NumeroCuentaSuperAhorro))
                {
                    user.BalanceSuperAhorro += monto;
                    Console.WriteLine($"Ahora su balance es de: {user.BalanceSuperAhorro}");
                }
            }
            return Balance;
        }

        #endregion

        #region Retiro
        public double Retiro(double monto)
        {
            Console.WriteLine("Ingrese su numero de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            foreach (var user in listaUsuarios)
            {
                if (numeroCuenta.Equals(user.NumeroCuentaSuperAhorro))
                {
                                        // Realizamos la operacion en el adaptado
                    user.BalanceSuperAhorro = superAhorro.ValidarRetiro(monto);
                    Console.WriteLine($"Ahora su balance es de: {user.BalanceSuperAhorro}");
                    return Balance;

                }
            }
            return Balance;
        }
        #endregion
    }
}
