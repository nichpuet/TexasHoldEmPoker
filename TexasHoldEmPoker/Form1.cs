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
        List<int> deckValue = new List<int>();
        List<string> deckSuit = new List<string>();
        List<int> p1Value = new List<int>();
        List<String> p1Suit = new List<String>();
        List<int> p2Value = new List<int>();
        List<string> p2Suit = new List<string>();
        List<int> p3Value = new List<int>();
        List<string> p3Suit = new List<string>();
        List<int> p4Value = new List<int>();
        List<string> p4Suit = new List<string>();

        

        Random rand = new Random();

        public Poker()
        {
            InitializeComponent();

        }
        public void gameInit()
        {
            for (int i = 1; i <= 52; i++)
            {
                deckValue.Add(i);
            }
            for (int i = 1; i <= 13; i++)
            {
                deckSuit.Add("Hearts");
            }
            for (int i = 1; i <= 13; i++)
            {
                deckSuit.Add("Diamonds");
            }
            for (int i = 1; i <= 13; i++)
            {
                deckSuit.Add("Clubs");
            }
            for (int i = 1; i <= 13; i++)
            {
                deckSuit.Add("Spades");
            }
        }
        int balance = 100;
        int lastBet = 0;

        private void playButton_Click(object sender, EventArgs e)
        {
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

            DrawTable();

            balLabel.Text = "Balance: " + balance;

            gameInit();

        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = false;
            playButton.Visible = false;
            optionButton.Visible = false;
            exitButton.Visible = false;
            optionLabel.Visible = true;
            backButton.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit2Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawTable()
        {
            Graphics fG = this.CreateGraphics();
            SolidBrush tableBrush = new SolidBrush(Color.Olive);
            Pen tablePen = new Pen(Color.Brown, 15);
            Pen briefPen = new Pen(Color.Black, 3);

            fG.DrawLine(briefPen, 0, 500, 750, 500);
            fG.FillEllipse(tableBrush, 100, 100, 550, 300);
            fG.DrawEllipse(tablePen, 100, 100, 550, 300);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = true;
            playButton.Visible = true;
            optionButton.Visible = true;
            exitButton.Visible = true;
            optionLabel.Visible = false;
            backButton.Visible = false;
        }

        private void Check()
        {

        }

        private void Call(int bet)
        {

        }

        private void Fold()
        {

        }

        private void Bet()
        {

        }

        private void DealHand(int player)
        {
            int tempValue;
            string tempSuit;

            switch (player)
            {
                case 1:
                    for (int i = 1; i <= 3; i++)
                    {
                        int randGen = rand.Next(1, deckValue.Count+1);

                        tempValue = deckValue[randGen];
                        tempSuit = deckSuit[randGen];

                        p1Value.Add(tempValue);
                        p1Suit.Add(tempSuit);
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 3; i++)
                    {
                        int randGen = rand.Next(1, deckValue.Count+1);

                        tempValue = deckValue[randGen];
                        tempSuit = deckSuit[randGen];

                        p2Value.Add(tempValue);
                        p2Suit.Add(tempSuit);
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 3; i++)
                    {
                        int randGen = rand.Next(1, deckValue.Count + 1);

                        tempValue = deckValue[randGen];
                        tempSuit = deckSuit[randGen];

                        p3Value.Add(tempValue);
                        p3Suit.Add(tempSuit);
                    }
                    break;
                case 4:
                    for (int i = 1; i <= 3; i++)
                    {
                        int randGen = rand.Next(0, deckValue.Count + 1);

                        tempValue = deckValue[randGen];
                        tempSuit = deckSuit[randGen];

                        p4Value.Add(tempValue);
                        p4Suit.Add(tempSuit);
                    }
                    break;

            }

            
            
        }

        private void DrawCard(int value, string suit)
        {

        }
    }

}
