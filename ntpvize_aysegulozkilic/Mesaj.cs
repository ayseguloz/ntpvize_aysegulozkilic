using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntpvize_aysegulozkilic
{
    public partial class Mesaj : Form
    {
        public Mesaj(Haberler haberr)
        {
            InitializeComponent();
            groupBox1.Text = "En Son Haber(" + haberr.Id.Trim()+ ")";
            labelbaslik.Text = haberr.Baslik.Trim();
         
        }

        private void timerkapat_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
