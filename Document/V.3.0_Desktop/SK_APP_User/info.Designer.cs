namespace SK_APP_User
{
    partial class info
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKDataSet2 = new SK_APP_User.SKDataSet2();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKDataSet = new SK_APP_User.SKDataSet();
            this.infoTableAdapter = new SK_APP_User.SKDataSetTableAdapters.InfoTableAdapter();
            this.sKDataSet1 = new SK_APP_User.SKDataSet1();
            this.sKDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new SK_APP_User.SKDataSet2TableAdapters.LoginTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbirth = new System.Windows.Forms.DateTimePicker();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltimeup = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panepass = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paneedit = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpasswork = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSetBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panepass.SuspendLayout();
            this.paneedit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(459, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(537, 138);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.sKDataSet2;
            // 
            // sKDataSet2
            // 
            this.sKDataSet2.DataSetName = "SKDataSet2";
            this.sKDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "Info";
            this.infoBindingSource.DataSource = this.sKDataSet;
            // 
            // sKDataSet
            // 
            this.sKDataSet.DataSetName = "SKDataSet";
            this.sKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // sKDataSet1
            // 
            this.sKDataSet1.DataSetName = "SKDataSet1";
            this.sKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sKDataSet1BindingSource
            // 
            this.sKDataSet1BindingSource.DataSource = this.sKDataSet1;
            this.sKDataSet1BindingSource.Position = 0;
            // 
            // sKDataSet1BindingSource1
            // 
            this.sKDataSet1BindingSource1.DataSource = this.sKDataSet1;
            this.sKDataSet1BindingSource1.Position = 0;
            // 
            // sKDataSetBindingSource
            // 
            this.sKDataSetBindingSource.DataSource = this.sKDataSet;
            this.sKDataSetBindingSource.Position = 0;
            // 
            // sKDataSetBindingSource1
            // 
            this.sKDataSetBindingSource1.DataSource = this.sKDataSet;
            this.sKDataSetBindingSource1.Position = 0;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtbirth);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.txtsex);
            this.panel1.Controls.Add(this.txtfullname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(30, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 306);
            this.panel1.TabIndex = 7;
            // 
            // txtbirth
            // 
            this.txtbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtbirth.Location = new System.Drawing.Point(165, 157);
            this.txtbirth.Name = "txtbirth";
            this.txtbirth.Size = new System.Drawing.Size(179, 26);
            this.txtbirth.TabIndex = 7;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Olive;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(33, 224);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(351, 49);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txtsex
            // 
            this.txtsex.Location = new System.Drawing.Point(165, 88);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(179, 26);
            this.txtsex.TabIndex = 4;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(165, 25);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(179, 26);
            this.txtfullname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.lblusername);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 130);
            this.panel2.TabIndex = 8;
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblusername.Location = new System.Drawing.Point(523, 68);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(194, 32);
            this.lblusername.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(360, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "UserName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(378, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.lbltimeup);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(459, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 120);
            this.panel3.TabIndex = 9;
            // 
            // lbltimeup
            // 
            this.lbltimeup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltimeup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeup.Location = new System.Drawing.Point(200, 38);
            this.lbltimeup.Name = "lbltimeup";
            this.lbltimeup.Size = new System.Drawing.Size(253, 29);
            this.lbltimeup.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Last update:";
            // 
            // panepass
            // 
            this.panepass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panepass.Controls.Add(this.btnclose);
            this.panepass.Controls.Add(this.btnEdit);
            this.panepass.Controls.Add(this.label2);
            this.panepass.Controls.Add(this.label1);
            this.panepass.Location = new System.Drawing.Point(30, 535);
            this.panepass.Name = "panepass";
            this.panepass.Size = new System.Drawing.Size(966, 94);
            this.panepass.TabIndex = 10;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Olive;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.Location = new System.Drawing.Point(782, 23);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(150, 56);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Olive;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(782, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 56);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(43, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "You should use a strong password that you have not used anywhere else";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change password";
            // 
            // paneedit
            // 
            this.paneedit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paneedit.Controls.Add(this.button1);
            this.paneedit.Controls.Add(this.txtconfirmpass);
            this.paneedit.Controls.Add(this.txtnewpass);
            this.paneedit.Controls.Add(this.label11);
            this.paneedit.Controls.Add(this.txtpasswork);
            this.paneedit.Controls.Add(this.label10);
            this.paneedit.Controls.Add(this.label9);
            this.paneedit.Location = new System.Drawing.Point(30, 668);
            this.paneedit.Name = "paneedit";
            this.paneedit.Size = new System.Drawing.Size(977, 183);
            this.paneedit.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(803, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Location = new System.Drawing.Point(459, 109);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.Size = new System.Drawing.Size(230, 26);
            this.txtconfirmpass.TabIndex = 5;
            this.txtconfirmpass.UseSystemPasswordChar = true;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(459, 62);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(230, 26);
            this.txtnewpass.TabIndex = 4;
            this.txtnewpass.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Confirm New Passwork";
            // 
            // txtpasswork
            // 
            this.txtpasswork.Location = new System.Drawing.Point(459, 18);
            this.txtpasswork.Name = "txtpasswork";
            this.txtpasswork.Size = new System.Drawing.Size(230, 26);
            this.txtpasswork.TabIndex = 2;
            this.txtpasswork.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "New Passwork";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Your Old Passwork";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Olive;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(30, 877);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(966, 59);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 959);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.paneedit);
            this.Controls.Add(this.panepass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "info";
            this.Text = "info";
            this.Load += new System.EventHandler(this.info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSetBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panepass.ResumeLayout(false);
            this.paneedit.ResumeLayout(false);
            this.paneedit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private SKDataSet sKDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private SKDataSetTableAdapters.InfoTableAdapter infoTableAdapter;
        private System.Windows.Forms.BindingSource sKDataSetBindingSource1;
        private SKDataSet1 sKDataSet1;
        private System.Windows.Forms.BindingSource sKDataSet1BindingSource;
        private System.Windows.Forms.BindingSource sKDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource sKDataSetBindingSource;
        private SKDataSet2 sKDataSet2;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private SKDataSet2TableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltimeup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtbirth;
        private System.Windows.Forms.Panel panepass;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paneedit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpasswork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnclose;
    }
}