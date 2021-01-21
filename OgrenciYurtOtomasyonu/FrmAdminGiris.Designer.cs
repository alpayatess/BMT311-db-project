namespace Deneme
{
    partial class AdminGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGirisForm));
            this.AdmGirisL = new System.Windows.Forms.Label();
            this.AdminSifreL = new System.Windows.Forms.Label();
            this.AdminSifreTB = new System.Windows.Forms.TextBox();
            this.AdminGirisB = new System.Windows.Forms.Button();
            this.AdminGeriB = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AdmGirisL
            // 
            this.AdmGirisL.AutoSize = true;
            this.AdmGirisL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdmGirisL.Location = new System.Drawing.Point(40, 73);
            this.AdmGirisL.Name = "AdmGirisL";
            this.AdmGirisL.Size = new System.Drawing.Size(119, 25);
            this.AdmGirisL.TabIndex = 0;
            this.AdmGirisL.Text = "Kullanıcı Adı";
            this.AdmGirisL.Click += new System.EventHandler(this.AdmGirisL_Click);
            // 
            // AdminSifreL
            // 
            this.AdminSifreL.AutoSize = true;
            this.AdminSifreL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminSifreL.Location = new System.Drawing.Point(40, 140);
            this.AdminSifreL.Name = "AdminSifreL";
            this.AdminSifreL.Size = new System.Drawing.Size(52, 25);
            this.AdminSifreL.TabIndex = 1;
            this.AdminSifreL.Text = "Sifre";
            this.AdminSifreL.Click += new System.EventHandler(this.AdminSifreL_Click);
            // 
            // AdminSifreTB
            // 
            this.AdminSifreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminSifreTB.Location = new System.Drawing.Point(171, 135);
            this.AdminSifreTB.Name = "AdminSifreTB";
            this.AdminSifreTB.Size = new System.Drawing.Size(201, 30);
            this.AdminSifreTB.TabIndex = 3;
            this.AdminSifreTB.UseSystemPasswordChar = true;
            this.AdminSifreTB.TextChanged += new System.EventHandler(this.AdminSifreTB_TextChanged);
            // 
            // AdminGirisB
            // 
            this.AdminGirisB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminGirisB.Location = new System.Drawing.Point(187, 193);
            this.AdminGirisB.Name = "AdminGirisB";
            this.AdminGirisB.Size = new System.Drawing.Size(131, 42);
            this.AdminGirisB.TabIndex = 4;
            this.AdminGirisB.Text = "Giris";
            this.AdminGirisB.UseVisualStyleBackColor = true;
            this.AdminGirisB.Click += new System.EventHandler(this.AdminGirisB_Click);
            // 
            // AdminGeriB
            // 
            this.AdminGeriB.Location = new System.Drawing.Point(366, 253);
            this.AdminGeriB.Name = "AdminGeriB";
            this.AdminGeriB.Size = new System.Drawing.Size(75, 23);
            this.AdminGeriB.TabIndex = 5;
            this.AdminGeriB.Text = "Geri";
            this.AdminGeriB.UseVisualStyleBackColor = true;
            this.AdminGeriB.Click += new System.EventHandler(this.AdminGeriB_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(378, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(171, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 30);
            this.textBox2.TabIndex = 9;
            // 
            // AdminGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 288);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AdminGeriB);
            this.Controls.Add(this.AdminGirisB);
            this.Controls.Add(this.AdminSifreTB);
            this.Controls.Add(this.AdminSifreL);
            this.Controls.Add(this.AdmGirisL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminGirisForm";
            this.Text = "Admin Girisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdmGirisL;
        private System.Windows.Forms.Label AdminSifreL;
        private System.Windows.Forms.TextBox AdminSifreTB;
        private System.Windows.Forms.Button AdminGirisB;
        private System.Windows.Forms.Button AdminGeriB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}