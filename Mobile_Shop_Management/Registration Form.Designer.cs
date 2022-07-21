namespace Mobile_Shop_Management
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.passTbox = new System.Windows.Forms.TextBox();
            this.UsernameTbox = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(52, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.passlbl.Location = new System.Drawing.Point(86, 252);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(106, 29);
            this.passlbl.TabIndex = 18;
            this.passlbl.Text = "Password";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.userlbl.Location = new System.Drawing.Point(108, 149);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(62, 29);
            this.userlbl.TabIndex = 17;
            this.userlbl.Text = "User ";
            // 
            // passTbox
            // 
            this.passTbox.Location = new System.Drawing.Point(198, 256);
            this.passTbox.Name = "passTbox";
            this.passTbox.Size = new System.Drawing.Size(149, 26);
            this.passTbox.TabIndex = 16;
            // 
            // UsernameTbox
            // 
            this.UsernameTbox.Location = new System.Drawing.Point(198, 149);
            this.UsernameTbox.Name = "UsernameTbox";
            this.UsernameTbox.Size = new System.Drawing.Size(149, 26);
            this.UsernameTbox.TabIndex = 15;
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regBtn.Location = new System.Drawing.Point(116, 439);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(244, 54);
            this.regBtn.TabIndex = 21;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 505);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.passTbox);
            this.Controls.Add(this.UsernameTbox);
            this.Name = "Registration_Form";
            this.Text = "Registration_Form";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.TextBox passTbox;
        private System.Windows.Forms.TextBox UsernameTbox;
        private System.Windows.Forms.Button regBtn;
    }
}