
namespace Demo_ADO_NET_DATAGRID
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.freshers_Training2022DataSet = new Demo_ADO_NET_DATAGRID.Freshers_Training2022DataSet();
            this.khushbooempolyeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khushboo_empolyeeTableAdapter = new Demo_ADO_NET_DATAGRID.Freshers_Training2022DataSetTableAdapters.khushboo_empolyeeTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freshers_Training2022DataSet1 = new Demo_ADO_NET_DATAGRID.Freshers_Training2022DataSet1();
            this.kbWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kb_WorkerTableAdapter = new Demo_ADO_NET_DATAGRID.Freshers_Training2022DataSet1TableAdapters.kb_WorkerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khushbooempolyeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbWorkerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fill Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // freshers_Training2022DataSet
            // 
            this.freshers_Training2022DataSet.DataSetName = "Freshers_Training2022DataSet";
            this.freshers_Training2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khushbooempolyeeBindingSource
            // 
            this.khushbooempolyeeBindingSource.DataMember = "khushboo_empolyee";
            this.khushbooempolyeeBindingSource.DataSource = this.freshers_Training2022DataSet;
            // 
            // khushboo_empolyeeTableAdapter
            // 
            this.khushboo_empolyeeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.kbWorkerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(380, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(408, 344);
            this.dataGridView2.TabIndex = 2;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // freshers_Training2022DataSet1
            // 
            this.freshers_Training2022DataSet1.DataSetName = "Freshers_Training2022DataSet1";
            this.freshers_Training2022DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kbWorkerBindingSource
            // 
            this.kbWorkerBindingSource.DataMember = "kb_Worker";
            this.kbWorkerBindingSource.DataSource = this.freshers_Training2022DataSet1;
            // 
            // kb_WorkerTableAdapter
            // 
            this.kb_WorkerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khushbooempolyeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbWorkerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Freshers_Training2022DataSet freshers_Training2022DataSet;
        private System.Windows.Forms.BindingSource khushbooempolyeeBindingSource;
        private Freshers_Training2022DataSetTableAdapters.khushboo_empolyeeTableAdapter khushboo_empolyeeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private Freshers_Training2022DataSet1 freshers_Training2022DataSet1;
        private System.Windows.Forms.BindingSource kbWorkerBindingSource;
        private Freshers_Training2022DataSet1TableAdapters.kb_WorkerTableAdapter kb_WorkerTableAdapter;
    }
}

