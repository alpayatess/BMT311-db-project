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
    public partial class FrmAdminYoklama : Form
    {
        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");
        public FrmAdminYoklama()
        {
            InitializeComponent();
            OdaCek();
        }

        private void FrmAdminYoklama_Load(object sender, EventArgs e)
        {

        }
        public void YoklamaGetir()
        {
            OracleCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = @"SELECT  yoklama.YokTarih,
                                            OgrId, 
                                            OgrAd, 
                                            OgrSoyad, 
                                            OgrTC, 
                                            OgrTelefon, 
                                            yoda.OdaNo, 
                                            OgrVeliAdSoyad, 
                                            OgrVeliTelefon, 
                                            OgrVeliAdres
                                        FROM
                                            yogrenci
                                            LEFT JOIN yoklama on YOKLAMA.YOKOGRID = yogrenci.OgrId
                                            LEFT JOIN yoda on yoda.OdaId = yogrenci.OgrOdaId 
                                            ORDER BY yoklama.yokTarih desc";
                                            

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch
            {
                MessageBox.Show("Hata Bulundu");
            }
            con.Close();

        }

        

        //BUGÜN BUTONU
        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = @"SELECT  yoklama.YokTarih,
                                            OgrId, 
                                            OgrAd, 
                                            OgrSoyad, 
                                            OgrTC, 
                                            OgrTelefon, 
                                            yoda.OdaNo, 
                                            OgrVeliAdSoyad, 
                                            OgrVeliTelefon
                                        FROM
                                            yogrenci
                                            LEFT JOIN yoklama on YOKLAMA.YOKOGRID = yogrenci.OgrId AND YOKLAMA.YOKTARIH =:YOKTARIH
                                            LEFT JOIN yoda on yoda.OdaId = yogrenci.OgrOdaId 
                                            ORDER BY yoklama.yokTarih desc";

                cmd.Parameters.Add(new OracleParameter("YOKTARIH", dateTimePicker1.Value.ToString().Substring(0, 10)));
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch
            {
                MessageBox.Show("Hata Bulundu");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = @"SELECT  yoklama.YokTarih,
                                            OgrId, 
                                            OgrAd, 
                                            OgrSoyad, 
                                            OgrTC, 
                                            OgrTelefon, 
                                            yoda.OdaNo, 
                                            OgrVeliAdSoyad, 
                                            OgrVeliTelefon
                                        FROM
                                            yogrenci
                                            LEFT JOIN yoklama on YOKLAMA.YOKOGRID = yogrenci.OgrId AND YOKLAMA.YOKTARIH =:YOKTARIH
                                            LEFT JOIN yoda on yoda.OdaId = yogrenci.OgrOdaId
                                            WHERE yoda.OdaNo=:odano
                                            ORDER BY yoklama.yokTarih desc";

                cmd.Parameters.Add(new OracleParameter("YOKTARIH", dateTimePicker1.Value.ToString().Substring(0, 10)));
                cmd.Parameters.Add(new OracleParameter("odano", comboBox1.Text));
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch
            {
                MessageBox.Show("Hata Bulundu");
            }
            con.Close();
        }
        public void OdaCek()
        {
            // Odalar icin kullanilan ComboBox
            using (OracleCommand cmd2 = con.CreateCommand())
            {
                try
                {
                    con.Open();
                    cmd2.BindByName = true;
                    cmd2.CommandText = "SELECT OdaNo,OdaId FROM yoda";
                    OracleDataReader reader2 = cmd2.ExecuteReader();
                    comboBox1.DisplayMember = "Text";
                    comboBox1.ValueMember = "Value";
                    while (reader2.Read())
                    {
                        comboBox1.Items.Add(new { Text = reader2.GetString(0), Value = reader2.GetInt64(1) });
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = @"SELECT  yoklama.YokTarih,
                                            OgrId, 
                                            OgrAd, 
                                            OgrSoyad, 
                                            OgrTC, 
                                            OgrTelefon, 
                                            yoda.OdaNo, 
                                            OgrVeliAdSoyad, 
                                            OgrVeliTelefon
                                        FROM
                                            yogrenci
                                            LEFT JOIN yoklama on YOKLAMA.YOKOGRID = yogrenci.OgrId AND YOKLAMA.YOKTARIH =:YOKTARIH
                                            LEFT JOIN yoda on yoda.OdaId = yogrenci.OgrOdaId 
                                            WHERE yogrenci.OgrAd=:AD
                                            ORDER BY yoklama.yokTarih desc";

                cmd.Parameters.Add(new OracleParameter("YOKTARIH", dateTimePicker1.Value.ToString().Substring(0, 10)));
                cmd.Parameters.Add(new OracleParameter("AD", textBox1.Text));
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch
            {
                MessageBox.Show("Hata Bulundu");
            }
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            var a = new FrmAdminMenu();
            a.Visible = true;
        }
    } 
}
