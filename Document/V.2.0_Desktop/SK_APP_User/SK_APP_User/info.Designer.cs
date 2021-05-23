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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.frm2lbl = new System.Windows.Forms.Label();
            this.txt_cao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sKDataSet = new SK_APP_User.SKDataSet();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter = new SK_APP_User.SKDataSetTableAdapters.InfoTableAdapter();
            this.btn_input = new System.Windows.Forms.Button();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.frm2lbl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1027, 129);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // frm2lbl
            // 
            this.frm2lbl.Location = new System.Drawing.Point(3, 0);
            this.frm2lbl.Name = "frm2lbl";
            this.frm2lbl.Size = new System.Drawing.Size(193, 129);
            this.frm2lbl.TabIndex = 0;
            // 
            // txt_cao
            // 
            this.txt_cao.Location = new System.Drawing.Point(259, 187);
            this.txt_cao.Name = "txt_cao";
            this.txt_cao.Size = new System.Drawing.Size(115, 26);
            this.txt_cao.TabIndex = 1;
            this.txt_cao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chiều Cao (m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cân Nặng (kg)";
            // 
            // txt_nang
            // 
            this.txt_nang.Location = new System.Drawing.Point(628, 193);
            this.txt_nang.Name = "txt_nang";
            this.txt_nang.Size = new System.Drawing.Size(149, 26);
            this.txt_nang.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heightDataGridViewTextBoxColumn,
            this.weighDataGridViewTextBoxColumn,
            this.bMIDataGridViewTextBoxColumn,
            this.bMRDataGridViewTextBoxColumn,
            this.inputdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(131, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(793, 330);
            this.dataGridView1.TabIndex = 5;
            // 
            // sKDataSet
            // 
            this.sKDataSet.DataSetName = "SKDataSet";
            this.sKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "Info";
            this.infoBindingSource.DataSource = this.sKDataSet;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(858, 191);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(134, 33);
            this.btn_input.TabIndex = 6;
            this.btn_input.Text = "Nhập";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Chiều Cao";
            this.heightDataGridViewTextBoxColumn.MaxInputLength = 32000;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.Width = 150;
            // 
            // weighDataGridViewTextBoxColumn
            // 
            this.weighDataGridViewTextBoxColumn.DataPropertyName = "weigh";
            this.weighDataGridViewTextBoxColumn.HeaderText = "Cân Nặng";
            this.weighDataGridViewTextBoxColumn.Name = "weighDataGridViewTextBoxColumn";
            this.weighDataGridViewTextBoxColumn.Width = 150;
            // 
            // bMIDataGridViewTextBoxColumn
            // 
            this.bMIDataGridViewTextBoxColumn.DataPropertyName = "BMI";
            this.bMIDataGridViewTextBoxColumn.HeaderText = "BMI";
            this.bMIDataGridViewTextBoxColumn.Name = "bMIDataGridViewTextBoxColumn";
            this.bMIDataGridViewTextBoxColumn.Width = 150;
            // 
            // bMRDataGridViewTextBoxColumn
            // 
            this.bMRDataGridViewTextBoxColumn.DataPropertyName = "BMR";
            this.bMRDataGridViewTextBoxColumn.HeaderText = "BMR";
            this.bMRDataGridViewTextBoxColumn.Name = "bMRDataGridViewTextBoxColumn";
            this.bMRDataGridViewTextBoxColumn.Width = 150;
            // 
            // inputdateDataGridViewTextBoxColumn
            // 
            this.inputdateDataGridViewTextBoxColumn.DataPropertyName = "inputdate";
            this.inputdateDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.inputdateDataGridViewTextBoxColumn.Name = "inputdateDataGridViewTextBoxColumn";
            this.inputdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 618);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_nang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cao);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "info";
            this.Text = "info";
            this.Load += new System.EventHandler(this.info_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label frm2lbl;
        private System.Windows.Forms.TextBox txt_cao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SKDataSet sKDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private SKDataSetTableAdapters.InfoTableAdapter infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_input;
    }
}