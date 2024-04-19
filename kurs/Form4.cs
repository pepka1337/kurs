using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       private void SendMessage() 
        {
            string smtpServer = "smtp.mail.ru";
            int smptPort = 587;
            string smtpUsername = "fuagra.a@mail.ru";
            string smtpPassword = "ChdpPCG0ke6BgqJsrEsW";

            using(SmtpClient smtpClient = new SmtpClient(smtpServer, smptPort)) 
            {
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword); 
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage()) 
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add(mail.Text);
                    mailMessage.Subject = "Вы купили билет";
                    mailMessage.Body = $"Вы заполнили форму в приложении и купили билет в {kuda.Text} \r\n Отправление из {otkuda.Text}, дата: {data.Text}. Приятного полета! ";

                    try
                    {
                        smtpClient.Send(mailMessage);
                        Console.WriteLine("Вы успешно купили билет, он был отправлен на вашу почту");
                        MessageBox.Show("Вы успешно купили билет, он был отправлен на вашу почту");

                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine($"Ошибка отправки{ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
    }
}
