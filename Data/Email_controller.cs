using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using ToDo_List.Data.Repository;


namespace ToDo_List.Data
{
    public class Email_controller
    {
        public bool Send_email(string receiver, int ToDoItemId ) {

            MailMessage mail = new MailMessage();
           SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

             mail.From = new MailAddress("andr.sosn@gmail.com");
             mail.To.Add(receiver);
            mail.Subject = "ToDoList: Need to do";
            mail.Body = "You have a new affair! "  + ToDoItemId ;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("andr.sosn@gmail.com", "dp07111946");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            return true;
        }
    }
}
