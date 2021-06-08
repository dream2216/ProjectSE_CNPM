using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SK_APP_User
{
    public partial class Register : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable tb = new DataTable();
        public Register()
        {
            InitializeComponent();
            YY.Text = "YYYY";
            YY.ForeColor = Color.Gray;
            this.YY.Leave += new System.EventHandler(this.YY_Leave);
            this.YY.Enter += new EventHandler(this.YY_Enter);

            MM.Text = "MM";
            MM.ForeColor = Color.Gray;
            this.MM.Leave += new System.EventHandler(this.MM_Leave);
            this.MM.Enter += new EventHandler(this.MM_Enter);

            dd.Text = "DD";
            dd.ForeColor = Color.Gray;
            this.dd.Leave += new System.EventHandler(this.dd_Leave);
            this.dd.Enter += new EventHandler(this.dd_Enter);
        }

     
        private void btnClick_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(str);
            conn.Open();
            try
                {
                
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into dbo.Login values('" + txtusename.Text + "','" + txtpass.Text + "','" + txtname.Text + "' ,'" + listSex.SelectedItem + "','" + YY.Text + "-" + MM.Text + "-" + dd.Text + "',null)";
                cmd.ExecuteNonQuery();               
                lblshow.Text= "Account created successfully";
                btnHere.Visible = true;
                
            }
            catch(Exception ex)
                {
                if (txtusename.Text == "")
                {
                    lblusname.Text = "**";
                    lblusname.ForeColor = Color.Red;
                }
                else
                {
                    lblusname.Text = "";
                }
                if (txtpass.Text == "")
                {
                    lblpass.Text = "**";
                    lblpass.ForeColor = Color.Red;
                }
                else
                {
                    lblpass.Text = "";
                }
                if (txtname.Text == "")
                {
                    lblname.Text = "**";
                    lblname.ForeColor = Color.Red;
                }
                else
                {
                    lblname.Text = "";
                }
                if (listSex.SelectedItem == null)
                {
                    lblsex.Text = "**";
                    lblsex.ForeColor = Color.Red;
                }
                else
                {
                    lblsex.Text = "";
                }
                MessageBox.Show("Something Wrong, check the information again");
                }
            //conn.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            

            conn = new SqlConnection(str);
            btnHere.Visible = false;
            
        }
        //Tao Placeholder
        private void YY_Leave(object sender, EventArgs e)
        {
            if(YY.Text =="")
            {
                YY.Text = "YYYY";
                YY.ForeColor = Color.Gray;
            }
        }

        private void YY_Enter(object sender, EventArgs e)
        {
            if (YY.Text != "")
            {
                YY.Text = "";
                YY.ForeColor = Color.Black;
            }
        }

        private void MM_Leave(object sender, EventArgs e)
        {
            if (MM.Text == "")
            {
                MM.Text = "MM";
                MM.ForeColor = Color.Gray;
            }
        }

        private void MM_Enter(object sender, EventArgs e)
        {
            if (MM.Text != "")
            {
                MM.Text = "";
                MM.ForeColor = Color.Black;
            }
        }

        private void dd_Leave(object sender, EventArgs e)
        {
            if (dd.Text == "")
            {
                dd.Text = "DD";
                dd.ForeColor = Color.Gray;
            }
        }

        private void dd_Enter(object sender, EventArgs e)
        {
            if (dd.Text != "")
            {
                dd.Text = "";
                dd.ForeColor = Color.Black;
            }
        }

        private void YY_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHere_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
            
        }
    }
}
