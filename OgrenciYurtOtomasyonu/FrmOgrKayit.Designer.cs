namespace Deneme
{
    partial class FrmOgrKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.OgrAdTB = new System.Windows.Forms.TextBox();
            this.OgrSoyadTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OgrTCTB = new System.Windows.Forms.MaskedTextBox();
            this.OgrTelTB = new System.Windows.Forms.MaskedTextBox();
            this.OgrDogumTB = new System.Windows.Forms.MaskedTextBox();
            this.OgrBolumTB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OgrOdaNoTB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OgrVeliadTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OgrVeliTelTB = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OgrAdresTB = new System.Windows.Forms.RichTextBox();
            this.KayitBT = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.OgrPassTB = new System.Windows.Forms.TextBox();
            this.KayitGeriB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OgrAdTB
            // 
            this.OgrAdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrAdTB.Location = new System.Drawing.Point(203, 11);
            this.OgrAdTB.Name = "OgrAdTB";
            this.OgrAdTB.Size = new System.Drawing.Size(203, 30);
            this.OgrAdTB.TabIndex = 2;
            this.OgrAdTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OgrSoyadTB
            // 
            this.OgrSoyadTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSoyadTB.Location = new System.Drawing.Point(203, 47);
            this.OgrSoyadTB.Name = "OgrSoyadTB";
            this.OgrSoyadTB.Size = new System.Drawing.Size(203, 30);
            this.OgrSoyadTB.TabIndex = 3;
            this.OgrSoyadTB.TextChanged += new System.EventHandler(this.OgrSoyadTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğrenci Soyad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(159, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Öğrenci Telefon:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Öğr. Doğum Tarihi:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // OgrTCTB
            // 
            this.OgrTCTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrTCTB.Location = new System.Drawing.Point(203, 84);
            this.OgrTCTB.Mask = "00000000000";
            this.OgrTCTB.Name = "OgrTCTB";
            this.OgrTCTB.Size = new System.Drawing.Size(203, 30);
            this.OgrTCTB.TabIndex = 13;
            this.OgrTCTB.ValidatingType = typeof(int);
            this.OgrTCTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.OgrTCTB_MaskInputRejected);
            // 
            // OgrTelTB
            // 
            this.OgrTelTB.Culture = new System.Globalization.CultureInfo("aa-DJ");
            this.OgrTelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrTelTB.Location = new System.Drawing.Point(203, 120);
            this.OgrTelTB.Mask = "(999) 000-0000";
            this.OgrTelTB.Name = "OgrTelTB";
            this.OgrTelTB.Size = new System.Drawing.Size(203, 30);
            this.OgrTelTB.TabIndex = 14;
            this.OgrTelTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.OgrTelTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.OgrTelTB_MaskInputRejected);
            // 
            // OgrDogumTB
            // 
            this.OgrDogumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrDogumTB.Location = new System.Drawing.Point(203, 156);
            this.OgrDogumTB.Mask = "00/00/0000";
            this.OgrDogumTB.Name = "OgrDogumTB";
            this.OgrDogumTB.Size = new System.Drawing.Size(203, 30);
            this.OgrDogumTB.TabIndex = 15;
            this.OgrDogumTB.ValidatingType = typeof(System.DateTime);
            this.OgrDogumTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.OgrDogumTB_MaskInputRejected);
            // 
            // OgrBolumTB
            // 
            this.OgrBolumTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OgrBolumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrBolumTB.FormattingEnabled = true;
            this.OgrBolumTB.ItemHeight = 25;
            this.OgrBolumTB.Location = new System.Drawing.Point(203, 192);
            this.OgrBolumTB.Name = "OgrBolumTB";
            this.OgrBolumTB.Size = new System.Drawing.Size(203, 33);
            this.OgrBolumTB.TabIndex = 16;
            this.OgrBolumTB.SelectedIndexChanged += new System.EventHandler(this.OgrBolumTB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Öğrencinin Bölümü:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // OgrOdaNoTB
            // 
            this.OgrOdaNoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrOdaNoTB.FormattingEnabled = true;
            this.OgrOdaNoTB.Location = new System.Drawing.Point(203, 231);
            this.OgrOdaNoTB.Name = "OgrOdaNoTB";
            this.OgrOdaNoTB.Size = new System.Drawing.Size(203, 33);
            this.OgrOdaNoTB.TabIndex = 18;
            this.OgrOdaNoTB.SelectedIndexChanged += new System.EventHandler(this.OgrOdaNoTB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(67, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Oda Numarası:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // OgrVeliadTB
            // 
            this.OgrVeliadTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrVeliadTB.Location = new System.Drawing.Point(620, 23);
            this.OgrVeliadTB.Name = "OgrVeliadTB";
            this.OgrVeliadTB.Size = new System.Drawing.Size(203, 30);
            this.OgrVeliadTB.TabIndex = 21;
            this.OgrVeliadTB.TextChanged += new System.EventHandler(this.OgrVeliadTB_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(476, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Veli Ad Soyad:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // OgrVeliTelTB
            // 
            this.OgrVeliTelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrVeliTelTB.Location = new System.Drawing.Point(620, 73);
            this.OgrVeliTelTB.Mask = "(999) 000-0000";
            this.OgrVeliTelTB.Name = "OgrVeliTelTB";
            this.OgrVeliTelTB.Size = new System.Drawing.Size(203, 30);
            this.OgrVeliTelTB.TabIndex = 23;
            this.OgrVeliTelTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.OgrVeliTelTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.OgrVeliTelTB_MaskInputRejected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(493, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Veli Telefon:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(542, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Adres:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // OgrAdresTB
            // 
            this.OgrAdresTB.Location = new System.Drawing.Point(620, 127);
            this.OgrAdresTB.Name = "OgrAdresTB";
            this.OgrAdresTB.Size = new System.Drawing.Size(203, 101);
            this.OgrAdresTB.TabIndex = 25;
            this.OgrAdresTB.Text = "";
            this.OgrAdresTB.TextChanged += new System.EventHandler(this.OgrAdresTB_TextChanged);
            // 
            // KayitBT
            // 
            this.KayitBT.Location = new System.Drawing.Point(639, 272);
            this.KayitBT.Name = "KayitBT";
            this.KayitBT.Size = new System.Drawing.Size(158, 52);
            this.KayitBT.TabIndex = 26;
            this.KayitBT.Text = "Kaydet";
            this.KayitBT.UseVisualStyleBackColor = true;
            this.KayitBT.Click += new System.EventHandler(this.KayitBT_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(129, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 22);
            this.label11.TabIndex = 27;
            this.label11.Text = "Şifre";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // OgrPassTB
            // 
            this.OgrPassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrPassTB.Location = new System.Drawing.Point(203, 294);
            this.OgrPassTB.Name = "OgrPassTB";
            this.OgrPassTB.Size = new System.Drawing.Size(203, 30);
            this.OgrPassTB.TabIndex = 28;
            this.OgrPassTB.TextChanged += new System.EventHandler(this.OgrPassTB_TextChanged);
            // 
            // KayitGeriB
            // 
            this.KayitGeriB.Location = new System.Drawing.Point(791, 406);
            this.KayitGeriB.Name = "KayitGeriB";
            this.KayitGeriB.Size = new System.Drawing.Size(75, 23);
            this.KayitGeriB.TabIndex = 29;
            this.KayitGeriB.Text = "Geri";
            this.KayitGeriB.UseVisualStyleBackColor = true;
            this.KayitGeriB.Click += new System.EventHandler(this.KayitGeriB_Click);
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 441);
            this.Controls.Add(this.KayitGeriB);
            this.Controls.Add(this.OgrPassTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.KayitBT);
            this.Controls.Add(this.OgrAdresTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OgrVeliTelTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OgrVeliadTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OgrOdaNoTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OgrBolumTB);
            this.Controls.Add(this.OgrDogumTB);
            this.Controls.Add(this.OgrTelTB);
            this.Controls.Add(this.OgrTCTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OgrSoyadTB);
            this.Controls.Add(this.OgrAdTB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrKayit";
            this.Text = "Yurt Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OgrAdTB;
        private System.Windows.Forms.TextBox OgrSoyadTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox OgrTCTB;
        private System.Windows.Forms.MaskedTextBox OgrTelTB;
        private System.Windows.Forms.MaskedTextBox OgrDogumTB;
        private System.Windows.Forms.ComboBox OgrBolumTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox OgrOdaNoTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OgrVeliadTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox OgrVeliTelTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox OgrAdresTB;
        private System.Windows.Forms.Button KayitBT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OgrPassTB;
        private System.Windows.Forms.Button KayitGeriB;
    }
}

