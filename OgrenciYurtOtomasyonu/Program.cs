using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            OgrBilgi a = new OgrBilgi();
            a.ID = 1;
            a.TC = "12345678999";
            a.Isim = "Alpay";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Giris().Show();
            Application.Run();
            
        }

        
    }
}
