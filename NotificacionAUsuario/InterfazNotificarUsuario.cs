using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace NotificacionAUsuario
{
    public class InterfazNotificarUsuario
    {
        static string[] implementacionesNotificar = new string[] { "MailOutlook" };
        static private string implementacionNotificar = implementacionesNotificar[0];

        public INotificarUsuario GetNotificarUsuario(string unNotificarCliente)
        {
            switch (unNotificarCliente)
            {
                case "MailOutlook": { return new EnviarMailOutlook(); }
                default:
                    { return new EnviarMailOutlook(); }

            }
        }

        public string NotificarProximoAVencer(UsuarioSimple pUsuario)
        {
           return GetNotificarUsuario(implementacionNotificar).NotificarProximoAVencer(pUsuario);
        }
        public string NotificarRetraso(UsuarioSimple pUsuario)
        {
            return GetNotificarUsuario(implementacionNotificar).NotificarRetraso(pUsuario);
        }
    }
}
