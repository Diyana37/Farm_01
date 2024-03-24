namespace Farm_01
{
    partial class DeleteAnimalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAnimalForm));
            this.back_btn = new System.Windows.Forms.Button();
            this.cow_pic = new System.Windows.Forms.PictureBox();
            this.goat_pic = new System.Windows.Forms.PictureBox();
            this.sheep_pic = new System.Windows.Forms.PictureBox();
            this.chicken_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cow_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheep_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn.Location = new System.Drawing.Point(622, 348);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(135, 61);
            this.back_btn.TabIndex = 12;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // cow_pic
            // 
            this.cow_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cow_pic.Image = global::Farm_01.Properties.Resources._1000_F_177259529_k2fT0kp73flTWQRoWbRmYgf63yibPW7z;
            this.cow_pic.Location = new System.Drawing.Point(291, 28);
            this.cow_pic.Name = "cow_pic";
            this.cow_pic.Size = new System.Drawing.Size(148, 94);
            this.cow_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cow_pic.TabIndex = 11;
            this.cow_pic.TabStop = false;
            this.cow_pic.Click += new System.EventHandler(this.cow_pic_Click);
            // 
            // goat_pic
            // 
            this.goat_pic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.goat_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goat_pic.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.goat_pic.Image = global::Farm_01.Properties.Resources.cute_goat_farm_animal_character_animals_vector_;
            this.goat_pic.Location = new System.Drawing.Point(45, 28);
            this.goat_pic.Name = "goat_pic";
            this.goat_pic.Size = new System.Drawing.Size(147, 94);
            this.goat_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goat_pic.TabIndex = 10;
            this.goat_pic.TabStop = false;
            this.goat_pic.UseWaitCursor = true;
            this.goat_pic.Click += new System.EventHandler(this.goat_pic_Click);
            // 
            // sheep_pic
            // 
            this.sheep_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sheep_pic.Image = global::Farm_01.Properties.Resources.hqdefa11ult;
            this.sheep_pic.Location = new System.Drawing.Point(292, 200);
            this.sheep_pic.Name = "sheep_pic";
            this.sheep_pic.Size = new System.Drawing.Size(147, 94);
            this.sheep_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sheep_pic.TabIndex = 19;
            this.sheep_pic.TabStop = false;
            this.sheep_pic.Click += new System.EventHandler(this.sheep_pic_Click);
            // 
            // chicken_pic
            // 
            this.chicken_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chicken_pic.Image = global::Farm_01.Properties.Resources.ef7902f714f3eaf13bb21d7e6bb655e4;
            this.chicken_pic.Location = new System.Drawing.Point(45, 200);
            this.chicken_pic.Name = "chicken_pic";
            this.chicken_pic.Size = new System.Drawing.Size(147, 94);
            this.chicken_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chicken_pic.TabIndex = 17;
            this.chicken_pic.TabStop = false;
            this.chicken_pic.Click += new System.EventHandler(this.chicken_pic_Click);
            // 
            // DeleteAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_01.Properties.Resources._50881797506_176f3d534f_z;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sheep_pic);
            this.Controls.Add(this.chicken_pic);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.cow_pic);
            this.Controls.Add(this.goat_pic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteAnimalForm";
            this.Text = "DeleteAnimalForm";
            ((System.ComponentModel.ISupportInitialize)(this.cow_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheep_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox cow_pic;
        private System.Windows.Forms.PictureBox goat_pic;
        private System.Windows.Forms.PictureBox sheep_pic;
        private System.Windows.Forms.PictureBox chicken_pic;
    }
}