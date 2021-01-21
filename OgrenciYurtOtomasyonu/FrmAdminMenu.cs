using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class FrmAdminMenu : Form
    {
        public FrmAdminMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            var a = new FrmOgrListFrm();
            a.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            var a = new Bolumler();
            a.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
            var c = new FrmAdminYemek();
            c.Visible = true;

        }

        private void FrmAdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Close();
            var y = new FrmAdminYönetim();
            y.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
            var a = new FrmAdminYoklama();
            a.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
            var b = new FrmAdminOdaYönetimi();
            b.Visible = true;
        }
    }
}
