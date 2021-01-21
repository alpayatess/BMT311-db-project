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
    
    public partial class FrmOgrDuzen : Form
    {

        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");
        FrmOgrKayit nes = new FrmOgrKayit();
        public FrmOgrDuzen()
        {
            InitializeComponent();

            // Odalar icin kullanilan ComboBox
            using (OracleCommand cmd2 = con.CreateCommand())
            {

                try
                {
                    con.Open();
                    cmd2.BindByName = true;


                    cmd2.CommandText = "SELECT OdaNo,OdaId FROM yoda WHERE OdaKapasite!=OdaDolu";


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
        public string id, ad, soyad, tc, telefon, dogum, bolumad, odano, vadsoyad, vtelefon, vadres;

        private void KayitBT_Click(object sender, EventArgs e)
        {
            con.Open();

            Int64 SelectedBolumId = (OgrBolumTB.SelectedItem as dynamic).Value;
            Int64 SelectedOdaId = (OgrOdaNoTB.SelectedItem as dynamic).Value;
            OracleCommand comguncelle = con.CreateCommand();


            comguncelle.CommandText = (@"UPDATE 
                                            yogrenci 
                                        SET 
                                            OGRAD=:OGRAD, 
                                            OGRSOYAD=:OGRSOYAD,
                                            OGRTC=:OGRTC, 
                                            OGRTELEFON=:OGRTELEFON, 
                                            OGRDOGUM=:OGRDOGUM, 
                                            OgrBolumId=:OgrBolumId, 
                                            OgrOdaId=:OgrOdaId, 
                                            OGRPASS=:OGRPASS, 
                                            OGRVELIADSOYAD=:OGRVELIADSOYAD,
                                            OGRVELITELEFON=:OGRVELITELEFON, 
                                            OgrVeliAdres=:OgrVeliAdres 
                                        WHERE 
                                            OgrId=:OgrId");
            


            comguncelle.Parameters.Add(new OracleParameter("OGRAD", OgrAdTB.Text));
            comguncelle.Parameters.Add(new OracleParameter("OGRSOYAD", OgrSoyadTB.Text));
            comguncelle.Parameters.Add(new OracleParameter("OGRTC", OgrTCTB.Text));
            comguncelle.Parameters.Add(new OracleParameter("OGRTELEFON", OgrTelTB.Text));
            comguncelle.Parameters.Add(new OracleParameter("OGRDOGUM", OgrDogumTB.Text));
            comguncelle.Parameters.Add(new OracleParameter("OgrBolumId", SelectedBolumId));
            comguncelle.Parameters.Add(new OracleParameter("OgrOdaId", SelectedOdaId));
            comguncelle.Parameters.Add(new OracleParameter("OGRPASS", OgrPassTB.Text));
            comguncelle.Parameters.Add(new OracleParameter("OGRVELIADSOYAD", OgrVeliadTB.Text));
            comguncelle.Parameters.Add(new OracleParameter("OGRVELITELEFON", OgrVeliTelTB.Text));
            comguncelle.Parameters.Add(new OracleParameter("OgrVeliAdres", OgrAdresTB.Text));
            comguncelle.Parameters.Add(new OracleParameter("OgrId", textBox1.Text));


            try
            {
                comguncelle.ExecuteNonQuery();
                MessageBox.Show("Guncelleme basarili!");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            con.Close();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            var c = new FrmOgrListFrm();
            c.Visible = true;
        }

        

        private void FrmOgrDuzen_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = id;
            OgrAdTB.Text = ad;
            OgrSoyadTB.Text = soyad;
            OgrTCTB.Text = tc;
            OgrTelTB.Text = telefon;
            OgrDogumTB.Text = dogum;
            OgrBolumTB.Text = bolumad;
            OgrOdaNoTB.Text = odano;
            OgrVeliadTB.Text = vadsoyad;
            OgrVeliTelTB.Text = vtelefon;
            OgrAdresTB.Text = vadres;
        }
    }
}
