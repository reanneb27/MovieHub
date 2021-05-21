
namespace MovieHub
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Profile = new System.Windows.Forms.PictureBox();
            this.btn_Search = new System.Windows.Forms.PictureBox();
            this.link_SignOut = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::MovieHub.Properties.Resources.movie_hub_logo_badge___orig;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Profile
            // 
            this.btn_Profile.Image = global::MovieHub.Properties.Resources.profile_icon_png_898;
            this.btn_Profile.Location = new System.Drawing.Point(931, 75);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(41, 37);
            this.btn_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Profile.TabIndex = 27;
            this.btn_Profile.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Image = global::MovieHub.Properties.Resources.search_icon;
            this.btn_Search.Location = new System.Drawing.Point(874, 75);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(41, 37);
            this.btn_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Search.TabIndex = 27;
            this.btn_Search.TabStop = false;
            // 
            // link_SignOut
            // 
            this.link_SignOut.AutoSize = true;
            this.link_SignOut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.link_SignOut.LinkColor = System.Drawing.Color.Red;
            this.link_SignOut.Location = new System.Drawing.Point(902, 126);
            this.link_SignOut.Name = "link_SignOut";
            this.link_SignOut.Size = new System.Drawing.Size(70, 18);
            this.link_SignOut.TabIndex = 28;
            this.link_SignOut.TabStop = true;
            this.link_SignOut.Text = "Sign Out";
            this.link_SignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_SignOut_LinkClicked);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.link_SignOut);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Profile);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Hub";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_Profile;
        private System.Windows.Forms.PictureBox btn_Search;
        private System.Windows.Forms.LinkLabel link_SignOut;
    }
}