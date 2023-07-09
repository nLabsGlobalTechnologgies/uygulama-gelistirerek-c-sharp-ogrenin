using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmCinemaSaleOtomation : Form
    {
        public frmCinemaSaleOtomation()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, result;

            misir = Convert.ToInt16(tx1.Text);
            su = Convert.ToInt16(tx2.Text);
            cay = Convert.ToInt16(tx3.Text);
            bilet = Convert.ToInt16(tx4.Text);
            result = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            lblresult.Text = result.ToString() + " TL";
            kasatutar = kasatutar + result;
            lblKasa.Text = kasatutar.ToString() + " TL";
        }
    }
}
