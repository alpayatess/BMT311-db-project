namespace Deneme
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisSifreTB = new System.Windows.Forms.TextBox();
            this.girisBT = new System.Windows.Forms.Button();
            this.kayitolBT = new System.Windows.Forms.Button();
            this.admingBT = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GirisSifreTB
            // 
            this.GirisSifreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisSifreTB.Location = new System.Drawing.Point(160, 117);
            this.GirisSifreTB.Name = "GirisSifreTB";
            this.GirisSifreTB.Size = new System.Drawing.Size(133, 30);
            this.GirisSifreTB.TabIndex = 3;
            this.GirisSifreTB.UseSystemPasswordChar = true;
            this.GirisSifreTB.TextChanged += new System.EventHandler(this.GirisSifreTB_TextChanged);
            // 
            // girisBT
            // 
            this.girisBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBT.Location = new System.Drawing.Point(169, 175);
            this.girisBT.Name = "girisBT";
            this.girisBT.Size = new System.Drawing.Size(97, 43);
            this.girisBT.TabIndex = 4;
            this.girisBT.Text = "Giris";
            this.girisBT.UseVisualStyleBackColor = true;
            this.girisBT.Click += new System.EventHandler(this.girisBT_Click);
            // 
            // kayitolBT
            // 
            this.kayitolBT.Location = new System.Drawing.Point(69, 253);
            this.kayitolBT.Name = "kayitolBT";
            this.kayitolBT.Size = new System.Drawing.Size(75, 23);
            this.kayitolBT.TabIndex = 5;
            this.kayitolBT.Text = "Kayit ol";
            this.kayitolBT.UseVisualStyleBackColor = true;
            this.kayitolBT.Click += new System.EventHandler(this.kayitolBT_Click);
            // 
            // admingBT
            // 
            this.admingBT.Location = new System.Drawing.Point(265, 253);
            this.admingBT.Name = "admingBT";
            this.admingBT.Size = new System.Drawing.Size(75, 23);
            this.admingBT.TabIndex = 6;
            this.admingBT.Text = "Admin Girisi";
            this.admingBT.UseVisualStyleBackColor = true;
            this.admingBT.Click += new System.EventHandler(this.admingBT_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(160, 61);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(133, 30);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(299, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 288);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.admingBT);
            this.Controls.Add(this.kayitolBT);
            this.Controls.Add(this.girisBT);
            this.Controls.Add(this.GirisSifreTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GirisSifreTB;
        private System.Windows.Forms.Button girisBT;
        private System.Windows.Forms.Button kayitolBT;
        private System.Windows.Forms.Button admingBT;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}