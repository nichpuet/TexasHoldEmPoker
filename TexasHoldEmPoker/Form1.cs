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
            p1Card1.Visible = true;
            p1Card2.Visible = true;
            flopCard1.Visible = true;
            flopCard2.Visible = true;
            flopCard3.Visible = true;
            turnCard.Visible = true;
            riverCard.Visible = true;

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

                        switch (i)
                        {
                            case 1:
                                DrawCard(tempValue, tempSuit,1);
                                break;
                            case 2:
                                DrawCard(tempValue, tempSuit, 2);
                                break;
                        }
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

        private void DrawCard(int value, string suit,int CardToDraw)
        {
            switch (suit)
            {
                case ("Hearts"):
                    if (value == 1)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._2Hearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._2Hearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._2Hearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._2Hearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._2Hearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._2Hearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._2Hearts;
                                break;
                        }
                    }
                    else if (value == 2)
                    {

                    }
                    else if (value == 3)
                    {

                    }
                    else if (value == 4)
                    {

                    }
                    else if (value == 5)
                    {

                    }
                    else if (value == 6)
                    {

                    }
                    else if (value == 7)
                    {

                    }
                    else if (value == 8)
                    {

                    }
                    else if (value == 9)
                    {

                    }
                    else if (value == 10)
                    {

                    }
                    else if (value == 11)
                    {

                    }
                    else if (value == 12)
                    {

                    }
                    else if (value == 13) 
                    {

                    }

                    break;

                case ("Diamonds"):
                    if (value == 14)
                    {

                    }
                    else if (value == 15)
                    {

                    }
                    else if (value == 16)
                    {

                    }
                    else if (value == 17)
                    {

                    }
                    else if (value == 18)
                    {

                    }
                    else if (value == 19)
                    {

                    }
                    else if (value == 20)
                    {

                    }
                    else if (value == 21)
                    {

                    }
                    else if (value == 22)
                    {

                    }
                    else if (value == 23)
                    {

                    }
                    else if (value == 24)
                    {

                    }
                    else if (value == 25)
                    {

                    }
                    else if (value == 26)
                    {

                    }
                   
                    break;
                case ("Clubs"):
                    if (value == 27)
                    {

                    }
                    else if (value == 28)
                    {

                    }
                    else if (value == 29)
                    {

                    }
                    else if (value == 30)
                    {

                    }
                    else if (value == 31)
                    {

                    }
                    else if (value == 32)
                    {

                    }
                    else if (value == 33)
                    {

                    }
                    else if (value == 34)
                    {

                    }
                    else if (value == 35)
                    {

                    }
                    else if (value == 36)
                    {

                    }
                    else if (value == 37)
                    {

                    }
                    else if (value == 38)
                    {

                    }
                    else if (value == 39)
                    {

                    }
                    break;
                case ("Spades"):
                    if (value == 40)
                    {

                    }
                    else if (value == 41)
                    {

                    }
                    else if (value == 42)
                    {

                    }
                    else if (value == 43)
                    {

                    }
                    else if (value == 44)
                    {

                    }
                    else if (value == 45)
                    {

                    }
                    else if (value == 46)
                    {

                    }
                    else if (value == 47)
                    {

                    }
                    else if (value == 48)
                    {

                    }
                    else if (value == 49)
                    {

                    }
                    else if (value == 50)
                    {

                    }
                    else if (value == 51)
                    {

                    }
                    else if (value == 52)
                    {

                    }
                    break;
                
            }
        }
    }

}
