using Dominio;

namespace NotificacionAUsuario
{
    public interface INotificarUsuario
    {
        string NotificarProximoAVencer(UsuarioSimple usuario);
        string NotificarRetraso(UsuarioSimple usuario);
    }
}