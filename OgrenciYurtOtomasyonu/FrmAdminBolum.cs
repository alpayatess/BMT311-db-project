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
    public partial class Bolumler : Form
    {
        public Bolumler()
        {
            InitializeComponent();
            BolumGetir();
        }


        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");

        public void BolumGetir() {
            OracleCommand cmd3 = con.CreateCommand();
            try
            {
                con.Open();
                cmd3.CommandText = "SELECT BolumId,BolumAd FROM YBOLUMLER";
                cmd3.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd3);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            catch(Exception e)
            {
                MessageBox.Show("Beklenmeyen Hata Oluştu, bölüm listesi yüklenemiyor");
                Console.WriteLine(e);

            }
            con.Close();

        }

    
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        int secilen;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            textBox1.Text = id;
            textBox2.Text = bolumad;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            BolumGetir();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd4 = con.CreateCommand();

            con.Open();
            cmd4.CommandText = ("DELETE FROM ybolumler WHERE BolumId=:BolumId");

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {
                OracleCommand cmd5 = con.CreateCommand();

                con.Open();
                cmd5.CommandText = ("INSERT INTO ybolumler (BolumAd) values (:BolumAd)");

                cmd5.Parameters.Add(new OracleParameter("BolumAd", textBox2.Text));

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
                MessageBox.Show("Bolum adı girmediniz!");

        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OracleCommand cmd6 = con.CreateCommand();

            con.Open();
            cmd6.CommandText = ("UPDATE ybolumler SET BolumAd=:BolumAd where BolumId=:BolumId");

            cmd6.Parameters.Add(new OracleParameter("BolumAd", textBox2.Text));
            cmd6.Parameters.Add(new OracleParameter("BolumId", textBox1.Text));

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            var t = new FrmAdminMenu();
            t.Visible = true;
        }
    }
}

