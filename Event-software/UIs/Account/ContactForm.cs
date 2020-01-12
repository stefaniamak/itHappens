using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace itHappens.UIs.anna
{

    public partial class ContactForm : UserControl
    {

        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();
        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("mail", "password");
        public ContactForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //Smpt Client Details
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = "smtp.gmail.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;

                //credentials for the email the will be sended from
                clientDetails.Credentials = new NetworkCredential("email@gmail.com", "123456789");

                //Message Details
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress("email@gmail.com");

                //the email andress where all the emails will be sended
                mailDetails.To.Add("email@gmail.com");

                //use as subject the name of the sender
                mailDetails.Subject = txtRecipientEmail.Text.Trim();
                mailDetails.Body = rtbBody.Text.Trim();

                clientDetails.Send(mailDetails);
                MessageBox.Show("Thank you we will contact you shortly :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
