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
    public partial class FrmOgrKayit : Form
    {
        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");
        

        public FrmOgrKayit()
        {

            InitializeComponent();
            BolumCek();
            OdaCek();
        }

        public void BolumCek()
        {
            // Bolumler icin kullanilan ComboBox
            using (OracleCommand cmd1 = con.CreateCommand())
            {

                try
                {
                    con.Open();
                    cmd1.BindByName = true;
                    cmd1.CommandText = "SELECT BolumAd, BolumId FROM YBOLUMLER";
                    OracleDataReader reader = cmd1.ExecuteReader();
                    OgrBolumTB.DisplayMember = "Text";
                    OgrBolumTB.ValueMember = "Value";
                    while (reader.Read())
                    {
                        OgrBolumTB.Items.Add(new { Text = reader.GetString(0), Value = reader.GetInt64(1) });
                    }
                    reader.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                con.Close();
            }
        }

        public void OdaCek()
        {
            // Odalar icin kullanilan ComboBox
            using (OracleCommand cmd2 = con.CreateCommand())
            {  try
                {
                    con.Open();
                    cmd2.BindByName = true;
                    cmd2.CommandText = "SELECT OdaNo,OdaId FROM yoda WHERE OdaKapasite>OdaDolu";
                    OracleDataReader reader2 = cmd2.ExecuteReader();
                    OgrOdaNoTB.DisplayMember = "Text";
                    OgrOdaNoTB.ValueMember = "Value";
                    while (reader2.Read())
                    {
                        OgrOdaNoTB.Items.Add(new { Text = reader2.GetString(0), Value = reader2.GetInt64(1) });
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OgrBolumTB_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void odaDoldur()
        {
            
            OracleCommand comkayit1 = con.CreateCommand();
            comkayit1.CommandText = ("UPDATE YODA SET odadolu = odadolu + 1 WHERE odano =:odano");
            comkayit1.Parameters.Add(new OracleParameter("odano", OgrOdaNoTB.Text));
            try
            {
                comkayit1.ExecuteNonQuery();
                MessageBox.Show("odadolulugu arttırıldı!");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void KayitBT_Click(object sender, EventArgs e)
        {
            con.Open();
            
            Int64 SelectedBolumId = (OgrBolumTB.SelectedItem as dynamic).Value;
            Int64 SelectedOdaId = (OgrOdaNoTB.SelectedItem as dynamic).Value;
            OracleCommand comkayit = con.CreateCommand();
            

            comkayit.CommandText = ("INSERT INTO YOGRENCI (OGRAD, OGRSOYAD, OGRTC, OGRTELEFON, OGRDOGUM, OgrBolumId, OgrOdaId, OGRPASS, OGRVELIADSOYAD, OGRVELITELEFON, OgrVeliAdres)" +
               " VALUES (:OGRAD, :OGRSOYAD, :OGRTC, :OGRTELEFON, :OgrBolumId, :OGRDOGUM, :OgrOdaId,:OGRPASS, :OGRVELIADSOYAD, :OGRVELITELEFON, :OgrVeliAdres) ");


            comkayit.Parameters.Add(new OracleParameter("OGRAD", OgrAdTB.Text));
            comkayit.Parameters.Add(new OracleParameter("OGRSOYAD", OgrSoyadTB.Text));
            comkayit.Parameters.Add(new OracleParameter("OGRTC", OgrTCTB.Text));
            comkayit.Parameters.Add(new OracleParameter("OGRTELEFON", OgrTelTB.Text));
            comkayit.Parameters.Add(new OracleParameter("OGRDOGUM", OgrDogumTB.Text));
            comkayit.Parameters.Add(new OracleParameter("OgrBolumId", SelectedBolumId));
            comkayit.Parameters.Add(new OracleParameter("OgrOdaId", SelectedOdaId));
            comkayit.Parameters.Add(new OracleParameter("OGRPASS", OgrPassTB.Text));
            comkayit.Parameters.Add(new OracleParameter("OGRVELIADSOYAD", OgrVeliadTB.Text));
            comkayit.Parameters.Add(new OracleParameter("OGRVELITELEFON", OgrVeliTelTB.Text));
            comkayit.Parameters.Add(new OracleParameter("OgrVeliAdres", OgrAdresTB.Text));


            try
            {
                comkayit.ExecuteNonQuery();
                odaDoldur();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            MessageBox.Show("Kayit basarili!");
            

            con.Close();
            Close();

            var b = new Giris();
            b.Visible = true;
            

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void KayitGeriB_Click(object sender, EventArgs e)
        {
            Close();
            var x = new Giris();
            x.Visible = true;

        }

        private void OgrAdresTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void OgrVeliTelTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void OgrVeliadTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void OgrOdaNoTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void OgrDogumTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void OgrTelTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void OgrTCTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OgrSoyadTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void OgrPassTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {

        }

       
    }
}
