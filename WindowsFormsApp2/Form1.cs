using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public double Sum { get; set; }
        public double BirLitrQiymet { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void cmbox_YanacaqNovu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbox_YanacaqNovu.SelectedItem.ToString() == "PREMIUM")
            {
                txt_1LitrQiymeti.Text = "2 ";
                BirLitrQiymet = 2;
            }
            else if(cmbox_YanacaqNovu.SelectedItem.ToString() == "A92")
            {
                txt_1LitrQiymeti.Text = "1 ";
                BirLitrQiymet = 1;
            }
            else if (cmbox_YanacaqNovu.SelectedItem.ToString() == "DIZEL")
            {
                txt_1LitrQiymeti.Text = "0.50 ";
                BirLitrQiymet = .5;
            }

            rbtnAznToLitr.Enabled = true;
            rbtn_LitrToAzn.Enabled = true;

        }

        private void rbtnAznToLitr_CheckedChanged(object sender, EventArgs e)
        {
            txtAznToLitr.Enabled = true; 
            txt_LitrToAzn.ReadOnly = true;
            txtAznToLitr.ReadOnly = false;
            txtAznToLitr.Clear();
            txt_LitrToAzn.Clear();
            lbl_BenzinQiymet.Text = "0 AZN";
        }

        private void rbtn_LitrToAzn_CheckedChanged(object sender, EventArgs e)
        {
            txt_LitrToAzn.Enabled = true; 
            txtAznToLitr.ReadOnly = true;
            txt_LitrToAzn.ReadOnly = false;
            txtAznToLitr.Clear();
            txt_LitrToAzn.Clear();
            lbl_BenzinQiymet.Text = "0 AZN";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnAznToLitr.Enabled = false;
            txtAznToLitr.Enabled = false;
            rbtn_LitrToAzn.Enabled = false;
            txt_LitrToAzn.Enabled = false;
        }


        private void txt_LitrToAzn_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txt_LitrToAzn.Text.ToString(), out double result))
            {
                txtAznToLitr.Text = Convert.ToString(result * BirLitrQiymet);
                lbl_BenzinQiymet.Text = Convert.ToString(result * BirLitrQiymet);
            }
        }

        private void txtAznToLitr_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtAznToLitr.Text.ToString(), out double result))
            { 
                txt_LitrToAzn.Text = Convert.ToString(result / BirLitrQiymet);
                lbl_BenzinQiymet.Text = Convert.ToString(result / BirLitrQiymet); 
            }
        }

        private void chek_HotDog_CheckedChanged(object sender, EventArgs e)
        {
            txt_hotMiqdar.ReadOnly = false;
        }

        private void chek_Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            txt_HamMiqdar.ReadOnly = false;
        }

        private void chek_Free_CheckedChanged(object sender, EventArgs e)
        {
            txt_FreeMiqdar.ReadOnly = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txt_ColaMiqdar.ReadOnly = false;
        }


    }
}
