namespace SK_APP_User
{
    partial class BMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMI));
            this.lbltit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltit
            // 
            this.lbltit.BackColor = System.Drawing.Color.Olive;
            this.lbltit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltit.Location = new System.Drawing.Point(4, 0);
            this.lbltit.Name = "lbltit";
            this.lbltit.Size = new System.Drawing.Size(1018, 110);
            this.lbltit.TabIndex = 0;
            this.lbltit.Text = "Calculate Your Body Mass Index (BMI)";
            this.lbltit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltit.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Height(cm)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Weight(kg)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtweight);
            this.panel1.Controls.Add(this.txtheight);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 211);
            this.panel1.TabIndex = 3;
            this.panel1.UseWaitCursor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Olive;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(268, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 41);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.UseWaitCursor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Olive;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(55, 145);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 47);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.UseWaitCursor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(269, 75);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(191, 26);
            this.txtweight.TabIndex = 4;
            this.txtweight.UseWaitCursor = true;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(269, 28);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(191, 26);
            this.txtheight.TabIndex = 3;
            this.txtheight.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lblReview);
            this.panel2.Controls.Add(this.lblBMI);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(522, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 211);
            this.panel2.TabIndex = 4;
            this.panel2.UseWaitCursor = true;
            // 
            // lblReview
            // 
            this.lblReview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReview.Location = new System.Drawing.Point(205, 103);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(271, 89);
            this.lblReview.TabIndex = 3;
            this.lblReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReview.UseWaitCursor = true;
            // 
            // lblBMI
            // 
            this.lblBMI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBMI.Location = new System.Drawing.Point(205, 28);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(271, 28);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBMI.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Your BMI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Review your BMI";
            this.label3.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(10, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 427);
            this.panel3.TabIndex = 5;
            this.panel3.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(202, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(609, 51);
            this.label9.TabIndex = 4;
            this.label9.Text = "You should not use BMI as a measure if you\'re pregnant. Get advice from your midw" +
    "ife or GP if you\'re concerned about your weight.";
            this.label9.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(182, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(629, 99);
            this.label8.TabIndex = 3;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "How is BMI used?";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(182, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(647, 92);
            this.label6.TabIndex = 1;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "What BMI means?";
            this.label5.UseWaitCursor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Olive;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(12, 835);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(998, 52);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 967);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltit);
            this.Name = "BMI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "BMI";
            this.UseWaitCursor = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
    }
}