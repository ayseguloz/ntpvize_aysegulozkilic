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
                if (File.Exists(yol))
                {
                    File.Delete(yol);

                }

            }
            catch { }
        }

        public Frmxmlyeni(Haberler haber)
        {


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

        private void YeniHaberiGoster(Haberler haberr)
        {
            Frmxmlyeni Frmxmlyeni = new Frmxmlyeni(haberr);
            Frmxmlyeni.ShowDialog();

            groupBox1.Text = "En Son Haberler(" + haberr.Id.Trim() + ")";
            labelbaslik.Text = haberr.Baslik.Trim();
            labelaciklama.Text = haberr.Aciklama.Trim();
            labeltarih.Text = haberr.Tarih.ToString();
            labellink.Text = haberr.Link.Trim();
            HaberlerYaz(haberr);

          

        }
        public void HaberlerYaz(Haberler haberr)
        {
           
            using(TextWriter yaz =new StreamWriter(yol,true))
            {
                yaz.WriteLine("Haber No:" + haberr.Id.Trim(), Environment.NewLine);
                yaz.WriteLine("Başlık:" + haberr.Baslik.Trim(), Environment.NewLine);
                yaz.WriteLine("Açıklama:" + haberr.Aciklama.Trim(), Environment.NewLine);
                yaz.WriteLine("Link:" + haberr.Link.Trim(), Environment.NewLine);
                yaz.WriteLine("Tarih:" + haberr.Tarih.ToString(), Environment.NewLine);
            }

        }

        private void HaberGetir()
        {
            Haberleryeni = new List<Haberler>();
            XmlDocument xml = new XmlDocument();
            xml.Load("https://www.aa.com.tr/tr/rss/default?cat=guncel");
            XmlNodeList xmlim = xml.SelectNodes("rss/channel/item");
            foreach(XmlNode xmli in  xmlim)
            { 
                try
                {
                    Haberler haberler = new Haberler();

                    XmlNode xmlekle = xmli.SelectSingleNode("title");
                    haberler.Baslik = xmlekle != null ? xmlekle.InnerText : "";

                    xmlekle = xmli.SelectSingleNode("guid");
                    haberler. Id = xmlekle != null ? xmlekle.InnerText : "";

                    xmlekle = xmli.SelectSingleNode("pubDate");
                    string tarih  = xmlekle != null ? xmlekle.InnerText : "";
                    haberler.Tarih = Convert.ToDateTime(tarih);

                    xmlekle = xmli.SelectSingleNode("description");
                    haberler.Aciklama = xmlekle != null ? xmlekle.InnerText : "";

                    xmlekle = xmli.SelectSingleNode("description");
                    haberler.Aciklama = xmlekle != null ? xmlekle.InnerText : "";

                    if (haberler.Tarih >= DateTime.Today)
                    {
                        Haberleryeni.Add(haberler);
                    }
                }
                catch { }
                HaberGetir();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                HaberGetir();

            }
            catch { }
        }
    }
}
