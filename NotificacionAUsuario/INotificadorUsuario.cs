using Dominio;

namespace NotificacionAUsuario
{   /// <summary>
    /// Resumen:Interfaz con procedimientos en comun para bitacoras o logs
    /// </summary>
    public interface INotificadorUsuario//Interface para notificar a un usuario

    {   /// <summary>
        /// Resumen:notifica a un usuario que posee un prestamo proximo vencer
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="titulo"></param>
        /// <param name="fechaLimite"></param>
        /// <returns></returns>
        string NotificarProximoAVencer(UsuarioSimple usuario, string titulo, string fechaLimite);

        /// <summary>
        /// Resumen:notifica a un usuario que posee un prestamo retrasado
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="titulo"></param>
        /// <param name="fechaLimite"></param>
        /// <returns></returns>
        string NotificarRetraso(UsuarioSimple usuario, string titulo, string fechaLimite);
    }
}
