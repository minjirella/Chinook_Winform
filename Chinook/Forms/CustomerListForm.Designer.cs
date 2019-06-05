namespace Chinook.Forms
{
    partial class CustomerListForm
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
            this.uscCustomerList = new Chinook.Controls.CustomerListControl();
            this.uscCustomerSearch = new Chinook.Controls.CustomerSearchControl();
            this.SuspendLayout();
            // 
            // uscCustomerList
            // 
            this.uscCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscCustomerList.Location = new System.Drawing.Point(0, 91);
            this.uscCustomerList.Name = "uscCustomerList";
            this.uscCustomerList.Size = new System.Drawing.Size(494, 323);
            this.uscCustomerList.TabIndex = 0;
            // 
            // uscCustomerSearch
            // 
            this.uscCustomerSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscCustomerSearch.Location = new System.Drawing.Point(0, 0);
            this.uscCustomerSearch.Name = "uscCustomerSearch";
            this.uscCustomerSearch.Size = new System.Drawing.Size(494, 91);
            this.uscCustomerSearch.TabIndex = 1;
            this.uscCustomerSearch.SearchButtonClicked += new System.EventHandler<Chinook.Controls.CustomerSearchControl.SearchButtonClickedEventArgs>(this.UscCustomerSearch_SearchButtonClicked);
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 414);
            this.Controls.Add(this.uscCustomerList);
            this.Controls.Add(this.uscCustomerSearch);
            this.Name = "CustomerListForm";
            this.Text = "CustomerListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomerListControl uscCustomerList;
        private Controls.CustomerSearchControl uscCustomerSearch;
    }
}