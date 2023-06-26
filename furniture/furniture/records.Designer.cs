
namespace furniture
{
    partial class records
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
            this.itemTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funiture_DBDataSet1 = new furniture.Funiture_DBDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.item_TBTableAdapter = new furniture.Funiture_DBDataSet1TableAdapters.Item_TBTableAdapter();
            this.dgvtrans = new System.Windows.Forms.DataGridView();
            this.funiture_DBDataSet2 = new furniture.Funiture_DBDataSet2();
            this.transactionTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaction_TBTableAdapter = new furniture.Funiture_DBDataSet2TableAdapters.Transaction_TBTableAdapter();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrntyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funiture_DBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funiture_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemTBBindingSource
            // 
            this.itemTBBindingSource.DataMember = "Item_TB";
            this.itemTBBindingSource.DataSource = this.funiture_DBDataSet1;
            // 
            // funiture_DBDataSet1
            // 
            this.funiture_DBDataSet1.DataSetName = "Funiture_DBDataSet1";
            this.funiture_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 56);
            this.panel1.TabIndex = 72;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Crimson;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Close.Location = new System.Drawing.Point(916, 9);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(39, 39);
            this.btn_Close.TabIndex = 69;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // item_TBTableAdapter
            // 
            this.item_TBTableAdapter.ClearBeforeFill = true;
            // 
            // dgvtrans
            // 
            this.dgvtrans.AllowUserToAddRows = false;
            this.dgvtrans.AllowUserToDeleteRows = false;
            this.dgvtrans.AutoGenerateColumns = false;
            this.dgvtrans.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customernameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.warrntyDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvtrans.DataSource = this.transactionTBBindingSource;
            this.dgvtrans.Location = new System.Drawing.Point(12, 72);
            this.dgvtrans.Name = "dgvtrans";
            this.dgvtrans.ReadOnly = true;
            this.dgvtrans.RowHeadersWidth = 51;
            this.dgvtrans.RowTemplate.Height = 24;
            this.dgvtrans.Size = new System.Drawing.Size(944, 401);
            this.dgvtrans.TabIndex = 74;
            // 
            // funiture_DBDataSet2
            // 
            this.funiture_DBDataSet2.DataSetName = "Funiture_DBDataSet2";
            this.funiture_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTBBindingSource
            // 
            this.transactionTBBindingSource.DataMember = "Transaction_TB";
            this.transactionTBBindingSource.DataSource = this.funiture_DBDataSet2;
            // 
            // transaction_TBTableAdapter
            // 
            this.transaction_TBTableAdapter.ClearBeforeFill = true;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "Customername";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "Customername";
            this.customernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unitprice";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "unitprice";
            this.unitpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            this.unitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // warrntyDataGridViewTextBoxColumn
            // 
            this.warrntyDataGridViewTextBoxColumn.DataPropertyName = "warrnty";
            this.warrntyDataGridViewTextBoxColumn.HeaderText = "warrnty";
            this.warrntyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warrntyDataGridViewTextBoxColumn.Name = "warrntyDataGridViewTextBoxColumn";
            this.warrntyDataGridViewTextBoxColumn.ReadOnly = true;
            this.warrntyDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 485);
            this.Controls.Add(this.dgvtrans);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "records";
            this.Load += new System.EventHandler(this.records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funiture_DBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funiture_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource itemTBBindingSource;
        private Funiture_DBDataSet1 funiture_DBDataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private Funiture_DBDataSet1TableAdapters.Item_TBTableAdapter item_TBTableAdapter;
        public System.Windows.Forms.DataGridView dgvtrans;
        private Funiture_DBDataSet2 funiture_DBDataSet2;
        private System.Windows.Forms.BindingSource transactionTBBindingSource;
        private Funiture_DBDataSet2TableAdapters.Transaction_TBTableAdapter transaction_TBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrntyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}