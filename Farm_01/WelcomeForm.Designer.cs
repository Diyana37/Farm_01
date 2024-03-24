namespace Farm_01
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.continue_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.BackColor = System.Drawing.Color.Coral;
            this.welcome_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcome_lbl.Location = new System.Drawing.Point(75, 73);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(617, 40);
            this.welcome_lbl.TabIndex = 0;
            this.welcome_lbl.Text = "ДОБРЕ ДОШЛИ В НАШАТА ФЕРМА!";
            // 
            // continue_btn
            // 
            this.continue_btn.BackColor = System.Drawing.Color.Coral;
            this.continue_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.continue_btn.Location = new System.Drawing.Point(12, 398);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(150, 65);
            this.continue_btn.TabIndex = 1;
            this.continue_btn.Text = "Продължи";
            this.continue_btn.UseVisualStyleBackColor = false;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Coral;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_btn.Location = new System.Drawing.Point(618, 398);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(150, 65);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Изход";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 475);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.welcome_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeForm";
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Button continue_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

