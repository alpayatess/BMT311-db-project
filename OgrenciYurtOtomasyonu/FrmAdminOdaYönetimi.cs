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
    public partial class FrmAdminOdaYönetimi : Form
    {
        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");
        public FrmAdminOdaYönetimi()
        {
            InitializeComponent();
            OdaGetir();
        }

        public void OdaGetir()
        {
            OracleCommand cmd3 = con.CreateCommand();
            try
            {
                con.Open();
                cmd3.CommandText = "SELECT *FROM YODA";
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
        private void FrmAdminOdaYönetimi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd4 = con.CreateCommand();

            con.Open();
            cmd4.CommandText = ("DELETE FROM yoda WHERE OdaId=:OdaId");

            cmd4.Parameters.Add(new OracleParameter("OdaId", textBox1.Text));

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id, odaad,kapas,dolu;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            odaad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kapas = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dolu = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            textBox1.Text = id;
            textBox2.Text = odaad;
            textBox4.Text = kapas;
            textBox3.Text = dolu;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox3.Text = "0";
                OracleCommand cmd5 = con.CreateCommand();

                con.Open();
                cmd5.CommandText = ("INSERT INTO yoda (Odano,OdaKapasite.OdaDolu) values (:Odano,:Kapas,:Dolu)");

                cmd5.Parameters.Add(new OracleParameter("BolumAd", textBox2.Text));
                cmd5.Parameters.Add(new OracleParameter("Kapas", textBox4.Text));
                cmd5.Parameters.Add(new OracleParameter("Dolu", textBox3.Text));

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OracleCommand cmd6 = con.CreateCommand();

            con.Open();
            cmd6.CommandText = ("UPDATE yoda SET OdaNo=:BolumAd,OdaKapasite=:kapas where OdaId=:OdaId");

            cmd6.Parameters.Add(new OracleParameter("OdaNo", textBox2.Text));
            cmd6.Parameters.Add(new OracleParameter("OdaId", textBox1.Text));
            cmd6.Parameters.Add(new OracleParameter("Kapas", textBox4.Text));

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OdaGetir();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Close();
            var a = new FrmAdminMenu();
            a.Visible = true;
        }
    } 
}
