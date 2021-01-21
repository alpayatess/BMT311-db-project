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
    public partial class FrmKullaniciYoklama : Form
    {
        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");
        private OgrBilgi info;
        public FrmKullaniciYoklama(OgrBilgi info)
        {
            this.info = info;

            InitializeComponent();
            yoklamaYukle();
            label1.Text = "Hos Geldin " + info.Isim;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.Value.ToShortDateString();


        }

        private void yoklamaYukle()
        {
            OracleCommand cmd3 = con.CreateCommand();
            try
            {
                con.Open();
                cmd3.CommandText = "SELECT YokTarih FROM YOKLAMA where YokOgrId =:OgrID ORDER BY YokTarih DESC";
                cmd3.Parameters.Add(new OracleParameter("OgrID", info.ID));
                cmd3.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd3);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            catch (Exception e)
            {
                MessageBox.Show("Beklenmeyen Hata Oluştu, Yoklama listesi yüklenemiyor");
                Console.WriteLine(e);

            }
            con.Close();

        }

        private void yoklamaKaydet()
        {
            OracleCommand cmd3 = con.CreateCommand();
            try
            {
                con.Open();
                cmd3.CommandText = "INSERT INTO yoklama (YokTarih,YokOgrID) VALUES (:YokTarih, :OgrID)";
                cmd3.Parameters.Add(new OracleParameter("YOKTARIH", dateTimePicker1.Value.ToString().Substring(0, 10)));
                cmd3.Parameters.Add(new OracleParameter("OgrID", info.ID));
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Yoklama için adınız listeye alındı!");


            }
            catch (Exception e)
            {
                MessageBox.Show("Beklenmeyen Hata Oluştu, Yoklama listesi yüklenemiyor");
                Console.WriteLine(e);

            }
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yoklamaKaydet();
            yoklamaYukle();
            button1.Visible = false;
            label2.Visible = true;

        }

        private void FrmKullaniciYoklama_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[0].Value != null)
            {

                if (dateTimePicker1.Value.ToString().StartsWith(dataGridView1.Rows[0].Cells[0].Value.ToString().Substring(0, 6)))
                {
                    button1.Visible = false;
                    label2.Visible = true;
                }  
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            var a = new FrmKullaniciMenu(info);
            a.Visible = true;
        }
    }
}
