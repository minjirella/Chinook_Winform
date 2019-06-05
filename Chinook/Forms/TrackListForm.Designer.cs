﻿namespace Chinook.Forms
{
    partial class TrackListForm
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
            this.uscTrackSearch = new Chinook.Controls.TrackSearchControl();
            this.uscTrackList = new Chinook.Controls.TrackListCotrol();
            this.SuspendLayout();
            // 
            // uscTrackSearch
            // 
            this.uscTrackSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscTrackSearch.Location = new System.Drawing.Point(0, 0);
            this.uscTrackSearch.Name = "uscTrackSearch";
            this.uscTrackSearch.Size = new System.Drawing.Size(800, 88);
            this.uscTrackSearch.TabIndex = 0;
            this.uscTrackSearch.SearchButtonClicked += new System.EventHandler<Chinook.Controls.TrackSearchControl.SearchButtonClickedEventArgs>(this.UscTrackSearch_SearchButtonClicked);
            // 
            // uscTrackList
            // 
            this.uscTrackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTrackList.Location = new System.Drawing.Point(0, 88);
            this.uscTrackList.Name = "uscTrackList";
            this.uscTrackList.Size = new System.Drawing.Size(800, 362);
            this.uscTrackList.TabIndex = 1;
            // 
            // TrackListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uscTrackList);
            this.Controls.Add(this.uscTrackSearch);
            this.Name = "TrackListForm";
            this.Text = "TrackListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TrackSearchControl uscTrackSearch;
        private Controls.TrackListCotrol uscTrackList;
    }
}