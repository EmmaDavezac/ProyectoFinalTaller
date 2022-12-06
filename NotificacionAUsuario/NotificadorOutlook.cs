using Dominio;
using System;
using System.Net;
using System.Net.Mail;

namespace NotificacionAUsuario
{   /// <summary>
    /// Resumen:es una implementacion de INotificar que nos permite enviar un mail a traves de una cuenta de Outlook
    /// </summary>
    public class NotificadorOutlook : INotificadorUsuario
    {   /// <summary>
        /// Resumen:Contraseña del correo electronico
        /// </summary>
        const string pass = "Tallerdeprogramacion2021";// contraseña de la cuenta de outlook
        /// <summary>
        /// Resumen: usuario de la cuenta de outlook
        /// </summary>
        const string usuario = "proyectofinaltallerdeprogramacion@outlook.com";
        /// <summary>
        /// Resumen:nombre del destinatario que aparecera en los mails mandados
        /// </summary>
        const string nombre = "Gestor de prestamos";

        public string NotificarProximoAVencer(UsuarioSimple to, string titulo, string fechaLimite)//metodo que nos permite enviar un mail mediante nuestra cuenta de outlook
        {
            const string encabezado = "Aviso de prestamo de material proximo a vencer";
            /// cuerpo del mail escrito en html
            string body = @"<style>
                            h1{color: black;}
                             h3{color: black;}
                            p{color: black;}
                            </style>
                            <h1>" + encabezado + "</h1>  <h3>Estimado " + to.Nombre + " " + to.Apellido + " , de acuerdo a nuestro registro usted tiene material con el periodo de prestamo proximo a finalizar.<br>Por favor devuelva el libro " + titulo + "  renueve el prestamo antes del " + fechaLimite + " para evitar penalizaciones.</h3> <br><p>Atte E-Library</p>";
            ///Asunto que aparecera en el mail enviado
            string asunto = "Informe de prestamo proximo a vencer";
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde (Usuario: " + to.NombreUsuario + ").";//mensaje en el caso de que falle el envio
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(usuario, nombre)//le asignamos al remitente nuestro nombre y nuestra direccion de correo
                };//creamos una instancia de la clase MailMessage que representa un correo electronico
                mail.To.Add(to.Mail);//añadimos un destinataro a la lista de destinatarios del correo

                mail.Subject = asunto;//le asignamos el asunto al mail
                mail.Body = body;//le asignamos al cuerpo del mail el parametro body que representa el cuerpo del mail
                mail.IsBodyHtml = true;//establecemos que el cuerpo del objeto es un html
                SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587)
                {
                    Credentials = new NetworkCredential(usuario, pass),//indicamos el usuario y contraseña de la cuenta de correo
                    EnableSsl = true//indicamos que el proveedor de mail posee cifrado ssl
                }; //Aquí establecemos el servidor SMTP Y el puerto
                client.Send(mail);//enviamos el mail
                return msge = "¡Correo enviado exitosamente!(Usuario: " + to.NombreUsuario + ").";//mensaje en el caso de que el envio se realizo correctamente
            }
            catch (Exception ex)//captamos la excepcion en el caso de que el codigo entre el bloque try haya lanzado una interrupcion
            {
                return msge + "-" + ex.Message + ex.StackTrace;//mensaje en el caso de que falle el envio esto deveria registrarse en log
            }
        }
        /// <summary>
        /// Resumen:  nos permite enviar un mail mediante nuestra cuenta de outlook
        /// </summary>
        /// <param name="to"></param>
        /// <param name="titulo"></param>
        /// <param name="fechaLimite"></param>
        /// <returns>nos devuelve una cxadena que nos indica si el mensaje fue enviado correctmente o no</returns>
        public string NotificarRetraso(UsuarioSimple to, string titulo, string fechaLimite)
        {
            const string encabezado = "Aviso de prestamo de prestamo retrasado";
            string body = @"<style>
                            h1{color:black;}
                            h3{color: black;}
                            p{color: black;}
                            </style>
                            <h1>" + encabezado + "</h1> <h3>Estimado " + to.Nombre + " " + to.Apellido + " , de acuerdo a nuestro registro usted no ha devuelto a tiempo un material prestado, el prestamo a vencido el " + fechaLimite + " . <br>Por favor devuelva el libro " + titulo + " para evitar penalizaciones.</h3> <br> <p>Atte E-Library</p>";
            string asunto = "Informe Prestamo Retrasado";
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde (Usuario: " + to.NombreUsuario + ").";//mensaje en el caso de que falle el envio
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(usuario, nombre)//le asignamos al remitente nuestro nombre y nuestra direccion de correo
                };//creamos una instancia de la clase MailMessage que representa un correo electronico
                mail.To.Add(to.Mail);//añadimos un destinataro a la lista de destinatarios del correo

                mail.Subject = asunto;//le asignamos el asunto al mail
                mail.Body = body;//le asignamos al cuerpo del mail el parametro body que representa el cuerpo del mail
                mail.IsBodyHtml = true;//establecemos que el cuerpo del objeto es un html
                SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587)
                {
                    Credentials = new NetworkCredential(usuario, pass),//indicamos el usuario y contraseña de la cuenta de correo
                    EnableSsl = true//indicamos que el proveedor de mail posee cifrado ssl
                }; //Aquí establecemos el servidor SMTP Y el puerto
                client.Send(mail);//enviamos el mail
                return msge = "¡Correo enviado exitosamente!(Usuario: " + to.NombreUsuario + ").";//mensaje en el caso de que el envio se realizo correctamente
            }
            catch (Exception ex)//captamos la excepcion en el caso de que el codigo entre el bloque try haya lanzado una interrupcion
            {
                return msge + "-" + ex.Message + ex.StackTrace;//mensaje en el caso de que falle el envio esto deveria registrarse en log
            }

        }
    }
}
