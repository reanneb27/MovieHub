
namespace MovieHub
{
    partial class SignUpForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm3));
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Visa = new System.Windows.Forms.PictureBox();
            this.btn_MasterCard = new System.Windows.Forms.PictureBox();
            this.link_Back = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Visa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MasterCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(220, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Step 3 of 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::MovieHub.Properties.Resources.movie_hub_logo_badge___orig;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Setup your payment";
            // 
            // btn_Visa
            // 
            this.btn_Visa.Image = global::MovieHub.Properties.Resources.visa_PNG10;
            this.btn_Visa.Location = new System.Drawing.Point(136, 230);
            this.btn_Visa.Name = "btn_Visa";
            this.btn_Visa.Size = new System.Drawing.Size(111, 94);
            this.btn_Visa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Visa.TabIndex = 28;
            this.btn_Visa.TabStop = false;
            this.btn_Visa.Click += new System.EventHandler(this.btn_Visa_Click);
            // 
            // btn_MasterCard
            // 
            this.btn_MasterCard.Image = global::MovieHub.Properties.Resources.Master_Card_Blue_icon;
            this.btn_MasterCard.Location = new System.Drawing.Point(283, 230);
            this.btn_MasterCard.Name = "btn_MasterCard";
            this.btn_MasterCard.Size = new System.Drawing.Size(111, 94);
            this.btn_MasterCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_MasterCard.TabIndex = 28;
            this.btn_MasterCard.TabStop = false;
            this.btn_MasterCard.Click += new System.EventHandler(this.btn_MasterCard_Click);
            // 
            // link_Back
            // 
            this.link_Back.AutoSize = true;
            this.link_Back.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.link_Back.LinkColor = System.Drawing.Color.Red;
            this.link_Back.Location = new System.Drawing.Point(28, 87);
            this.link_Back.Name = "link_Back";
            this.link_Back.Size = new System.Drawing.Size(50, 18);
            this.link_Back.TabIndex = 29;
            this.link_Back.TabStop = true;
            this.link_Back.Text = "BACK";
            this.link_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Back_LinkClicked);
            // 
            // SignUpForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(534, 433);
            this.Controls.Add(this.link_Back);
            this.Controls.Add(this.btn_MasterCard);
            this.Controls.Add(this.btn_Visa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Hub | Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Visa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MasterCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_Visa;
        private System.Windows.Forms.PictureBox btn_MasterCard;
        private System.Windows.Forms.LinkLabel link_Back;
    }
}