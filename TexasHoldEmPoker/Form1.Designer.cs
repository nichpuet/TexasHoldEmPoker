namespace TexasHoldEmPoker
{
    partial class Poker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poker));
            this.titleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.optionButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.foldButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.betButton = new System.Windows.Forms.Button();
            this.balLabel = new System.Windows.Forms.Label();
            this.exit2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(318, 58);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(112, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Texas Hold \'Em Poker";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(333, 148);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // optionButton
            // 
            this.optionButton.Location = new System.Drawing.Point(333, 209);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(75, 23);
            this.optionButton.TabIndex = 2;
            this.optionButton.Text = "Options";
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.Click += new System.EventHandler(this.optionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(333, 268);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 600);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(100, 50);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Visible = false;
            // 
            // foldButton
            // 
            this.foldButton.Location = new System.Drawing.Point(622, 600);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(100, 50);
            this.foldButton.TabIndex = 6;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = true;
            this.foldButton.Visible = false;
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(12, 510);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(100, 50);
            this.callButton.TabIndex = 7;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Visible = false;
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(622, 510);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(100, 50);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Visible = false;
            // 
            // balLabel
            // 
            this.balLabel.AutoSize = true;
            this.balLabel.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balLabel.Location = new System.Drawing.Point(13, 13);
            this.balLabel.Name = "balLabel";
            this.balLabel.Size = new System.Drawing.Size(81, 19);
            this.balLabel.TabIndex = 10;
            this.balLabel.Text = "Balance:";
            this.balLabel.Visible = false;
            // 
            // exit2Button
            // 
            this.exit2Button.Location = new System.Drawing.Point(622, 13);
            this.exit2Button.Name = "exit2Button";
            this.exit2Button.Size = new System.Drawing.Size(100, 25);
            this.exit2Button.TabIndex = 11;
            this.exit2Button.Text = "Exit";
            this.exit2Button.UseVisualStyleBackColor = true;
            this.exit2Button.Visible = false;
            this.exit2Button.Click += new System.EventHandler(this.exit2Button_Click);
            // 
            // Poker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.exit2Button);
            this.Controls.Add(this.balLabel);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.foldButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Poker";
            this.Text = "Texas Hold \'Em Poker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button optionButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button foldButton;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label balLabel;
        private System.Windows.Forms.Button exit2Button;
    }
}

