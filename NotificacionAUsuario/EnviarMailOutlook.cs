﻿using System;
using System.Net.Mail;
using System.Net;
using Dominio;


namespace NotificacionAUsuario
{
    public class EnviarMailOutlook:INotificarUsuario//es una clase que nos permite enviar un mail a traves de una cuenta de Outlook
    {
        const string pass = "Tallerdeprogramacion2021";// contraseña de la cuenta de outlook
        const string usuario = "proyectofinaltallerdeprogramacion@outlook.com";// usuario de la cuenta de outlook
        const string nombre = "Gestor de prestamos";//nuestro nombre de destinatario

        public string NotificarProximoAVencer(UsuarioSimple to)//metodo que nos permite enviar un mail mediante nuestra cuenta de outlook
        {
            
            const string encabezado = "Aviso de prestamo de material proximo a vencer";
            
            string body = @"<style>
                            h1{color: black;}
                            
                            p{color: black;}
                            </style>
                            <h1>" + encabezado + "</h1>  <p>Estimado " + to.Nombre + " " + to.Apellido + " , de acuerdo a nuestro registro usted tiene material con el periodo de prestamo proximo a finalizar.<br>Por favor devuelva o renueve el prestamo antes de la fecha limite para evitar penalizaciones. <br>Atte Gestor de prestamos</p>";
            string asunto = "Informe de prestamo proximo a vencer";
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde (Usuario: " + to.NombreUsuario + ").";//mensaje en el caso de que falle el envio

            try
            {
                MailMessage mail = new MailMessage();//creamos una instancia de la clase MailMessage que representa un correo electronico
                mail.From = new MailAddress(usuario, nombre);//le asignamos al remitente nuestro nombre y nuestra direccion de correo
                mail.To.Add(to.Mail);//añadimos un destinataro a la lista de destinatarios del correo

                mail.Subject = asunto;//le asignamos el asunto al mail
                mail.Body = body;//le asignamos al cuerpo del mail el parametro body que representa el cuerpo del mail
                mail.IsBodyHtml = true;//establecemos que el cuerpo del objeto es un html


                SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587); //Aquí establecemos el servidor SMTP Y el puerto
                client.Credentials = new NetworkCredential(usuario, pass);//indicamos el usuario y contraseña de la cuenta de correo
                client.EnableSsl = true;//indicamos que el proveedor de mail posee cifrado ssl


                client.Send(mail);//enviamos el mail
                return msge = "¡Correo enviado exitosamente!(Usuario: " + to.NombreUsuario + ").";//mensaje en el caso de que el envio se realizo correctamente

            }
            catch (Exception ex)//captamos la excepcion en el caso de que el codigo entre el bloque try haya lanzado una interrupcion
            {
                return msge+"-"+ex.Message + ex.StackTrace;//mensaje en el caso de que falle el envio esto deveria registrarse en log
            }

           

        }
        public string NotificarRetraso(UsuarioSimple to)//metodo que nos permite enviar un mail mediante nuestra cuenta de outlook
        {

            const string encabezado = "Aviso de prestamo de prestamo retrasado";
          
            string body = @"<style>
                            h1{color:black;}
                            h2{color: #0000;}
                            p{color: #0000;}
                            </style>
                            <h1>" + encabezado + "</h1> <h2>Estimado " + to.Nombre + " " + to.Apellido + " , de acuerdo a nuestro registro usted no ha devuelto a tiempo un material prestado. <br> Por favor devuelva o renueve el prestamo antes de la fecha limite para evitar penalizaciones. <br> Atte Gestor de prestamos</h2>";
            string asunto = "Informe Prestamo Retrasado";
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde (Usuario: "+to.NombreUsuario+").";//mensaje en el caso de que falle el envio

            try
            {
                MailMessage mail = new MailMessage();//creamos una instancia de la clase MailMessage que representa un correo electronico
                mail.From = new MailAddress(usuario, nombre);//le asignamos al remitente nuestro nombre y nuestra direccion de correo
                mail.To.Add(to.Mail);//añadimos un destinataro a la lista de destinatarios del correo

                mail.Subject = asunto;//le asignamos el asunto al mail
                mail.Body = body;//le asignamos al cuerpo del mail el parametro body que representa el cuerpo del mail
                mail.IsBodyHtml = true;//establecemos que el cuerpo del objeto es un html


                SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587); //Aquí establecemos el servidor SMTP Y el puerto
                client.Credentials = new NetworkCredential(usuario, pass);//indicamos el usuario y contraseña de la cuenta de correo
                client.EnableSsl = true;//indicamos que el proveedor de mail posee cifrado ssl


                client.Send(mail);//enviamos el mail
                return msge = "¡Correo enviado exitosamente!(Usuario: " + to.NombreUsuario + ").";//mensaje en el caso de que el envio se realizo correctamente

            }
            catch (Exception ex)//captamos la excepcion en el caso de que el codigo entre el bloque try haya lanzado una interrupcion
            {
                return msge+"-"+ ex.Message + ex.StackTrace;//mensaje en el caso de que falle el envio esto deveria registrarse en log
            }



        }
    }
}
