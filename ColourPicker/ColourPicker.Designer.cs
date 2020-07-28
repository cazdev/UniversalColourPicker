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
            this.BtnCopyRGB = new System.Windows.Forms.Button();
            this.MoveMouse = new System.Windows.Forms.Timer(this.components);
            this.lblRGB = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCopyHex
            // 
            this.BtnCopyHex.BackColor = System.Drawing.Color.White;
            this.BtnCopyHex.FlatAppearance.BorderSize = 0;
            this.BtnCopyHex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BtnCopyHex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BtnCopyHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopyHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopyHex.Location = new System.Drawing.Point(103, 190);
            this.BtnCopyHex.Name = "BtnCopyHex";
            this.BtnCopyHex.Size = new System.Drawing.Size(75, 37);
            this.BtnCopyHex.TabIndex = 7;
            this.BtnCopyHex.Text = "Copy";
            this.BtnCopyHex.UseVisualStyleBackColor = false;
            this.BtnCopyHex.Click += new System.EventHandler(this.BtnCopyHex_Click);
            // 
            // BtnCopyRGB
            // 
            this.BtnCopyRGB.BackColor = System.Drawing.Color.White;
            this.BtnCopyRGB.FlatAppearance.BorderSize = 0;
            this.BtnCopyRGB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BtnCopyRGB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BtnCopyRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopyRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopyRGB.Location = new System.Drawing.Point(103, 82);
            this.BtnCopyRGB.Name = "BtnCopyRGB";
            this.BtnCopyRGB.Size = new System.Drawing.Size(75, 37);
            this.BtnCopyRGB.TabIndex = 5;
            this.BtnCopyRGB.Text = "Copy";
            this.BtnCopyRGB.UseVisualStyleBackColor = false;
            this.BtnCopyRGB.Click += new System.EventHandler(this.BtnCopyRGB_Click);
            // 
            // MoveMouse
            // 
            this.MoveMouse.Enabled = true;
            this.MoveMouse.Interval = 1;
            // 
            // lblRGB
            // 
            this.lblRGB.BackColor = System.Drawing.Color.White;
            this.lblRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.Location = new System.Drawing.Point(2, 37);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(284, 42);
            this.lblRGB.TabIndex = 9;
            this.lblRGB.Text = "60,60,60";
            this.lblRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHex
            // 
            this.lblHex.BackColor = System.Drawing.Color.White;
            this.lblHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHex.Location = new System.Drawing.Point(-2, 145);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(288, 42);
            this.lblHex.TabIndex = 10;
            this.lblHex.Text = "3C3C3C";
            this.lblHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColourPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.BtnCopyHex);
            this.Controls.Add(this.BtnCopyRGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourPicker";
            this.Text = "ColourPicker";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColourPicker_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCopyHex;
        private System.Windows.Forms.Button BtnCopyRGB;
        private System.Windows.Forms.Timer MoveMouse;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Label lblHex;
    }
}

