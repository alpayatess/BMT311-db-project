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
    public partial class FrmOgrListFrm : Form
    {
        
        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");
        public FrmOgrListFrm()
        {
            InitializeComponent();
            OgrGetir();
        }

        public void OgrGetir()
        {
            OracleCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText =@"SELECT OgrId, 
                                            OgrAd, 
                                            OgrSoyad, 
                                            OgrTC, 
                                            OgrTelefon, 
                                            OgrDogum, 
                                            ybolumler.BolumAd, 
                                            yoda.OdaNo, 
                                            OgrVeliAdSoyad, 
                                            OgrVeliTelefon, 
                                            OgrVeliAdres
                                        FROM
                                            yogrenci
                                            LEFT JOIN ybolumler on ybolumler.BolumId = yogrenci.OgrBolumId
                                            LEFT JOIN yoda on yoda.OdaId = yogrenci.OgrOdaId";
                
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            var a = new FrmAdminMenu();
            a.Visible = true;
        }

        int secilen;
        private void dataGridView1_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzen fr = new FrmOgrDuzen();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.bolumad = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.odano = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.vadsoyad = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.vtelefon = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.vadres = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.Show();
        }

        private void FrmOgrListFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
