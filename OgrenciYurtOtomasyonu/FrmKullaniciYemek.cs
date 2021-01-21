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
    public partial class FrmKullaniciYemek : Form
    {
        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521; ");
        private OgrBilgi info;
        public FrmKullaniciYemek(OgrBilgi info)
        {
            this.info = info;
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void YemekYazdir()
        {
            OracleCommand cmd3 = con.CreateCommand();
            try
            {
                con.Open();
                cmd3.CommandText = "SELECT TAR,CORBA,ANAYEMEK,TATLI FROM yyemek ORDER BY tar ASC";
                cmd3.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd3);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;



            }
            catch (Exception e)
            {
                MessageBox.Show("Yemekler listelenemedi");
                Console.WriteLine(e);

            }
            con.Close();

        }

        private void FrmKullaniciYemek_Load(object sender, EventArgs e)
        {
            YemekYazdir();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Close();
            var a = new FrmKullaniciMenu(info);
            a.Visible = true;
        }
    }
}
