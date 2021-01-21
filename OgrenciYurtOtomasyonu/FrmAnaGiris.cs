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
    public partial class Giris : Form
    {

        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");
        public Giris()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void kayitolBT_Click(object sender, EventArgs e)
        {
            Close();
            var f = new FrmOgrKayit();
            f.Visible = true;
            
        }

        private void admingBT_Click(object sender, EventArgs e)
        {
            Close();
            var a = new AdminGirisForm();
            a.Visible = true;

        }

        private void GirisSifreTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                GirisSifreTB.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else
            {
                GirisSifreTB.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
                

        }

        private void girisBT_Click(object sender, EventArgs e)
        {
            using (OracleCommand cmd = con.CreateCommand())
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "SELECT OgrTC,OgrId,OgrAd,OgrOdaId FROM yogrenci WHERE OgrTC=:OgrTC AND OgrPass=:OgrPass";
                    cmd.Parameters.Add(new OracleParameter("OGRTC", maskedTextBox1.Text));
                    cmd.Parameters.Add(new OracleParameter("OGRPASS", GirisSifreTB.Text));
                    OracleDataReader reader2 = cmd.ExecuteReader();

                    if (reader2.Read())
                    {
                        OgrBilgi info = new OgrBilgi();
                        info.ID = reader2.GetInt64(1);
                        info.Isim = reader2.GetString(2);
                        info.TC = reader2.GetString(0);
                        info.OdaID = reader2.GetInt64(3);
                        var c = new FrmKullaniciMenu(info);
                        c.Visible = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı şifre veya TC numarası girdiniz!");
                        maskedTextBox1.Clear();
                        GirisSifreTB.Clear();
                        maskedTextBox1.Focus();
                    }  reader2.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                con.Close();
            }
        }
    }
}
