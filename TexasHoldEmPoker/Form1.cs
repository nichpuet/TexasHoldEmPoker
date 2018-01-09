using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Nick Puetz | 1/8/1018 | Texas Hold em Poker

namespace TexasHoldEmPoker
{
    public partial class Poker : Form
    {
        public Poker()
        {
            InitializeComponent();
        }
        int balance = 100;

        private void playButton_Click(object sender, EventArgs e)
        {
            Graphics fG = this.CreateGraphics();
            SolidBrush tableBrush = new SolidBrush(Color.Olive);
            Pen briefPen = new Pen(Color.Black,3);

            titleLabel.Visible = false;
            playButton.Visible = false;
            optionButton.Visible = false;
            exitButton.Visible = false;
            callButton.Visible = true;
            betButton.Visible = true;
            foldButton.Visible = true;
            checkButton.Visible = true;
            exit2Button.Visible = true;
            balLabel.Visible = true;

            BackColor = Color.SandyBrown;

            System.Threading.Thread.Sleep(1);
            Refresh();

            fG.DrawLine(briefPen, 0, 500, 750, 500);
            fG.FillEllipse(tableBrush, 100, 100, 550, 300);

            balLabel.Text = "Balance: " + balance;
            
        }

        private void optionButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit2Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
