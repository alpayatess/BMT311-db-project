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
    public partial class FrmKullaniciMenu : Form
    {
        private OgrBilgi info;
        public FrmKullaniciMenu(OgrBilgi info)
        {
            this.info = info;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            var a = new FrmKullaniciYoklama(info);
            a.Visible = true;
           
        }

        private void FrmKullaniciMenu_Load(object sender, EventArgs e)
        {
            label4.Text = "Hos Geldin " + info.Isim;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
            var a = new FrmKullaniciYemek(info);
            a.Visible = true;
            
        }
    }
}
