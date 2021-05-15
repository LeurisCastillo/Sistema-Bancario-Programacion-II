using System;
using System.Collections.Generic;

namespace SistemaBancario
{
    class Prestamos
    {
        Usuario usuario = new Usuario();

        public const float tasa = 0.1f;
        public int NumeroPrestamo { get; set; }
        public double Prestamo { get; set; }

        List<Usuario> listaUsuarios = new List<Usuario>();

        #region Apertura
        public void Apertura(int numeroPrestamo, double monto)
        {
            Prestamo = monto;
            NumeroPrestamo = numeroPrestamo;
            usuario.NumeroPrestamo = numeroPrestamo;
            usuario.Prestamo = monto;

            listaUsuarios.Add(usuario);
        }
        #endregion

        #region Pagar prestamos
        public double PagarPrestamo(double pago)
        {
            Console.WriteLine("Ingrese su numero de prestamo: ");
            string numeroPrestamo = Console.ReadLine();

            foreach (var user in listaUsuarios)
            {
                if (numeroPrestamo.Equals(user.NumeroPrestamo))
                {
                    user.Prestamo -= pago;

                    System.Console.WriteLine($"Le falta por pagar: {user.Prestamo}");

                }
            }
            return Prestamo;
        }
        #endregion
    }
}
