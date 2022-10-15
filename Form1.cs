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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfrm_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.labelim.Text = "Добро пожаловать " + txtim.Text;
            frm.k = Convert.ToInt32(txtchi.Text);
            frm.ShowDialog();
            this.Show();
            frm.Dispose();
        }
    }
}
