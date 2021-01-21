using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Deneme
{
    public partial class AdminGirisForm : Form
    {
        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");

        public AdminGirisForm()
        {
            InitializeComponent();
        }

        private void AdminSifreL_Click(object sender, EventArgs e)
        {

        }

        private void AdminGeriB_Click(object sender, EventArgs e)
        {
            Close();
            var t = new Giris();
            t.Visible = true;

        }

        private void AdminSifreTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                AdminSifreTB.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else
            {
                AdminSifreTB.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }

        private void AdminGirisB_Click(object sender, EventArgs e)
        {
            using (OracleCommand cmd = con.CreateCommand())
            {

                try
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM admin WHERE AdminKullanici=:AdminKullanici AND AdminSifre=:AdminSifre";
                    cmd.Parameters.Add(new OracleParameter("AdminKullanici", textBox2.Text));
                    cmd.Parameters.Add(new OracleParameter("AdminSifre", AdminSifreTB.Text));

                    OracleDataReader reader2 = cmd.ExecuteReader();

                    if (reader2.Read())
                    {

                        Close();
                        var c = new FrmAdminMenu();
                        c.Visible = true;


                    }
                    else
                    {
                        MessageBox.Show("Hatalı şifre veya kullanici adi girildi!");
                        textBox2.Clear();
                        AdminSifreTB.Clear();
                        textBox2.Focus();
                    }

                    reader2.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                con.Close();
            }
        }

        private void AdmGirisL_Click(object sender, EventArgs e)
        {

        }
    }
}
