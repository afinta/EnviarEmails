using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace EmailSATE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPlantilla.SelectedItem)
            {
                case "Equipaje Perdido":
                    //MessageBox.Show("equipaje perdido");
                    tbDestinatarios.Text = "afinta@mailbox.org";
                    tbAsunto.Text = "Perdio";

                    tbMensaje.Text = "Buenos dias \r\nEsto es un email.";

                    break;

                case "Equipaje Nivel 1000":
                    tbDestinatarios.Text = "email@example.es";
                    tbAsunto.Text = "Nivel 1000";
                    break;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.mailbox.org");

                mail.From = new MailAddress("afinta@mailbox.org");
                mail.To.Add(tbDestinatarios.Text);
                mail.Subject = tbAsunto.Text;
                mail.Body = tbMensaje.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("afinta@mailbox.org", "Password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("mail sent");
                lblConfirmacion.Text = "Enviado";
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
