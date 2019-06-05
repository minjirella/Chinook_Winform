namespace Chinook.Controls
{
    partial class InvoiceListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.bdsInvoice = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrack
            // 
            this.dgvTrack.AutoGenerateColumns = false;
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.billingAddressDataGridViewTextBoxColumn,
            this.billingCityDataGridViewTextBoxColumn,
            this.billingStateDataGridViewTextBoxColumn,
            this.billingCountryDataGridViewTextBoxColumn,
            this.billingPostalCodeDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvTrack.DataSource = this.bdsInvoice;
            this.dgvTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrack.Location = new System.Drawing.Point(0, 0);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.RowTemplate.Height = 23;
            this.dgvTrack.Size = new System.Drawing.Size(541, 295);
            this.dgvTrack.TabIndex = 5;
            // 
            // bdsInvoice
            // 
            this.bdsInvoice.DataSource = typeof(Chinook.Data.Invoice);
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            // 
            // billingAddressDataGridViewTextBoxColumn
            // 
            this.billingAddressDataGridViewTextBoxColumn.DataPropertyName = "BillingAddress";
            this.billingAddressDataGridViewTextBoxColumn.HeaderText = "BillingAddress";
            this.billingAddressDataGridViewTextBoxColumn.Name = "billingAddressDataGridViewTextBoxColumn";
            // 
            // billingCityDataGridViewTextBoxColumn
            // 
            this.billingCityDataGridViewTextBoxColumn.DataPropertyName = "BillingCity";
            this.billingCityDataGridViewTextBoxColumn.HeaderText = "BillingCity";
            this.billingCityDataGridViewTextBoxColumn.Name = "billingCityDataGridViewTextBoxColumn";
            // 
            // billingStateDataGridViewTextBoxColumn
            // 
            this.billingStateDataGridViewTextBoxColumn.DataPropertyName = "BillingState";
            this.billingStateDataGridViewTextBoxColumn.HeaderText = "BillingState";
            this.billingStateDataGridViewTextBoxColumn.Name = "billingStateDataGridViewTextBoxColumn";
            // 
            // billingCountryDataGridViewTextBoxColumn
            // 
            this.billingCountryDataGridViewTextBoxColumn.DataPropertyName = "BillingCountry";
            this.billingCountryDataGridViewTextBoxColumn.HeaderText = "BillingCountry";
            this.billingCountryDataGridViewTextBoxColumn.Name = "billingCountryDataGridViewTextBoxColumn";
            // 
            // billingPostalCodeDataGridViewTextBoxColumn
            // 
            this.billingPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "BillingPostalCode";
            this.billingPostalCodeDataGridViewTextBoxColumn.HeaderText = "BillingPostalCode";
            this.billingPostalCodeDataGridViewTextBoxColumn.Name = "billingPostalCodeDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // InvoiceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTrack);
            this.Name = "InvoiceListControl";
            this.Size = new System.Drawing.Size(541, 295);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.BindingSource bdsInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}
