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
    public partial class Statistics : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable tb = new DataTable();

        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from Info  where username ='" +ususernamee+ "'ORDER BY inputdate desc";
            //cmd.CommandText = "select * from Login where UserName = '" + usernamee + "'";
            da.SelectCommand = cmd;
            tb.Clear();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            conn.Close();
        }
        public Statistics()
        {
            InitializeComponent();
        }
        public string ususernamee;
        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sKDataSet.Info' table. You can move, or remove it, as needed.
            this.infoTableAdapter.Fill(this.sKDataSet.Info);
            DateTime now = DateTime.Now;
            
            //conn = new SqlConnection(str);
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
            SqlDataAdapter sd = new SqlDataAdapter("select * from dbo.Login where username ='" + ususernamee + "'", con);
            DataTable d = new DataTable();
            sd.Fill(d);
            //dataGridView1.DataSource = d;            
            lblName.Text = d.Rows[0][2].ToString();
            lblSex.Text = d.Rows[0][3].ToString();
            lblus.Text = d.Rows[0][0].ToString();
            dateTimeage.Text = d.Rows[0][4].ToString();
            DateTime agee = DateTime.Parse(dateTimeage.Text);
            us.Text = agee.ToString("yyyy");
            lblAge.Text = (int.Parse(now.ToString("yyyy"))- int.Parse(agee.ToString("yyyy"))).ToString();
            con.Close();
            //load du lieu ca nhan vao datagird
            SqlConnection connn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
            SqlDataAdapter sdb = new SqlDataAdapter("select *from Info  where username ='" +ususernamee + "'ORDER BY inputdate desc", connn);
            DataTable dtb = new DataTable();
            sdb.Fill(dtb);
            dataGridView1.DataSource = dtb;
            con.Close();
            //load chart index
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
            //SqlDataAdapter sdbb = new SqlDataAdapter("select *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            SqlDataAdapter sdbb = new SqlDataAdapter("select top 7 *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            DataTable dtbb = new DataTable();
            sdbb.Fill(dtbb);
            chart1.DataSource = dtbb;

            chart1.Series["Weight"].XValueMember = "";
            chart1.Series["Weight"].YValueMembers = "weigh";

            chart1.Series["BMI"].XValueMember = "";
            chart1.Series["BMI"].YValueMembers = "BMI";

            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.DataBind();
            cn.Close();
            lblshow.Text = "Statistical chart of BMI & Weight for the past 7 days";
            chartBMR.Hide();
            chartBMI.Hide();
            chartHeight.Hide();
            chartWeight.Hide();
            chart1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btninput_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();

            try
            {
                float cao = ((float.Parse(txtH.Text) / 100) * (float.Parse(txtH.Text) / 100));
                float nang = float.Parse(txtW.Text);
                float BMIvalue = nang / cao;
                DateTime now = DateTime.Now;
                double W = double.Parse(txtW.Text) * 10;
                double H = double.Parse(txtH.Text) * 6.25;
                double A = double.Parse(lblAge.Text) * 5;
                double BMR;
                if (lblSex.Text == "Nam")
                {
                    BMR = W + H -A + 5;
                }
                else
                {
                    BMR = W + H -A - 161;
                }


                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into Info values('"+float.Parse(txtH.Text)/100+"','"+txtW.Text+"','"+BMIvalue+"','"+BMR+"','"+now.ToString("yyyy/MM/dd") +"','"+ususernamee+"')";
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("ok");
                
                

            }
            catch
            {
                MessageBox.Show("Somthing Wrong, Check infomation again");
            }
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            
        }
        // load du lieu vao chart, tao nut thay doi du lieu
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
            //SqlDataAdapter sdbb = new SqlDataAdapter("select *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            SqlDataAdapter sdbb = new SqlDataAdapter("select top 7 *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            DataTable dtbb = new DataTable();
            sdbb.Fill(dtbb);
            chartBMR.DataSource = dtbb;

            chartBMR.Series["BMR"].XValueMember = "";
            chartBMR.Series["BMR"].YValueMembers = "BMR";
            chartBMR.DataBind();
            cn.Close();

            chart1.Hide();
            chartBMI.Hide();
            chartBMR.Show();
            chartHeight.Hide();
            chartWeight.Hide();
            chartBMR.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            lblshow.Text = "Statistical chart of BMR for the past 7 days";
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
            //SqlDataAdapter sdbb = new SqlDataAdapter("select *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            SqlDataAdapter sdbb = new SqlDataAdapter("select top 7 *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            DataTable dtbb = new DataTable();
            sdbb.Fill(dtbb);
            chart1.DataSource = dtbb;

            chart1.Series["Weight"].XValueMember = "";
            chart1.Series["Weight"].YValueMembers = "weigh";

            chart1.Series["BMI"].XValueMember = "";
            chart1.Series["BMI"].YValueMembers = "BMI";

            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.DataBind();
            cn.Close();

            lblshow.Text = "Statistical chart of BMI & Weight for the past 7 days";
            chartBMR.Hide();
            chartBMI.Hide();
            chartHeight.Hide();
            chartWeight.Hide();
            chart1.Show();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
            SqlDataAdapter sdbb = new SqlDataAdapter("select top 7 *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            DataTable dtbb = new DataTable();
            sdbb.Fill(dtbb);
            chartBMI.DataSource = dtbb;
            chartBMI.Series["BMI"].XValueMember = "";
            chartBMI.Series["BMI"].YValueMembers = "BMI";
            chartBMI.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chartBMI.DataBind();
            chartBMI.Show();
            cn.Close();


            lblshow.Text = "Statistical chart of BMI for the past 7 days";
            chartBMR.Hide();           
            chart1.Hide();
            chartHeight.Hide();
            chartWeight.Hide();
        }

        private void btnHeight_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
            //SqlDataAdapter sdbb = new SqlDataAdapter("select *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            SqlDataAdapter sdbb = new SqlDataAdapter("select top 7 *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            DataTable dtbb = new DataTable();
            sdbb.Fill(dtbb);
            chartHeight.DataSource = dtbb;

            chartHeight.Series["Height"].XValueMember = "";
            chartHeight.Series["Height"].YValueMembers = "Height";

            chartHeight.DataBind();
            chartHeight.Show();
            cn.Close();

            chartHeight.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            lblshow.Text = "Statistical chart of Height for the past 7 days";
            chartBMR.Hide();
            chart1.Hide();
            chartBMI.Hide();
            chartWeight.Hide();
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-4U1ED10J;Initial Catalog=SK;Integrated Security=True");
            //SqlDataAdapter sdbb = new SqlDataAdapter("select *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            SqlDataAdapter sdbb = new SqlDataAdapter("select top 7 *from Info  where username ='" + ususernamee + "'ORDER BY inputdate desc", cn);
            DataTable dtbb = new DataTable();
            sdbb.Fill(dtbb);
            chartWeight.DataSource = dtbb;

            chartWeight.Series["Weight"].XValueMember = "";
            chartWeight.Series["Weight"].YValueMembers = "weigh";

            chartWeight.DataBind();
            chartWeight.Show();
            cn.Close();

            chartWeight.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            lblshow.Text = "Statistical chart of Weight for the past 7 days";
            chartBMR.Hide();
            chart1.Hide();
            chartBMI.Hide();
            chartHeight.Hide();
        }
    }
}
