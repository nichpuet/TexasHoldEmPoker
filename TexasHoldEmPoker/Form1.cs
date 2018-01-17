using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Nick Puetz | 1/8/1018 | Texas Hold em Poker

namespace TexasHoldEmPoker
{
    public partial class Poker : Form
    {
        List<int> deckValue = new List<int>();
        List<string> deckSuit = new List<string>();
        List<int> p1Value = new List<int>();
        List<string> p1Suit = new List<string>();
        List<int> dValue = new List<int>();
        List<string> dSuit = new List<string>();
        
        List<int> turnOrder = new List<int>();

        Random rand = new Random();

        public Poker()
        {
            InitializeComponent();

        }
        public void gameInit()
        {
            for (int q = 1; q <= 4; q++)
            {
                for (int i = 2; i <= 14; i++)
                {
                    deckValue.Add(i);
                }
            }
            for (int i = 1; i <= 13; i++)
            {
                deckSuit.Add("H");
            }
            for (int i = 1; i <= 13; i++)
            {
                deckSuit.Add("D");
            }
            for (int i = 1; i <= 13; i++)
            {
                deckSuit.Add("C");
            }
            for (int i = 1; i <= 13; i++)
            {
                deckSuit.Add("S");
            }
            for (int i = 1; i<=5; i++)
            {
                turnOrder.Add(i);
            }
        }

        int p1Balance = 100;
        int lastBet = 10;
        int tempValue;
        string tempSuit;
        string filename;
        int pot;

        private void playButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = false;
            playButton.Visible = false;
            optionButton.Visible = false;
            exitButton.Visible = false;
            standButton.Visible = true;
            hitButton.Visible = true;
            exit2Button.Visible = true;
            balLabel.Visible = true;
            pCard3.Visible = true;
            pCard2.Visible = true;
            dCard2.Visible = true;
            dCard3.Visible = true;
            potLabel.Visible = true;
            outputLabel.Visible = true;
            _5Button.Visible = true;
            _10Button.Visible = true;
            _25Button.Visible = true;
            _50Button.Visible = true;

            BackColor = Color.SandyBrown;

            System.Threading.Thread.Sleep(1);
            Refresh();

            DrawTable();

            balLabel.Text = "Balance: " + p1Balance;
            potLabel.Text = "Pot: " + pot;

            gameInit();

            DealHand();
            DealerCards();

            DrawCard(5, 14, "S");
            
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

        private void DealerCards()
        {
            int randGen = rand.Next(1, deckValue.Count );

            tempValue = deckValue[randGen];
            tempSuit = deckSuit[randGen];

            
                
                    dValue.Add(tempValue);
                    dSuit.Add(tempSuit);
                    DrawCard(8, tempValue, tempSuit);

                    deckValue.RemoveAt(randGen);
                    deckSuit.RemoveAt(randGen);

                    randGen = rand.Next(1, deckValue.Count);

                    tempValue = deckValue[randGen];
                    tempSuit = deckSuit[randGen];

                    dValue.Add(tempValue);
                    dSuit.Add(tempSuit);
                    DrawCard(7, tempValue, tempSuit);

                    deckValue.RemoveAt(randGen);
                    deckSuit.RemoveAt(randGen);


                
            


        }

        private void DealHand()
        {
            for (int i = 1; i <= 3; i++)
            {
                int randGen = rand.Next(1, deckValue.Count);

                tempValue = deckValue[randGen];
                tempSuit = deckSuit[randGen];

                p1Value.Add(tempValue);
                p1Suit.Add(tempSuit);

                deckValue.RemoveAt(randGen);
                deckSuit.RemoveAt(randGen);

                switch (i)
                {
                    case 1:
                        DrawCard(3, tempValue, tempSuit);
                        break;
                    case 2:
                        DrawCard(2, tempValue, tempSuit);
                        break;
                }
            }



        }

        private void DrawCard(int location, int value, string suit)
        {
            filename = suit + value;
            switch (location)
            {
                case 1:
                    pCard1.Visible = true;
                    pCard1.Image = Image.FromFile(filename + ".png");
                    break;
                case 2:
                    pCard2.Image = Image.FromFile(filename + ".png");
                    break;
                case 3:
                    pCard3.Image = Image.FromFile(filename + ".png");
                    break;
                case 4:
                    pCard4.Visible = true;
                    pCard4.Image = Image.FromFile(filename + ".png");
                    break;
                case 5:
                    pCard5.Visible = true;
                    pCard5.Image = Image.FromFile(filename + ".png");
                    break;
                case 6:
                    dCard1.Visible = true;
                    dCard1.Image = Image.FromFile(filename + ".png");
                    break;
                case 7:
                    dCard2.Image = Image.FromFile(filename + ".png");
                    break;
                case 8:
                    dCard3.Image = Image.FromFile(filename + ".png");
                    break;
                case 9:
                    dCard4.Visible = true;
                    dCard4.Image = Image.FromFile(filename + ".png");
                    break;
                case 10:
                    dCard5.Visible = true;
                    dCard5.Image = Image.FromFile(filename + ".png");
                    break;
            }
        }

        private void Hit()
        {

        }

        private void Stand()
        {

        }

        private void standButton_Click(object sender, EventArgs e)
        {

        }

        private void hitButton_Click(object sender, EventArgs e)
        {

        }

        private void _5Button_Click(object sender, EventArgs e)
        {

        }

        private void _10Button_Click(object sender, EventArgs e)
        {

        }

        private void _25Button_Click(object sender, EventArgs e)
        {

        }

        private void _50Button_Click(object sender, EventArgs e)
        {

        }
    }

}
