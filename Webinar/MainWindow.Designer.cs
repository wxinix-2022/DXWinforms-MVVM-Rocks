namespace Webinar
{
    partial class MainWindow
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
            this.trackListView1 = new Webinar.Views.TrackListView();
            this.SuspendLayout();
            // 
            // trackListView1
            // 
            this.trackListView1.Location = new System.Drawing.Point(38, 92);
            this.trackListView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trackListView1.Name = "trackListView1";
            this.trackListView1.Size = new System.Drawing.Size(1155, 706);
            this.trackListView1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 911);
            this.Controls.Add(this.trackListView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private Views.TrackListView trackListView1;
    }
}

