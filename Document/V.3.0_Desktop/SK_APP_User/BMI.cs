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
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //float BMIvalue = float.Parse(txtweight.Text) / (float.Parse(txtheight) * 2);
            float cao = ((float.Parse(txtheight.Text) / 100) * (float.Parse(txtheight.Text) / 100) );
            float nang = float.Parse(txtweight.Text) ;
            float BMIvalue = nang / cao;
            lblBMI.Text = BMIvalue.ToString();
            if(BMIvalue < 18.5)
            {
                lblReview.Text = "You're in the underweight range";
            }
            if (BMIvalue <= 18.5 && BMIvalue < 25)
            {
                lblReview.Text = "you're in the healthy weight range";
            }
            if (BMIvalue <= 25 && BMIvalue < 30)
            {
                lblReview.Text = "You're in the overweight range";
            }
            if (BMIvalue <=30 && BMIvalue < 40)
            {
                lblReview.Text = "You're in the obese range";
            }
            if ( BMIvalue > 40)
            {
                lblReview.Text = "Your body is in trouble, you should see a doctor";
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtheight.Text = "";
            txtweight.Text = "";
            lblBMI.Text = "";
            lblReview.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
