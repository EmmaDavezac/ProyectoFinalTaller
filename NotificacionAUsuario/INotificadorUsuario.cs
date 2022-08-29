using Dominio;

namespace NotificacionAUsuario
{
    public interface INotificadorUsuario//Interface para notificar a un usuario
    {
        string NotificarProximoAVencer(UsuarioSimple usuario,string titulo,string fechaLimite);//Metodo para notificar a un usuario que posee un prestamo proximo vencer
        string NotificarRetraso(UsuarioSimple usuario, string titulo, string fechaLimite);//Metodo para notificar a un usuario que posee un prestamo retrasado
    }
}
