using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_strip_kullanimi
{
    public partial class Chart_grafik : Form
    {
        public Chart_grafik()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Akdeniz",5);
            chart1.Series["Kitap"].Points.AddXY("Ege", 8);
            chart1.Series["Kitap"].Points.AddXY("İç Anadolu", 3);
            chart1.Series["Kitap"].Points.AddXY("Karadeniz", 6);
            chart1.Series["Kitap"].Points.AddXY("Marmara Bölgesi", 9);
        }
    }
}
