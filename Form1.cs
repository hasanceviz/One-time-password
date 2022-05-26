using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace onetimepassword
{
    public partial class Form1 : Form
    {
        public int Gkod;
        public Form1()
        {
            InitializeComponent();
        }

        private void buton_Giris_Click(object sender, EventArgs e)
        {
            if (text_Mail.Text == "" )
            {
                MessageBox.Show("Mail Boş Olamaz.");
            }
            else {
                Random rnd = new  Random();
                string konu = "Güvenlik Doğrulaması : ";
                int sayi = rnd.Next(1000, 9999);
                Gkod = sayi;
                Gonder(konu, sayi);
            }
        }
        public bool Gonder (string konu, int sayi)
        {
            string icerik = "Güvenlik Doğrulaması :" + sayi;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hasancvzz@outlook.com");
            mail.To.Add(text_Mail.Text);
            mail.Subject = konu;
            mail.Body =icerik;
            SmtpClient sc = new SmtpClient();
            sc.Credentials = new System.Net.NetworkCredential("hasancvzz@outlook.com", "1234056789Aa.");
            sc.Port = 587;
            sc.Host = "smtp.live.com";
            sc.EnableSsl = true;
            object userState = mail;
            bool kontrol = true;
            try
            {
                sc.SendAsync(mail, (object)mail);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        

        private void buton_GirisYap_Click(object sender, EventArgs e)
        {
            if(Gkod == Convert.ToInt32(text_Kod.Text))
            {
                MessageBox.Show("giriş başarılı");
                this.Hide();
                this.Show();
            }
            else
            {
                MessageBox.Show("girilen kod hatalıdır.");
            }


        }
        

        }
    }

