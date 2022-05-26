namespace onetimepassword
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.text_Mail = new DevExpress.XtraEditors.TextEdit();
            this.text_Kod = new DevExpress.XtraEditors.TextEdit();
            this.buton_Kodİste = new DevExpress.XtraEditors.SimpleButton();
            this.buton_GirisYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.text_Mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Kod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(205, 114);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "E-Mail  :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(205, 223);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Güvenlik Kodu  :";
            // 
            // text_Mail
            // 
            this.text_Mail.Location = new System.Drawing.Point(406, 111);
            this.text_Mail.Name = "text_Mail";
            this.text_Mail.Size = new System.Drawing.Size(125, 22);
            this.text_Mail.TabIndex = 3;
            // 
            // text_Kod
            // 
            this.text_Kod.Location = new System.Drawing.Point(406, 217);
            this.text_Kod.Name = "text_Kod";
            this.text_Kod.Size = new System.Drawing.Size(125, 22);
            this.text_Kod.TabIndex = 5;
            // 
            // buton_Kodİste
            // 
            this.buton_Kodİste.Location = new System.Drawing.Point(422, 158);
            this.buton_Kodİste.Name = "buton_Kodİste";
            this.buton_Kodİste.Size = new System.Drawing.Size(94, 29);
            this.buton_Kodİste.TabIndex = 6;
            this.buton_Kodİste.Text = "Kod İste";
            this.buton_Kodİste.Click += new System.EventHandler(this.buton_Giris_Click);
            // 
            // buton_GirisYap
            // 
            this.buton_GirisYap.Location = new System.Drawing.Point(422, 263);
            this.buton_GirisYap.Name = "buton_GirisYap";
            this.buton_GirisYap.Size = new System.Drawing.Size(94, 29);
            this.buton_GirisYap.TabIndex = 7;
            this.buton_GirisYap.Text = "Giriş Yap";
            this.buton_GirisYap.Click += new System.EventHandler(this.buton_GirisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buton_GirisYap);
            this.Controls.Add(this.buton_Kodİste);
            this.Controls.Add(this.text_Kod);
            this.Controls.Add(this.text_Mail);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.text_Mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Kod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit text_Mail;
        private DevExpress.XtraEditors.TextEdit text_Kod;
        private DevExpress.XtraEditors.SimpleButton buton_Kodİste;
        private DevExpress.XtraEditors.SimpleButton buton_GirisYap;
    }
}

