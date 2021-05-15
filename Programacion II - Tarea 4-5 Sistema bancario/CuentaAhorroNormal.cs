using System;
using System.Collections.Generic;

namespace SistemaBancario
{
    class CuentaAhorroNormal : ICuentaDeAhorro
    {
        public Usuario usuario = new Usuario();

        public string NumeroCuenta { get; set; }
        public double Balance { get; set; }

        public List<Usuario> listaUsuarios = new List<Usuario>();

        #region Crear cuenta de ahorro normal
        public void CrearCuentaAhorro(string numeroCuenta, double montoApertura)
        {
            NumeroCuenta = numeroCuenta;
            Balance = montoApertura;
            usuario.NumeroCuentaAhorroNormal = numeroCuenta;
            usuario.BalanceAhorroNormal = montoApertura;

            listaUsuarios.Add(usuario);
        }
        #endregion

        #region Deposito
        public double Deposito(double monto)
        {
            Console.Write("Ingrese su numero de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            foreach (var user in listaUsuarios)
            {
                if (numeroCuenta.Equals(user.NumeroCuentaAhorroNormal))
                {
                    user.BalanceAhorroNormal += monto;
                    Console.WriteLine($"Ahora su balance es de: {user.BalanceAhorroNormal}");
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
                if (numeroCuenta.Equals(user.NumeroCuentaAhorroNormal))
                {
                    user.BalanceAhorroNormal -= monto;
                    Console.WriteLine($"Ahora su balance es de: {user.BalanceAhorroNormal}");

                }
            }
            return Balance;
        }
        #endregion

        #region Consulta 
        public void Consulta()
        {
            Console.WriteLine("Ingrese su numero de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            foreach (var user in listaUsuarios)
            {
                if (numeroCuenta.Equals(user.NumeroCuentaAhorroNormal))
                {
                    Console.WriteLine($"Su balance es: {user.BalanceAhorroNormal}");
                }
            }
        }
        #endregion
    }
}
