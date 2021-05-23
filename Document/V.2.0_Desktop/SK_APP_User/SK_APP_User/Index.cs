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
    public partial class Index : Form
    {
        string strNhan;
        public Index()
        {
            InitializeComponent();
            
        }
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();      
            
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.usernamee = strNhan;
            info.Show();
            
        }
        
    }
}
