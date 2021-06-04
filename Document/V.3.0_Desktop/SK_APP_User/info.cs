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
    public partial class info : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable tb = new DataTable();
        void loaddata()
        {
            cmd = conn.CreateCommand();
            //cmd.CommandText = "select *from Info  where username ='" + usernamee + "'ORDER BY inputdate desc";
            cmd.CommandText = "select * from Login where UserName = '" + usernamee + "'";
            da.SelectCommand = cmd;
            tb.Clear();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            lbltimeup.Text = tb.Rows[0][5].ToString();
            
        }
        public info()
        {
            InitializeComponent();
            
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
        public string usernamee;
        private void info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sKDataSet2.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.sKDataSet2.Login);
            // TODO: This line of code loads data into the 'sKDataSet.Info' table. You can move, or remove it, as needed.
            //this.infoTableAdapter.Fill(this.sKDataSet.Info);
            //frm2lbl.Text = usernamee;
            lblusername.Text = usernamee;
            conn = new SqlConnection(str);
            btnclose.Visible = false;
            paneedit.Visible = false;
            conn.Open();
            loaddata();          
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       private void btn_input_Click(object sender, EventArgs e)
       {
           
       }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtfullname.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtsex.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtbirth.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
           
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //lbltimeup.Text = now.ToString("yyyy/MM/dd hh:mm:ss tt");
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "update Login set name = '" + txtfullname.Text + "', sex =N'" + txtsex.Text + "', Timeupdate ='"+now.ToString("yyyy/MM/dd hh:mm:ss tt") +"'  where username = '" + usernamee + "'";
                cmd.ExecuteNonQuery();
                loaddata();
                lbltimeup.Text = tb.Rows[0][5].ToString();
                
                MessageBox.Show("update successfully");
                
            }
            catch
            {
                MessageBox.Show("update Field");
            }
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnclose.Visible = true;
            paneedit.Visible = true;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            btnclose.Visible = false;
            btnEdit.Visible = true;
            paneedit.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            conn.Open();
            try
            {
                SqlConnection conection = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from dbo.Login where username ='" + usernamee + "' and passwork ='" + txtpasswork.Text + "'", conection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    if(txtnewpass.Text == txtconfirmpass.Text)
                    {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "update Login set passwork = '"+txtnewpass.Text+ "',Timeupdate ='" + now.ToString("yyyy/MM/dd hh:mm:ss tt") + "'  where username = '" + usernamee + "'";
                        cmd.ExecuteNonQuery();
                        loaddata();
                        lbltimeup.Text = tb.Rows[0][5].ToString();
                        loaddata();
                        MessageBox.Show("update successfully");
                    }
                    else
                    {
                        MessageBox.Show("Update Field");
                    }

                }
                conection.Close();
            }
            catch
            {
                MessageBox.Show("Something Wrong");
            }
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
