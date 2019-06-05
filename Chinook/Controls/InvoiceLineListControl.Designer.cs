namespace Chinook.Controls
{
    partial class InvoiceLineListControl
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
            this.bdsInvoiceLine = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceLineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoiceLine)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrack
            // 
            this.dgvTrack.AutoGenerateColumns = false;
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceLineIdDataGridViewTextBoxColumn,
            this.invoiceIdDataGridViewTextBoxColumn,
            this.TrackName,
            this.ArtistName,
            this.trackIdDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvTrack.DataSource = this.bdsInvoiceLine;
            this.dgvTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrack.Location = new System.Drawing.Point(0, 0);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.RowTemplate.Height = 23;
            this.dgvTrack.Size = new System.Drawing.Size(556, 296);
            this.dgvTrack.TabIndex = 6;
            // 
            // bdsInvoiceLine
            // 
            this.bdsInvoiceLine.DataSource = typeof(Chinook.Data.InvoiceLine);
            // 
            // invoiceLineIdDataGridViewTextBoxColumn
            // 
            this.invoiceLineIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceLineId";
            this.invoiceLineIdDataGridViewTextBoxColumn.HeaderText = "InvoiceLineId";
            this.invoiceLineIdDataGridViewTextBoxColumn.Name = "invoiceLineIdDataGridViewTextBoxColumn";
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // TrackName
            // 
            this.TrackName.DataPropertyName = "TrackName";
            this.TrackName.HeaderText = "TrackName";
            this.TrackName.Name = "TrackName";
            this.TrackName.ReadOnly = true;
            // 
            // ArtistName
            // 
            this.ArtistName.DataPropertyName = "ArtistName";
            this.ArtistName.HeaderText = "ArtistName";
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.ReadOnly = true;
            // 
            // trackIdDataGridViewTextBoxColumn
            // 
            this.trackIdDataGridViewTextBoxColumn.DataPropertyName = "TrackId";
            this.trackIdDataGridViewTextBoxColumn.HeaderText = "TrackId";
            this.trackIdDataGridViewTextBoxColumn.Name = "trackIdDataGridViewTextBoxColumn";
            this.trackIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // InvoiceLineListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTrack);
            this.Name = "InvoiceLineListControl";
            this.Size = new System.Drawing.Size(556, 296);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoiceLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.BindingSource bdsInvoiceLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceLineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}
