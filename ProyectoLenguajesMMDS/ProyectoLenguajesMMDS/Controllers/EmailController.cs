using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ProyectoLenguajesMMDS.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public int  SendEmail(string receiver, Person person, string message , string subject)
        {


            if (subject == "Aceptado")
            {
                message= "Su solicitud de ingreso al sistema CIIE (Centralización de Información de Informática Empresarial) ha sido aprobada.";
            }
            else
            {
                message = "Su solicitud de ingreso al sistema CIIE (Centralización de Información de Informática Empresarial) ha sido rechazada." +
                    "\n\n" + "Motivo: \n" + message;
            }

            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress(person.Email,person.Name);
                    var receiverEmail = new MailAddress(receiver, "Receiver");
                    var password = person.Password;
                    var sub = subject;
                    var body = message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return 0;
        }
    }
}