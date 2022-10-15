using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartinki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public int k,k1,k2,b,h;
        public string p;
        PictureBox pct;
        int x, y, z = 1;

        string s;
        Random rnd = new Random();
        bool flag = true;

        private void Form2_Activated(object sender, EventArgs e)
        {
            this.Size = new Size(18 + 64 * k,115 + 64 * k);
            x = 5; y = 5;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    pct = new PictureBox();
                    pct.Tag = z;
                    z += 1;
                    pct.Size = new Size(50, 50);
                    pct.BackColor = Color.Blue;
                    pct.Location = new Point(x, y);
                    int a = rnd.Next(listok.Items.Count);
                    s = listok.Items[a].ToString();
                    pct.Name = (a).ToString();
                    this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    pct.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(s);
                    x += 60;
                    panel2.Controls.Add(pct);
                    pct.Click += Pct_Click;
                }
                y += 60;
                x = 5;
            }
        }

        private void Pct_Click(object sender, EventArgs e)
        {
            PictureBox pct = (PictureBox)sender;
            h = Convert.ToInt32(pct.Name);
            if (flag)
            {
                k1 = h;
                flag = false;
            }
            else
            {
                k2 = h;
                flag = true;
                if (k1 == k2)
                {
                    panel2.Controls.RemoveAt(b);
                    panel2.Controls.Remove(pct);
                }

            }
            b = panel2.Controls.IndexOf(pct);

        }
    }
}
