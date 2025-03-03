using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai17_tinh_lai_xuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double sotien = double.Parse(txtvon.Text);
            double laixuat = double.Parse(txtls.Text.Replace("%", "")) / 100;
            int nam = Convert.ToInt32(txtnam.Text);
            double tienlai = 0;
lstkq.Items.Clear();
            for (int i = 1; i <= nam; i++)
            {
                tienlai = sotien * laixuat;
                sotien += tienlai;
                lstkq.Items.Add("Năm " + i + ": vốn " + string.Format("{0:N0}",sotien)+"- tiền lãi:"+string.Format("{0:N2}",tienlai));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtvon.Text = "1000000";
            txtls.Text = "3.1%";
            txtnam.Text = "5";
        }
    }
}
