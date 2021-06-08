namespace SK_APP_User
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblshow = new System.Windows.Forms.Label();
            this.btnHere = new System.Windows.Forms.Button();
            this.lblsex = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblusname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.TextBox();
            this.MM = new System.Windows.Forms.TextBox();
            this.YY = new System.Windows.Forms.TextBox();
            this.listSex = new System.Windows.Forms.ListBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usname = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusename = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblshow);
            this.panel1.Controls.Add(this.btnHere);
            this.panel1.Controls.Add(this.lblsex);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblpass);
            this.panel1.Controls.Add(this.lblusname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dd);
            this.panel1.Controls.Add(this.MM);
            this.panel1.Controls.Add(this.YY);
            this.panel1.Controls.Add(this.listSex);
            this.panel1.Controls.Add(this.btnClick);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usname);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtusename);
            this.panel1.Location = new System.Drawing.Point(233, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 512);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblshow
            // 
            this.lblshow.Location = new System.Drawing.Point(51, 407);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(310, 36);
            this.lblshow.TabIndex = 22;
            // 
            // btnHere
            // 
            this.btnHere.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHere.Location = new System.Drawing.Point(49, 437);
            this.btnHere.Name = "btnHere";
            this.btnHere.Size = new System.Drawing.Size(318, 49);
            this.btnHere.TabIndex = 21;
            this.btnHere.Text = "Login Here";
            this.btnHere.UseVisualStyleBackColor = false;
            this.btnHere.Click += new System.EventHandler(this.btnHere_Click);
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(354, 253);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(0, 20);
            this.lblsex.TabIndex = 20;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(366, 195);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 20);
            this.lblname.TabIndex = 19;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(366, 144);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(0, 20);
            this.lblpass.TabIndex = 18;
            // 
            // lblusname
            // 
            this.lblusname.AutoSize = true;
            this.lblusname.Location = new System.Drawing.Point(366, 96);
            this.lblusname.Name = "lblusname";
            this.lblusname.Size = new System.Drawing.Size(0, 20);
            this.lblusname.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sex";
            // 
            // dd
            // 
            this.dd.Location = new System.Drawing.Point(309, 301);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(52, 26);
            this.dd.TabIndex = 15;
            this.dd.Enter += new System.EventHandler(this.dd_Enter);
            this.dd.Leave += new System.EventHandler(this.dd_Leave);
            // 
            // MM
            // 
            this.MM.Location = new System.Drawing.Point(251, 301);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(52, 26);
            this.MM.TabIndex = 14;
            this.MM.Enter += new System.EventHandler(this.MM_Enter);
            this.MM.Leave += new System.EventHandler(this.MM_Leave);
            // 
            // YY
            // 
            this.YY.Location = new System.Drawing.Point(171, 301);
            this.YY.Name = "YY";
            this.YY.Size = new System.Drawing.Size(74, 26);
            this.YY.TabIndex = 13;
            this.YY.TextChanged += new System.EventHandler(this.YY_TextChanged);
            this.YY.Enter += new System.EventHandler(this.YY_Enter);
            this.YY.Leave += new System.EventHandler(this.YY_Leave);
            // 
            // listSex
            // 
            this.listSex.FormattingEnabled = true;
            this.listSex.IntegralHeight = false;
            this.listSex.ItemHeight = 20;
            this.listSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.listSex.Location = new System.Drawing.Point(171, 249);
            this.listSex.Name = "listSex";
            this.listSex.Size = new System.Drawing.Size(177, 24);
            this.listSex.TabIndex = 12;
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClick.Location = new System.Drawing.Point(49, 363);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(318, 41);
            this.btnClick.TabIndex = 11;
            this.btnClick.Text = "Register";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(76, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Register your account";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(171, 192);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(177, 26);
            this.txtname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Full name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Passwork";
            // 
            // usname
            // 
            this.usname.AutoSize = true;
            this.usname.Location = new System.Drawing.Point(28, 93);
            this.usname.Name = "usname";
            this.usname.Size = new System.Drawing.Size(83, 20);
            this.usname.TabIndex = 3;
            this.usname.Text = "Username";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(171, 141);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(177, 26);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtusename
            // 
            this.txtusename.Location = new System.Drawing.Point(171, 93);
            this.txtusename.Name = "txtusename";
            this.txtusename.Size = new System.Drawing.Size(177, 26);
            this.txtusename.TabIndex = 0;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SK_APP_User.Properties.Resources.Login_Bg;
            this.ClientSize = new System.Drawing.Size(880, 576);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox dd;
        private System.Windows.Forms.TextBox MM;
        private System.Windows.Forms.TextBox YY;
        private System.Windows.Forms.ListBox listSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblusname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Button btnHere;
    }
}