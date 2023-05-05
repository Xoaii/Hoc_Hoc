namespace Dua_xe_cuc_manh
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
                ///u67rt76t8ytyo76r76yty987r76uyo7fdt7r6hbiuhiuiugi
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
            this.Đua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Đua
            // 
            this.Đua.BackColor = System.Drawing.Color.Transparent;
            this.Đua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Đua.Location = new System.Drawing.Point(211, 0);
            this.Đua.Name = "Đua";
            this.Đua.Size = new System.Drawing.Size(116, 47);
            this.Đua.TabIndex = 0;
            this.Đua.Text = "Đua\r\n";
            this.Đua.UseVisualStyleBackColor = false;
            this.Đua.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Dua_xe_cuc_manh.Properties.Resources.cuoiiaHUY;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Dua_xe_cuc_manh.Properties.Resources.f_race_track_start_finish_f_race_track_start_finish_asphalt_road_background_135909190;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Đua);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Đua;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

