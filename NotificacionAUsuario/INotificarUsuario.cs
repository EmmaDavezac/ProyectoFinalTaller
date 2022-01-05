using Dominio;

namespace NotificacionAUsuario
{
    public interface INotificarUsuario//Interface para notificar a un usuario
    {
        string NotificarProximoAVencer(UsuarioSimple usuario);//Metodo para notificar a un usuario que posee un prestamo proximo vencer
        string NotificarRetraso(UsuarioSimple usuario);//Metodo para notificar a un usuario que posee un prestamo retrasado
    }
}
