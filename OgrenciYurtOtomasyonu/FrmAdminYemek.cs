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
    
    public partial class FrmAdminYemek : Form
    {
        OracleConnection con = new OracleConnection("User Id=SYSTEM;Password=1999; Data Source=localhost:1521;");
        
        public FrmAdminYemek()
        {
            InitializeComponent();
            con.Open();
        }
        
        int secilen;

        private OracleCommand yemekKomutHazırla(String islem)
        {
            
            OracleCommand command = new OracleCommand("YemekEkleme", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("x1", OracleDbType.NVarchar2).Value = textBox1.Text;
            command.Parameters.Add("x2", OracleDbType.NVarchar2).Value = maskedTextBox2.Text;
            command.Parameters.Add("x3", OracleDbType.NVarchar2).Value = textBox3.Text;
            command.Parameters.Add("x4", OracleDbType.NVarchar2).Value = textBox4.Text;
            command.Parameters.Add("x5", OracleDbType.NVarchar2).Value = textBox5.Text;
            command.Parameters.Add("x6", OracleDbType.NVarchar2).Value = islem;
            command.Parameters.Add("f1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            return command;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id,tarih, corba, anayemek, tatli;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tarih = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            corba = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            anayemek = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tatli = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            textBox1.Text = id;
            maskedTextBox2.Text = tarih;
            textBox3.Text = corba;
            textBox4.Text = anayemek;
            textBox5.Text = tatli;
        }

        public void yemekSilme()
        {
            yemekKomutHazırla("DELETE").ExecuteNonQuery();
        }

        public void yemekUpdate()
        {
            yemekKomutHazırla("UPDATE").ExecuteNonQuery();
        }


        public void yemekSelect()
        { 
            OracleDataAdapter da = new OracleDataAdapter(yemekKomutHazırla("SELECT"));
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
        }
        
        public bool yemekBak()
        {
            OracleDataAdapter ad = new OracleDataAdapter(yemekKomutHazırla("EXIST"));
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int x = dt.Rows.Count;
            
            return x > 0;

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!yemekBak())
            {
                yemekKomutHazırla("INSERT").ExecuteNonQuery();
                yemekSelect();
                MessageBox.Show("Yemek bilgisi eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
                MessageBox.Show("Bir hata oluştu, tekrar deneyiniz!");
        }

        private void FrmAdminYemek_Load(object sender, EventArgs e)
        {

            yemekSelect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yemekSilme();

            MessageBox.Show("Başarılı");
            textBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            yemekSelect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yemekUpdate();
            yemekSelect();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            var t = new FrmAdminMenu();
            t.Visible = true;
        }
    
    }
}

