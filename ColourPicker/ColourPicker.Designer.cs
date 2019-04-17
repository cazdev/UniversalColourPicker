namespace ColourPicker
{
    partial class ColourPicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourPicker));
            this.BtnCopyHex = new System.Windows.Forms.Button();
            this.LblHex = new System.Windows.Forms.Label();
            this.BtnCopyRGB = new System.Windows.Forms.Button();
            this.LblRGB = new System.Windows.Forms.Label();
            this.MoveMouse = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            ColourPicker.Start();
            ColourPicker.MouseAction += new System.EventHandler(Event);

            // 
            // BtnCopyHex
            // 
            this.BtnCopyHex.BackColor = System.Drawing.Color.White;
            this.BtnCopyHex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCopyHex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCopyHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopyHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopyHex.Location = new System.Drawing.Point(103, 190);
            this.BtnCopyHex.Name = "BtnCopyHex";
            this.BtnCopyHex.Size = new System.Drawing.Size(75, 31);
            this.BtnCopyHex.TabIndex = 7;
            this.BtnCopyHex.Text = "Copy";
            this.BtnCopyHex.UseVisualStyleBackColor = false;
            this.BtnCopyHex.Click += new System.EventHandler(this.BtnCopyHex_Click);
            // 
            // LblHex
            // 
            this.LblHex.BackColor = System.Drawing.Color.White;
            this.LblHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHex.Location = new System.Drawing.Point(0, 142);
            this.LblHex.Name = "LblHex";
            this.LblHex.Size = new System.Drawing.Size(284, 45);
            this.LblHex.TabIndex = 6;
            this.LblHex.Text = "FFFFFF";
            this.LblHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCopyRGB
            // 
            this.BtnCopyRGB.BackColor = System.Drawing.Color.White;
            this.BtnCopyRGB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCopyRGB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCopyRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopyRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopyRGB.Location = new System.Drawing.Point(103, 82);
            this.BtnCopyRGB.Name = "BtnCopyRGB";
            this.BtnCopyRGB.Size = new System.Drawing.Size(75, 31);
            this.BtnCopyRGB.TabIndex = 5;
            this.BtnCopyRGB.Text = "Copy";
            this.BtnCopyRGB.UseVisualStyleBackColor = false;
            this.BtnCopyRGB.Click += new System.EventHandler(this.BtnCopyRGB_Click);
            // 
            // LblRGB
            // 
            this.LblRGB.BackColor = System.Drawing.Color.White;
            this.LblRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRGB.Location = new System.Drawing.Point(0, 40);
            this.LblRGB.Name = "LblRGB";
            this.LblRGB.Size = new System.Drawing.Size(284, 39);
            this.LblRGB.TabIndex = 4;
            this.LblRGB.Text = "255, 255, 255";
            this.LblRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveMouse
            // 
            this.MoveMouse.Enabled = true;
            this.MoveMouse.Interval = 1;
            // 
            // ColourPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnCopyHex);
            this.Controls.Add(this.LblHex);
            this.Controls.Add(this.BtnCopyRGB);
            this.Controls.Add(this.LblRGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourPicker";
            this.Text = "ColourPicker";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCopyHex;
        private System.Windows.Forms.Label LblHex;
        private System.Windows.Forms.Button BtnCopyRGB;
        private System.Windows.Forms.Label LblRGB;
        private System.Windows.Forms.Timer MoveMouse;
    }
}

