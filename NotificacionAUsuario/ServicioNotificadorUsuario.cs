﻿using Dominio;

namespace NotificacionAUsuario
{
    public class ServicioNotificadorUsuario//Fachada de la libreria
    {
        static string[] implementacionesNotificar = new string[] { "MailOutlook" };//lista de implementacions de iNotificarUsuario
        static private string implementacionNotificar = implementacionesNotificar[0];//Implementacion que estamos usando

        public INotificadorUsuario GetNotificarUsuario()//metodo que nos devuelve una implementacion de iNotificarUsuario
        {
            switch (implementacionNotificar)
            {
                case "MailOutlook": { return new NotificadorOutlook(); }
                default:
                    { return new NotificadorOutlook(); }

            }
        }

        public string NotificarProximoAVencer(UsuarioSimple usuario, string titulo, string fechaLimite)//Metodo que nos permite notificar a un usuario que su prestamo esta proximo a vencer
        {
            return GetNotificarUsuario().NotificarProximoAVencer(usuario, titulo, fechaLimite);
        }
        public string NotificarRetraso(UsuarioSimple usuario,string titulo,string fechaLimite)//Metodo que nos permite notificar a un usuario que su prestamo esta retrasado
        {
            return GetNotificarUsuario().NotificarRetraso(usuario, titulo,  fechaLimite);
        }
    }
}