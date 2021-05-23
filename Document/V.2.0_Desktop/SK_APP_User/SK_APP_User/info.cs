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
        String str = @"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable tb = new DataTable();
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from dbo.Info where username ='" + usernamee + "'";
            da.SelectCommand = cmd;
            tb.Clear();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
        }
        public info()
        {
            InitializeComponent();
            
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
        public string usernamee;
        private void info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sKDataSet.Info' table. You can move, or remove it, as needed.
            //this.infoTableAdapter.Fill(this.sKDataSet.Info);
            frm2lbl.Text = usernamee;
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
            //SqlDataAdapter sda = new SqlDataAdapter("select *from dbo.Info where username ='"+usernamee+"'", conn);
            //DataTable ds = new DataTable();
            //sda.Fill(ds);
            //dataGridView1.DataSource = ds;
            //dataGridView1.Refresh();
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            //float BMI;
            //float BMR;
            DateTime now = DateTime.Now;
            float BMI = (float.Parse(txt_nang.Text) / (float.Parse(txt_cao.Text)*2));
            conn.Open();
            try
            {
                //DateTime dateTime = DateTime.Now;
                //SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Info] ([height],[weigh],[BMI],[BMR],[inputdate],[username]) VALUES(< " + txt_cao.Text + ", smallmoney,>,< " + txt_nang.Text + ", smallmoney,>,< " + BMI + ", smallmoney,>,< BMR, smallmoney,>,< " + now + ", date,>,< " + usernamee + ", nchar(50),>)", conn);
                //SqlCommand cmd = new SqlCommand("insert into Info values('" + float.Parse(txt_cao.Text) + "','" + float.Parse(txt_nang.Text) + "','" + BMI + "', 'null','" + dateTime + "','" + usernamee + "')");
                //SqlCommand cmd = new SqlCommand("insert into Info values('"+ float.Parse(txt_cao.Text) + "', '"+ float.Parse(txt_nang.Text) + "', '"+null+"','"+null+"', '"+null+"','"+usernamee+"')");
                //cmd.ExecuteNonQuery();
                //SqlCommand cmd = new SqlCommand("insert into dbo.Info values(1.72, 60, null,null, null,'user')");
                //dataGridView1.Refresh();
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into dbo.Info values("+ float.Parse(txt_cao.Text) + ","+ float.Parse(txt_nang.Text) + "," + /*(float.Parse(txt_nang.Text) / (float.Parse(txt_cao.Text) * 2))*/BMI + " ,null, null,'" + usernamee +"')";
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("ok");
            }
            catch
            {
                MessageBox.Show("Ngu");
            }
            //SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from dbo.Login where username ='" + usernamee + "' and Sex ='Nam'", conn);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() == "1")
            //{
            //    MessageBox.Show("Tính bmr cho nam");
            //}
            //else
            //{
            //    MessageBox.Show("Tinh BMR cho nu");
            //}
            
            
         
            conn.Close();
        }
    }
}
