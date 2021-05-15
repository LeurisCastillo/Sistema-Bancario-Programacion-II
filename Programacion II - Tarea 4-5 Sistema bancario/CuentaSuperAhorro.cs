using System;
using System.Collections.Generic;

namespace SistemaBancario
{
    // Esta es la clase que deseamos adaptar, el cliente no la puede usar directamente
    // pues su interfaz es diferente
    class CuentaSuperAhorro
    {
        Usuario usuario = new Usuario();

        public string NumeroCuenta { get; set; }
        public double Balance { get; set; }

        List<Usuario> listaUsuarios = new List<Usuario>();


        #region Crear cuenta de super ahorro
        public void CrearCuentaSuperAhorro(string numeroCuenta, double montoApertura)
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
        private double Retiro(double monto)
        {
            Console.WriteLine("Ingrese su numero de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            foreach (var user in listaUsuarios)
            {
                if (numeroCuenta.Equals(user.NumeroCuentaSuperAhorro))
                {
                    user.BalanceSuperAhorro -= monto;
                    Console.WriteLine($"Ahora su balance es de: {user.BalanceSuperAhorro}");

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
                if (numeroCuenta.Equals(user.NumeroCuentaSuperAhorro))
                {
                    Console.WriteLine($"Su balance es: {user.BalanceSuperAhorro}");
                }
            }
        }
        #endregion

        #region Validar retiro
        public double ValidarRetiro(double monto)
        {
            Console.WriteLine("Ingrese su numero de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            foreach (var user in listaUsuarios)
            {
                if (numeroCuenta.Equals(user.NumeroCuentaSuperAhorro))
                {
                    if (monto <= (user.BalanceSuperAhorro * 0.4))
                    {
                        user.BalanceSuperAhorro = Retiro(monto);
                    }
                    else
                    {
                        Console.WriteLine("El monto ha retirar es muy alto, no se hizo retiro");
                    }
                }
            }
            return Balance;
        }
        #endregion
    }
}
