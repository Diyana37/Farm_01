namespace Farm_01
{
    partial class AnimalsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalsForm));
            this.addAnimal_btn = new System.Windows.Forms.Button();
            this.goat_lbl = new System.Windows.Forms.Label();
            this.cow_lbl = new System.Windows.Forms.Label();
            this.cow_pic = new System.Windows.Forms.PictureBox();
            this.goat_pic = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.chicken_pic = new System.Windows.Forms.PictureBox();
            this.chicken_lbl = new System.Windows.Forms.Label();
            this.sheep_lbl = new System.Windows.Forms.Label();
            this.sheep_pic = new System.Windows.Forms.PictureBox();
            this.references_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cow_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheep_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // addAnimal_btn
            // 
            this.addAnimal_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addAnimal_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addAnimal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnimal_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addAnimal_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addAnimal_btn.Location = new System.Drawing.Point(32, 368);
            this.addAnimal_btn.Name = "addAnimal_btn";
            this.addAnimal_btn.Size = new System.Drawing.Size(135, 61);
            this.addAnimal_btn.TabIndex = 0;
            this.addAnimal_btn.Text = "Добави животно";
            this.addAnimal_btn.UseVisualStyleBackColor = false;
            this.addAnimal_btn.Click += new System.EventHandler(this.addAnimal_btn_Click);
            // 
            // goat_lbl
            // 
            this.goat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goat_lbl.Location = new System.Drawing.Point(67, 133);
            this.goat_lbl.Name = "goat_lbl";
            this.goat_lbl.Size = new System.Drawing.Size(100, 23);
            this.goat_lbl.TabIndex = 2;
            this.goat_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cow_lbl
            // 
            this.cow_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cow_lbl.Location = new System.Drawing.Point(315, 133);
            this.cow_lbl.Name = "cow_lbl";
            this.cow_lbl.Size = new System.Drawing.Size(100, 23);
            this.cow_lbl.TabIndex = 4;
            this.cow_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cow_pic
            // 
            this.cow_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cow_pic.Image = global::Farm_01.Properties.Resources._11;
            this.cow_pic.Location = new System.Drawing.Point(292, 22);
            this.cow_pic.Name = "cow_pic";
            this.cow_pic.Size = new System.Drawing.Size(147, 94);
            this.cow_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cow_pic.TabIndex = 3;
            this.cow_pic.TabStop = false;
            // 
            // goat_pic
            // 
            this.goat_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goat_pic.Image = global::Farm_01.Properties.Resources.cute_goat_farm_animal_character_animals_vector_1;
            this.goat_pic.Location = new System.Drawing.Point(45, 22);
            this.goat_pic.Name = "goat_pic";
            this.goat_pic.Size = new System.Drawing.Size(147, 94);
            this.goat_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goat_pic.TabIndex = 1;
            this.goat_pic.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn.Location = new System.Drawing.Point(626, 368);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(135, 61);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.refresh_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refresh_btn.Location = new System.Drawing.Point(626, 46);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(135, 61);
            this.refresh_btn.TabIndex = 6;
            this.refresh_btn.Text = "Опресни";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete_btn.Location = new System.Drawing.Point(197, 368);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(135, 61);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "Изтрий животно";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // chicken_pic
            // 
            this.chicken_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chicken_pic.Image = global::Farm_01.Properties.Resources.ef7902f714f3eaf13bb21d7e6bb655e4;
            this.chicken_pic.Location = new System.Drawing.Point(45, 194);
            this.chicken_pic.Name = "chicken_pic";
            this.chicken_pic.Size = new System.Drawing.Size(147, 94);
            this.chicken_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chicken_pic.TabIndex = 8;
            this.chicken_pic.TabStop = false;
            // 
            // chicken_lbl
            // 
            this.chicken_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chicken_lbl.Location = new System.Drawing.Point(67, 305);
            this.chicken_lbl.Name = "chicken_lbl";
            this.chicken_lbl.Size = new System.Drawing.Size(100, 23);
            this.chicken_lbl.TabIndex = 9;
            this.chicken_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sheep_lbl
            // 
            this.sheep_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheep_lbl.Location = new System.Drawing.Point(315, 305);
            this.sheep_lbl.Name = "sheep_lbl";
            this.sheep_lbl.Size = new System.Drawing.Size(100, 23);
            this.sheep_lbl.TabIndex = 11;
            this.sheep_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sheep_pic
            // 
            this.sheep_pic.Image = global::Farm_01.Properties.Resources.hqdefa11ult;
            this.sheep_pic.Location = new System.Drawing.Point(292, 194);
            this.sheep_pic.Name = "sheep_pic";
            this.sheep_pic.Size = new System.Drawing.Size(147, 94);
            this.sheep_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sheep_pic.TabIndex = 12;
            this.sheep_pic.TabStop = false;
            // 
            // references_btn
            // 
            this.references_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.references_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.references_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.references_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.references_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.references_btn.Location = new System.Drawing.Point(626, 133);
            this.references_btn.Name = "references_btn";
            this.references_btn.Size = new System.Drawing.Size(135, 61);
            this.references_btn.TabIndex = 13;
            this.references_btn.Text = "Справки";
            this.references_btn.UseVisualStyleBackColor = false;
            this.references_btn.Click += new System.EventHandler(this.references_btn_Click);
            // 
            // AnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_01.Properties.Resources._50881797506_176f3d534f_z;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.references_btn);
            this.Controls.Add(this.sheep_pic);
            this.Controls.Add(this.sheep_lbl);
            this.Controls.Add(this.chicken_lbl);
            this.Controls.Add(this.chicken_pic);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.cow_lbl);
            this.Controls.Add(this.cow_pic);
            this.Controls.Add(this.goat_lbl);
            this.Controls.Add(this.goat_pic);
            this.Controls.Add(this.addAnimal_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalsForm";
            this.Text = "Animals";
            this.Load += new System.EventHandler(this.AnimalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cow_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheep_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAnimal_btn;
        private System.Windows.Forms.PictureBox goat_pic;
        private System.Windows.Forms.PictureBox cow_pic;
        private System.Windows.Forms.Label cow_lbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.PictureBox chicken_pic;
        private System.Windows.Forms.Label chicken_lbl;
        private System.Windows.Forms.Label sheep_lbl;
        private System.Windows.Forms.PictureBox sheep_pic;
        private System.Windows.Forms.Button references_btn;
        private System.Windows.Forms.Label goat_lbl;
    }
}