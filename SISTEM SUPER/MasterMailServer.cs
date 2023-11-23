using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail; //biblioteca para mail
using System.Net;
using System.Drawing;
using System.Windows.Forms;

namespace SISTEM_SUPER
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set;}
        protected string password { get; set;}
        protected string host { get; set;}
        protected int port { get; set;}
        protected bool ssl { get; set;}

        //metodo protegido para iniciar el cliente smtp
        protected void inicializarSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password); //este objeto requiere el correo y contraseña
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl; 
        }

        //metodo publico para enviar msj de correo
        public void sendMail(string asunto, string cuerpo, List<string> destinatario) //los datos que se envian y a quien
        {//destinatario del tipo list, para poder tener varios correos y enviar a varios.

            var mailMessage = new MailMessage(); // creamos un msj de correo
            try
            {
                mailMessage.From = new MailAddress(senderMail); //en este caso cargamos el dato de una clase derivada

                foreach (string mail in destinatario)
                {
                    mailMessage.To.Add(mail); // a quien se envia, al ser lista cargamos con el foreach
                }
                mailMessage.Subject = asunto; //asunto del correo
                mailMessage.Body = cuerpo; // el cuerpo del correo
                mailMessage.Priority = MailPriority.Normal; //prioridad del msj normal
                smtpClient.Send(mailMessage); //enviamos el msj

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            finally
            { // en este bloqueo eliminamos los objetos creados para liberar recursos
                mailMessage.Dispose();
                smtpClient.Dispose();


            }
        }

    }
}
