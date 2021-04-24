using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace ntpvize_aysegulozkilic
{
    public partial class Frmxmlyeni : Form
    {
        public Frmxmlyeni()
        {
            List<Haberler> Haberleryeni = new List<Haberler>();
            List<Haberler> datagridhaber = new List<Haberler>();
            string yol = @"c:\Haberler\GuncelHaberler.txt";
            InitializeComponent();
            try
            { 
                if(File.Exists(yol))
                    {
                    File.Delete(yol);

                    }

            }
            catch { }
        }
       




    }
}
