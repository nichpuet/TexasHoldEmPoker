namespace TexasHoldEmPoker
{
    partial class LoseWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoseWindow));
            this.lossBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lossBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lossBox
            // 
            this.lossBox.BackColor = System.Drawing.Color.SandyBrown;
            this.lossBox.Image = ((System.Drawing.Image)(resources.GetObject("lossBox.Image")));
            this.lossBox.Location = new System.Drawing.Point(-1, 1);
            this.lossBox.Name = "lossBox";
            this.lossBox.Size = new System.Drawing.Size(309, 172);
            this.lossBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lossBox.TabIndex = 0;
            this.lossBox.TabStop = false;
            // 
            // LoseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 170);
            this.Controls.Add(this.lossBox);
            this.Name = "LoseWindow";
            this.Text = "LoseWindow";
            ((System.ComponentModel.ISupportInitialize)(this.lossBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lossBox;
    }
}