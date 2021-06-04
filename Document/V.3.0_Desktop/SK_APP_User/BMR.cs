using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SK_APP_User
{
    
    public partial class BMR : Form
    {
        public BMR()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
            try
            {
                double W = double.Parse(txtweight.Text) * 10;
                double H = double.Parse(txtheight.Text) * 6.25;
                double A = double.Parse(txtAge.Text) * 5;
                double BMR;
                
                
                if (checkmale.CheckState == CheckState.Checked)
                {
                    BMR = W + H - A + 5;

                }
                else
                {
                    BMR = W + H - A - 161;
                }

                lblresult.Text = "BMR = '" + BMR.ToString() + "' Calories/day";
            }
            catch
            {
                if (txtAge.Text == "")
                {
                    lblA.Text = "**";
                }
                if (txtheight.Text == "")
                {
                    lblH.Text = "**";
                }
                if (txtweight.Text == "")
                {
                    lblW.Text = "**";
                }
                if(checkmale.CheckState == CheckState.Unchecked && checkfemale.CheckState==CheckState.Unchecked)
                {
                    lblG.Text = "**";
                }
                MessageBox.Show("Registration failed, please check the information again ");
            }
            
        }

        private void checkmale_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkmale_Click(object sender, EventArgs e)
        {
            if (checkmale.CheckState == CheckState.Checked)
            {
                checkfemale.CheckState = CheckState.Unchecked;
            }
            else 
            {
                checkmale.CheckState = CheckState.Unchecked;
            }
        }

        private void checkfemale_Click(object sender, EventArgs e)
        {
            if (checkfemale.CheckState == CheckState.Checked)
            {
                checkmale.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkfemale.CheckState = CheckState.Unchecked;
            }
          
            
        }
    }
}
