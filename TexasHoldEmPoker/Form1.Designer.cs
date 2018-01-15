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
            this.optionLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.p1Card1 = new System.Windows.Forms.PictureBox();
            this.p1Card2 = new System.Windows.Forms.PictureBox();
            this.flopCard1 = new System.Windows.Forms.PictureBox();
            this.flopCard2 = new System.Windows.Forms.PictureBox();
            this.flopCard3 = new System.Windows.Forms.PictureBox();
            this.turnCard = new System.Windows.Forms.PictureBox();
            this.riverCard = new System.Windows.Forms.PictureBox();
            this.potLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p1Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riverCard)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Rosewood Std Regular", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(184, 59);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(389, 43);
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
            this.optionButton.Location = new System.Drawing.Point(333, 206);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(75, 23);
            this.optionButton.TabIndex = 2;
            this.optionButton.Text = "Options";
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.Click += new System.EventHandler(this.optionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(333, 264);
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
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.optionLabel.Location = new System.Drawing.Point(273, 235);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(193, 13);
            this.optionLabel.TabIndex = 12;
            this.optionLabel.Text = "There currently are no available options";
            this.optionLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(333, 264);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // p1Card1
            // 
            this.p1Card1.Image = global::TexasHoldEmPoker.Properties.Resources.CardBack;
            this.p1Card1.Location = new System.Drawing.Point(260, 325);
            this.p1Card1.Name = "p1Card1";
            this.p1Card1.Size = new System.Drawing.Size(113, 165);
            this.p1Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Card1.TabIndex = 14;
            this.p1Card1.TabStop = false;
            this.p1Card1.Visible = false;
            // 
            // p1Card2
            // 
            this.p1Card2.Image = global::TexasHoldEmPoker.Properties.Resources.CardBack;
            this.p1Card2.Location = new System.Drawing.Point(379, 325);
            this.p1Card2.Name = "p1Card2";
            this.p1Card2.Size = new System.Drawing.Size(113, 165);
            this.p1Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Card2.TabIndex = 15;
            this.p1Card2.TabStop = false;
            this.p1Card2.Visible = false;
            // 
            // flopCard1
            // 
            this.flopCard1.Image = global::TexasHoldEmPoker.Properties.Resources.CardBack;
            this.flopCard1.Location = new System.Drawing.Point(182, 166);
            this.flopCard1.Name = "flopCard1";
            this.flopCard1.Size = new System.Drawing.Size(72, 104);
            this.flopCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flopCard1.TabIndex = 16;
            this.flopCard1.TabStop = false;
            this.flopCard1.Visible = false;
            // 
            // flopCard2
            // 
            this.flopCard2.Image = global::TexasHoldEmPoker.Properties.Resources.CardBack;
            this.flopCard2.Location = new System.Drawing.Point(260, 166);
            this.flopCard2.Name = "flopCard2";
            this.flopCard2.Size = new System.Drawing.Size(72, 104);
            this.flopCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flopCard2.TabIndex = 17;
            this.flopCard2.TabStop = false;
            this.flopCard2.Visible = false;
            // 
            // flopCard3
            // 
            this.flopCard3.Image = global::TexasHoldEmPoker.Properties.Resources.CardBack;
            this.flopCard3.Location = new System.Drawing.Point(338, 166);
            this.flopCard3.Name = "flopCard3";
            this.flopCard3.Size = new System.Drawing.Size(72, 104);
            this.flopCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flopCard3.TabIndex = 18;
            this.flopCard3.TabStop = false;
            this.flopCard3.Visible = false;
            // 
            // turnCard
            // 
            this.turnCard.Image = global::TexasHoldEmPoker.Properties.Resources.CardBack;
            this.turnCard.Location = new System.Drawing.Point(416, 166);
            this.turnCard.Name = "turnCard";
            this.turnCard.Size = new System.Drawing.Size(72, 104);
            this.turnCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.turnCard.TabIndex = 19;
            this.turnCard.TabStop = false;
            this.turnCard.Visible = false;
            // 
            // riverCard
            // 
            this.riverCard.Image = global::TexasHoldEmPoker.Properties.Resources.CardBack;
            this.riverCard.Location = new System.Drawing.Point(494, 166);
            this.riverCard.Name = "riverCard";
            this.riverCard.Size = new System.Drawing.Size(72, 104);
            this.riverCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.riverCard.TabIndex = 20;
            this.riverCard.TabStop = false;
            this.riverCard.Visible = false;
            // 
            // potLabel
            // 
            this.potLabel.AutoSize = true;
            this.potLabel.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potLabel.Location = new System.Drawing.Point(13, 32);
            this.potLabel.Name = "potLabel";
            this.potLabel.Size = new System.Drawing.Size(39, 19);
            this.potLabel.TabIndex = 21;
            this.potLabel.Text = "Pot";
            this.potLabel.Visible = false;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(273, 547);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(121, 13);
            this.outputLabel.TabIndex = 22;
            this.outputLabel.Text = "Please Select an Option";
            this.outputLabel.Visible = false;
            // 
            // Poker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.potLabel);
            this.Controls.Add(this.riverCard);
            this.Controls.Add(this.turnCard);
            this.Controls.Add(this.flopCard3);
            this.Controls.Add(this.flopCard2);
            this.Controls.Add(this.flopCard1);
            this.Controls.Add(this.p1Card2);
            this.Controls.Add(this.p1Card1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.optionLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.p1Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flopCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riverCard)).EndInit();
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
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox p1Card1;
        private System.Windows.Forms.PictureBox p1Card2;
        private System.Windows.Forms.PictureBox flopCard1;
        private System.Windows.Forms.PictureBox flopCard2;
        private System.Windows.Forms.PictureBox flopCard3;
        private System.Windows.Forms.PictureBox turnCard;
        private System.Windows.Forms.PictureBox riverCard;
        private System.Windows.Forms.Label potLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

