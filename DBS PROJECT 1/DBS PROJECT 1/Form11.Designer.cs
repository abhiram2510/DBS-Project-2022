namespace DBS_PROJECT_1
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet4 = new DBS_PROJECT_1.DataSet4();
            this.fEEDBACKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fEEDBACKTableAdapter = new DBS_PROJECT_1.DataSet4TableAdapters.FEEDBACKTableAdapter();
            this.pHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEEDBACKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUGGESTIONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEEDBACKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pHONENODataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.fEEDBACKDataGridViewTextBoxColumn,
            this.sUGGESTIONSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fEEDBACKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(217, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fEEDBACKBindingSource
            // 
            this.fEEDBACKBindingSource.DataMember = "FEEDBACK";
            this.fEEDBACKBindingSource.DataSource = this.dataSet4;
            // 
            // fEEDBACKTableAdapter
            // 
            this.fEEDBACKTableAdapter.ClearBeforeFill = true;
            // 
            // pHONENODataGridViewTextBoxColumn
            // 
            this.pHONENODataGridViewTextBoxColumn.DataPropertyName = "PHONENO";
            this.pHONENODataGridViewTextBoxColumn.HeaderText = "PHONENO";
            this.pHONENODataGridViewTextBoxColumn.Name = "pHONENODataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // fEEDBACKDataGridViewTextBoxColumn
            // 
            this.fEEDBACKDataGridViewTextBoxColumn.DataPropertyName = "FEEDBACK";
            this.fEEDBACKDataGridViewTextBoxColumn.HeaderText = "FEEDBACK";
            this.fEEDBACKDataGridViewTextBoxColumn.Name = "fEEDBACKDataGridViewTextBoxColumn";
            // 
            // sUGGESTIONSDataGridViewTextBoxColumn
            // 
            this.sUGGESTIONSDataGridViewTextBoxColumn.DataPropertyName = "SUGGESTIONS";
            this.sUGGESTIONSDataGridViewTextBoxColumn.HeaderText = "SUGGESTIONS";
            this.sUGGESTIONSDataGridViewTextBoxColumn.Name = "sUGGESTIONSDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feedback is the key to improvement.\r\nLet\'s listen, learn and grow together.";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form11";
            this.Text = "ViewFeedback";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEEDBACKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource fEEDBACKBindingSource;
        private DataSet4TableAdapters.FEEDBACKTableAdapter fEEDBACKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEEDBACKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUGGESTIONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}