using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikusKontrol
{
    public partial class Form1 : Form
    {
        int sorokSzama = 3;
        int oszlopokSzama = 6;
        int buttonSize = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < sorokSzama; x++)
            {
                for (int y = 0; y < oszlopokSzama; y++)
                {
                    PictureBox PB = new PictureBox();
                    PB.SizeMode = PictureBoxSizeMode.StretchImage;
                    PB.BorderStyle = BorderStyle.FixedSingle;
                    PB.SetBounds(x*buttonSize,y*buttonSize,buttonSize,buttonSize);
                    PB.Click += (bo, be) =>
                    {
                        PictureBox bpb = (PictureBox)bo;
                        bpb.ImageLocation = "https://freeiconshop.com/wp-content/uploads/edd/checkmark-flat.png";
                    };
                    this.Controls.Add(PB);
                }
            }
        }
    }
}
