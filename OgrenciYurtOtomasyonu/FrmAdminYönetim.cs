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
    public partial class FrmAdminYönetim : Form
    {
        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");

        public FrmAdminYönetim()
        {
            InitializeComponent();
            AdminGetir();
        }
        public void AdminGetir()
        {
            OracleCommand cmd3 = con.CreateCommand();
            try
            {
                con.Open();
                cmd3.CommandText = "SELECT * FROM Admin";
                cmd3.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd3);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            catch (Exception e)
            {
                MessageBox.Show("Beklenmeyen Hata Oluştu, bölüm listesi yüklenemiyor");
                Console.WriteLine(e);

            }
            con.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                OracleCommand cmd5 = con.CreateCommand();

                con.Open();
                cmd5.CommandText = ("INSERT INTO admin (AdminKullanici,AdminSifre) values (:AdminKullanici,:AdminSifre)");

                cmd5.Parameters.Add(new OracleParameter("AdminKullanici", textBox2.Text));
                cmd5.Parameters.Add(new OracleParameter("AdminSifre", textBox3.Text));


                try
                {


                    cmd5.ExecuteNonQuery();
                    MessageBox.Show("Başarılı");


                }
                catch
                {
                    MessageBox.Show("Hata Bulundu");
                }
                con.Close();
            }
            else
                MessageBox.Show("Bolum adı veya şifre girmediniz!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd4 = con.CreateCommand();

            con.Open();
            cmd4.CommandText = ("DELETE FROM admin WHERE AdminId=:AdminId");

            cmd4.Parameters.Add(new OracleParameter("BolumId", textBox1.Text));

            try
            {


                cmd4.ExecuteNonQuery();
                MessageBox.Show("Başarılı");
                textBox1.Text = "";
                textBox2.Text = "";

            }
            catch
            {
                MessageBox.Show("Hata Bulundu");
            }
            con.Close();
        }
        int secilen; 

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String id, kullaniciad, sifre;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kullaniciad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            textBox1.Text = id;
            textBox2.Text = kullaniciad;
            textBox3.Text = sifre;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            {
                OracleCommand cmd6 = con.CreateCommand();

                con.Open();
                cmd6.CommandText = ("UPDATE admin SET AdminKullanici=:AdminKullanici,AdminSifre=:AdminSifre where AdminId=:AdminId");

                cmd6.Parameters.Add(new OracleParameter("AdminKullanici", textBox2.Text));
                cmd6.Parameters.Add(new OracleParameter("AdminSifre", textBox3.Text));
                cmd6.Parameters.Add(new OracleParameter("AdminId", textBox1.Text));

                try
                {


                    cmd6.ExecuteNonQuery();
                    MessageBox.Show("Başarılı");


                }
                catch
                {
                    MessageBox.Show("Hata Bulundu");
                }
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminGetir();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            var a = new FrmAdminMenu();
            a.Visible = true;
        }
    }
}
