using Dominio;

namespace NotificacionAUsuario
{
    public class FachadaNotificarUsuario//Fachada de la libreria
    {
        static string[] implementacionesNotificar = new string[] { "MailOutlook" };//lista de implementacions de iNotificarUsuario
        static private string implementacionNotificar = implementacionesNotificar[0];//Implementacion que estamos usando

        public INotificarUsuario GetNotificarUsuario()//metodo que nos devuelve una implementacion de iNotificarUsuario
        {
            switch (implementacionNotificar)
            {
                case "MailOutlook": { return new EnviarMailOutlook(); }
                default:
                    { return new EnviarMailOutlook(); }

            }
        }

        public string NotificarProximoAVencer(UsuarioSimple pUsuario)//Metodo que nos permite notificar a un usuario que su prestamo esta proximo a vencer
        {
            return GetNotificarUsuario().NotificarProximoAVencer(pUsuario);
        }
        public string NotificarRetraso(UsuarioSimple pUsuario)//Metodo que nos permite notificar a un usuario que su prestamo esta retrasado
        {
            return GetNotificarUsuario().NotificarRetraso(pUsuario);
        }
    }
}
