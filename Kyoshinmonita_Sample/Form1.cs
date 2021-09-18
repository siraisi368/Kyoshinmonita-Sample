using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Net;

namespace Kyoshinmonita_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime dt1 = DateTime.Now;
                var dt = dt1.AddSeconds(-2);
                var url1 = $"http://www.kmoni.bosai.go.jp//data/map_img/RealTimeImg/acmap_s/{dt.ToString("yyyyMMdd")}/{dt.ToString("yyyyMMddHHmmss")}.acmap_s.gif";
                WebClient wc1 = new WebClient();
                Stream stream1 = wc1.OpenRead(url1);
                Bitmap bitmap1 = new Bitmap(stream1);
                stream1.Close();
                bitmap1.MakeTransparent();
                pictureBox1.BackgroundImage = bitmap1;

                pictureBox1.ImageLocation = $"http://www.kmoni.bosai.go.jp/data/map_img/PSWaveImg/eew/{dt.ToString("yyyyMMdd")}/{dt.ToString("yyyyMMddHHmmss")}.eew.gif";
            }
            catch
            {
                var aa = "at";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
