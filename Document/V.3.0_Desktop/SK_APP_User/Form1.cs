using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SK_APP_User
{
    public partial class Login : Form
    {
       

        public Login()
        {
            InitializeComponent();
            txt_username.Text = "UserName";
            txt_username.ForeColor = Color.White;
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);

            txt_pass.Text = "PassWork";
            txt_pass.ForeColor = Color.White;
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);          
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text =="")
            {
                txt_username.Text = "UserName";
                txt_username.ForeColor = Color.White;

            }
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "UserName")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
                
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if(txt_pass.Text=="")
            {
                txt_pass.Text = "PassWork";
                txt_pass.ForeColor = Color.White;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if(txt_pass.Text== "PassWork")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.Black;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from dbo.Login where username ='" +txt_username.Text + "' and passwork ='" + txt_pass.Text + "'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Index index = new Index();
                index.Message = txt_username.Text;
                index.Show();
                
            }
            else
            {
                MessageBox.Show("Ngu"); 
            }
            conn.Close();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                //btn_login_Click(sender, e);
                btn_login.PerformClick();
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            {
                KeyPreview = true;
                this.KeyDown += Login_KeyDown;
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            this.Hide();
            Register register = new Register();          
            register.Show();
          
        }
    }
}
