using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class CertificadosFinancieros
    {
        Usuario usuario = new Usuario();

        public string NumeroCertificado { get; set; }
        public double Monto { get; set; }
        public DateTime TiempoDuracion { get; set; }

        List<Usuario> listaUsuarios = new List<Usuario>();

        #region Apertura
        public void Apertura(string numeroCertificado, double monto, DateTime tiempoDuracion)
        {
            NumeroCertificado = numeroCertificado;
            Monto = monto;
            TiempoDuracion = tiempoDuracion;
            usuario.NumeroCertificado = numeroCertificado;
            usuario.Monto = monto;
            usuario.TiempoDuracion = tiempoDuracion;

            listaUsuarios.Add(usuario);
        }
        #endregion

        #region Consultar interes
        public double ConsultarInteres(string numeroCertificado)
        {

            foreach (var user in listaUsuarios)
            {
                if (numeroCertificado.Equals(user.NumeroCertificado))
                {
                    Console.WriteLine($"Su monto fue de: {user.Monto}\n" +
                                      $"Ahora es de: {user.TiempoDuracion.Year *user.Monto}");

                }
            }
            return Monto;
        }
        #endregion
    }
}
