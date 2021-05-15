using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class TarjetasDeCredito
    {
        Usuario usuario = new Usuario();

        public string NumeroTarjeta { get; set; }
        public double Limite { get; set; }
        public DateTime Expiracion { get; set; }

        List<Usuario> listaUsuarios = new List<Usuario>();

        #region Apertura
        public void Apertura(string numeroTarjeta, double limite, DateTime expiracion)
        {
            NumeroTarjeta = numeroTarjeta;
            Limite = limite;
            Expiracion = expiracion;
            usuario.NumeroTarjeta = numeroTarjeta;
            usuario.Limite = limite;
            usuario.Expiracion = expiracion;

            listaUsuarios.Add(usuario);
        }
        #endregion

        #region Consumos
        public void Consumos(double montoConsumido, string numeroTarjeta)
        {
            foreach (var user in listaUsuarios)
            {
                if (numeroTarjeta.Equals(user.NumeroTarjeta))
                {
                    Console.WriteLine($"Usted ha consumido: {montoConsumido}");
                }
            }
        }

        #endregion

        #region Pagos
        public void Pagos(double montoAPagar, string numeroTarjeta)
        {
            foreach (var user in listaUsuarios)
            {
                if (numeroTarjeta.Equals(user.NumeroTarjeta))
                {
                    Console.WriteLine($"Usted ha pagado: {montoAPagar}");
                }
            }
        }
        #endregion
    }
}