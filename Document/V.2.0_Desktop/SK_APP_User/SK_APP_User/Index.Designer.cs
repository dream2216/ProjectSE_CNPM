namespace SK_APP_User
{
    partial class Index
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_tke = new System.Windows.Forms.Button();
            this.btn_bmi = new System.Windows.Forms.Button();
            this.btn_bmr = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 208);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(299, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng dụng lưu trữ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(173, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(692, 77);
            this.label2.TabIndex = 1;
            this.label2.Text = "Và theo dõi chỉ số sức khỏe";
            // 
            // btn_input
            // 
            this.btn_input.BackColor = System.Drawing.Color.Red;
            this.btn_input.Location = new System.Drawing.Point(52, 238);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(422, 199);
            this.btn_input.TabIndex = 1;
            this.btn_input.Text = "Dữ liệu cá nhân";
            this.btn_input.UseVisualStyleBackColor = false;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_tke
            // 
            this.btn_tke.BackColor = System.Drawing.Color.Red;
            this.btn_tke.Location = new System.Drawing.Point(570, 238);
            this.btn_tke.Name = "btn_tke";
            this.btn_tke.Size = new System.Drawing.Size(422, 199);
            this.btn_tke.TabIndex = 2;
            this.btn_tke.Text = "Thống kê chỉ số";
            this.btn_tke.UseVisualStyleBackColor = false;
            // 
            // btn_bmi
            // 
            this.btn_bmi.BackColor = System.Drawing.Color.Red;
            this.btn_bmi.Location = new System.Drawing.Point(52, 463);
            this.btn_bmi.Name = "btn_bmi";
            this.btn_bmi.Size = new System.Drawing.Size(422, 199);
            this.btn_bmi.TabIndex = 3;
            this.btn_bmi.Text = "Tính BMI";
            this.btn_bmi.UseVisualStyleBackColor = false;
            // 
            // btn_bmr
            // 
            this.btn_bmr.BackColor = System.Drawing.Color.Red;
            this.btn_bmr.Location = new System.Drawing.Point(570, 463);
            this.btn_bmr.Name = "btn_bmr";
            this.btn_bmr.Size = new System.Drawing.Size(422, 199);
            this.btn_bmr.TabIndex = 4;
            this.btn_bmr.Text = "Tính BMR";
            this.btn_bmr.UseVisualStyleBackColor = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_logout.Location = new System.Drawing.Point(52, 766);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(940, 51);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Đăng Xuất";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 895);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_bmr);
            this.Controls.Add(this.btn_bmi);
            this.Controls.Add(this.btn_tke);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.panel1);
            this.Name = "Index";
            this.Text = "Index";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Button btn_tke;
        private System.Windows.Forms.Button btn_bmi;
        private System.Windows.Forms.Button btn_bmr;
        private System.Windows.Forms.Button btn_logout;
    }
}