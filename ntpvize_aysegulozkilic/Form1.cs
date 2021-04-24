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
        List<Haberler> Haberleryeni = new List<Haberler>();
        List<Haberler> datagridhaber = new List<Haberler>();
        string yol = @"c:\Haberler\GuncelHaberler.txt";
        public Frmxmlyeni()
        {
            
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

            private void HaberleriGoster()
        {
            List<Haberler> guncelliste = new List<Haberler>();
            dataGridView1.DataSource = guncelliste;
            Haberleryeni = Haberleryeni.OrderBy(x => x.Tarih).ToList();

            foreach(Haberler habers in Haberleryeni)
            {
                var yenihaberler = datagridhaber.Where(x => x.Id == habers.Id).FirstOrDefault();
                if(yenihaberler == null)
                {
                    datagridhaber.Add(habers);
                    YeniHaberiGoster(habers); // aşağıda tanımlansın
                    break;
                }

            }
           

        }









    }
}
