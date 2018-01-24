namespace TexasHoldEmPoker
{
    partial class WinWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinWindow));
            this.winBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.winBox)).BeginInit();
            this.SuspendLayout();
            // 
            // winBox
            // 
            this.winBox.BackColor = System.Drawing.Color.SandyBrown;
            this.winBox.Image = ((System.Drawing.Image)(resources.GetObject("winBox.Image")));
            this.winBox.Location = new System.Drawing.Point(0, 0);
            this.winBox.Name = "winBox";
            this.winBox.Size = new System.Drawing.Size(309, 172);
            this.winBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.winBox.TabIndex = 1;
            this.winBox.TabStop = false;
            // 
            // WinWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 171);
            this.Controls.Add(this.winBox);
            this.Name = "WinWindow";
            this.Text = "WinWindow";
            ((System.ComponentModel.ISupportInitialize)(this.winBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox winBox;
    }
}