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

//Nick Puetz & Tyler Gerber | 1/8/1018 | Blackjack

namespace TexasHoldEmPoker
{
    public partial class BlackJack : Form
    {
        List<int> deckNum = new List<int>();  //test
        List<string> deckSuit = new List<string>();
        List<int> deckValue = new List<int>();
        List<int> p1Num = new List<int>();
        List<string> p1Suit = new List<string>();
        List<int> p1Value = new List<int>();
        List<int> dNum = new List<int>();
        List<string> dSuit = new List<string>();
        List<int> dValue = new List<int>();
        

        Random rand = new Random();

        public BlackJack()
        {
            InitializeComponent();

        }
        public void gameInit()
        {
            for (int q = 1; q <= 4; q++)
            {
                for (int i = 2; i <= 14; i++)
                {
                    deckNum.Add(i);
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
            for (int q = 1; q <= 4; q++)
            {
                for (int i = 2; i <= 9; i++)
                {
                    deckValue.Add(i);
                }
                for (int i = 1; i <= 4; i++)
                {
                    deckValue.Add(10);
                }
                deckValue.Add(11);
            }
        }

        bool playerTurn = true;
        int p1Balance = 100;
        int tempValue;
        int tempNum;
        string tempSuit;
        string filename;
        int pot;
        int cardsInHand = 2;
        int dealerTotal;
        int playerTotal;
        int dealerHand = 2;

        private void playButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = false;
            playButton.Visible = false;
            optionButton.Visible = false;
            exitButton.Visible = false;
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
            int randGen = rand.Next(1, deckNum.Count);

            tempValue = deckValue[randGen];
            tempSuit = deckSuit[randGen];
            tempNum = deckNum[randGen];

            dNum.Add(tempNum);
            dSuit.Add(tempSuit);
            dValue.Add(tempValue);

            DrawCard(7, tempValue, tempSuit);

            deckNum.RemoveAt(randGen);
            deckSuit.RemoveAt(randGen);
            deckValue.RemoveAt(randGen);

            randGen = rand.Next(1, deckNum.Count);

            tempValue = deckValue[randGen];
            tempSuit = deckSuit[randGen];
            tempNum = deckNum[randGen];

            dNum.Add(tempNum);
            dSuit.Add(tempSuit);
            dValue.Add(tempValue);

            DrawCard(8, tempValue, tempSuit);

            deckNum.RemoveAt(randGen);
            deckSuit.RemoveAt(randGen);
            deckValue.RemoveAt(randGen);
        }

        private void DealHand()
        {
            for (int i = 1; i <= 2; i++)
            {
                int randGen = rand.Next(1, deckNum.Count);

                tempNum = deckNum[randGen];
                tempSuit = deckSuit[randGen];
                tempValue = deckValue[randGen];

                p1Num.Add(tempNum);
                p1Suit.Add(tempSuit);
                p1Value.Add(tempValue);

                deckNum.RemoveAt(randGen);
                deckSuit.RemoveAt(randGen);
                deckValue.RemoveAt(randGen);

                switch (i)
                {
                    case 1:
                        DrawCard(3, tempNum, tempSuit);
                        break;
                    case 2:
                        DrawCard(2, tempNum, tempSuit);
                        break;
                }
            }

            CheckSum();
            winCheck();

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
            int randGen = rand.Next(1, deckNum.Count);

            tempValue = deckNum[randGen];
            tempSuit = deckSuit[randGen];

            p1Num.Add(tempValue);
            p1Suit.Add(tempSuit);

            deckNum.RemoveAt(randGen);
            deckSuit.RemoveAt(randGen);

            cardsInHand++;
            switch (cardsInHand)
            {
                case 3:
                    DrawCard(4, tempValue, tempSuit);
                    break;
                case 4:
                    DrawCard(1, tempValue, tempSuit);
                    break;
                case 5:
                    DrawCard(5, tempValue, tempSuit);
                    break;
            }

        }

        private void Stand()
        {
            playerTurn = false;
            TurnRotation();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            Stand();
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            Hit();
        }

        private void _5Button_Click(object sender, EventArgs e)
        {
            if (p1Balance >= 5)
            {
                p1Balance = p1Balance - 5;
                pot = pot + 5;

                balLabel.Text = "Balance: " + p1Balance;
                potLabel.Text = "Pot: " + pot;

                outputLabel.Text = "Bet placed";

                _5Button.Enabled = false;
                _10Button.Enabled = false;
                _25Button.Enabled = false;
                _50Button.Enabled = false;

                DealHand();
                DealerCards();

                hitButton.Visible = true;
                standButton.Visible = true;
            }
            else
            {
                outputLabel.Text = "Your balance is too low, pick another amount";
            }
        }

        private void _10Button_Click(object sender, EventArgs e)
        {
            if (p1Balance >= 10)
            {
                p1Balance = p1Balance - 10;
                pot = pot + 10;

                balLabel.Text = "Balance: " + p1Balance;
                potLabel.Text = "Pot: " + pot;

                outputLabel.Text = "Bet placed";

                _5Button.Enabled = false;
                _10Button.Enabled = false;
                _25Button.Enabled = false;
                _50Button.Enabled = false;

                DealHand();
                DealerCards();

                hitButton.Visible = true;
                standButton.Visible = true;
            }
            else
            {
                outputLabel.Text = "Your balance is too low, pick another amount";
            }
        }

        private void _25Button_Click(object sender, EventArgs e)
        {
            if (p1Balance >= 25)
            {
                p1Balance = p1Balance - 25;
                pot = pot + 25;

                balLabel.Text = "Balance: " + p1Balance;
                potLabel.Text = "Pot: " + pot;

                outputLabel.Text = "Bet placed";

                _5Button.Enabled = false;
                _10Button.Enabled = false;
                _25Button.Enabled = false;
                _50Button.Enabled = false;

                DealHand();
                DealerCards();

                hitButton.Visible = true;
                standButton.Visible = true;
            }
            else
            {
                outputLabel.Text = "Your balance is too low, pick another amount";
            }
        }

        private void _50Button_Click(object sender, EventArgs e)
        {
            if (p1Balance >= 50)
            {
                p1Balance = p1Balance - 50;
                pot = pot + 50;

                balLabel.Text = "Balance: " + p1Balance;
                potLabel.Text = "Pot: " + pot;

                outputLabel.Text = "Bet placed";

                _5Button.Enabled = false;
                _10Button.Enabled = false;
                _25Button.Enabled = false;
                _50Button.Enabled = false;

                DealHand();
                DealerCards();

                hitButton.Visible = true;
                standButton.Visible = true;
            }
            else
            {
                outputLabel.Text = "Your balance is too low, pick another amount";
            }
        }

        private void DealerTurn()
        { 
            CheckSum();
            winCheck();
            if (dealerTotal >= 17)
            {
                CheckSum();
                winCheck();
                playerTurn = true;
                TurnRotation();
            }
            else if (dealerTotal <= 16) 
            {
                while (dealerTotal <=16)
                {
                    Thread.Sleep(500);
                    Refresh();

                    DrawTable();

                    int randGen = rand.Next(1, deckNum.Count);

                    tempValue = deckValue[randGen];
                    tempSuit = deckSuit[randGen];
                    tempNum = deckNum[randGen];

                    dNum.Add(tempNum);
                    dSuit.Add(tempSuit);
                    dValue.Add(tempValue);

                    dealerHand++;

                    switch (dealerHand)
                    {
                        case 3:
                            dCard4.Visible = true;
                            DrawCard(9, tempValue, tempSuit);
                            break;
                        case 4:
                            dCard1.Visible = true;
                            DrawCard(6, tempValue, tempSuit);
                            break;
                        case 5:
                            dCard5.Visible = true;
                            DrawCard(10, tempValue, tempSuit);
                            break;
                    }
                    dealerHand++;

                    deckNum.RemoveAt(randGen);
                    deckSuit.RemoveAt(randGen);
                    deckValue.RemoveAt(randGen);

                    CheckSum();
                    winCheck();
                }

            }


        }

        private void CheckSum()
        {
            int tempVal1 = 0, tempVal2 = 0, tempVal3 = 0, tempVal4 = 0, tempVal5 = 0;
            for (int i = 1; i <= p1Value.Count(); i++)
            {
                if (i == 1)
                {
                    tempVal1 = p1Value[i-1];
                }
                else if (i == 2)
                {
                    tempVal2 = p1Value[i-1];
                }
                else if (i == 3)
                {
                    tempVal3 = p1Value[i-1];
                }
                else if (i == 4)
                {
                    tempVal4 = p1Value[i - 1];
                }
                else
                {
                    tempVal5 = p1Value[i - 1];
                }
               
            }
            playerTotal = tempVal1 + tempVal2 + tempVal3 + tempVal4 + tempVal5;

            tempVal1 = 0;
            tempVal2 = 0;
            tempVal3 = 0;
            tempVal4 = 0;
            tempVal5 = 0;

            for (int i = 1; i <= dValue.Count(); i++)
            {
                if (i == 1)
                {
                    tempVal1 = dValue[i - 1];
                }
                else if (i == 2)
                {
                    tempVal2 = dValue[i - 1];
                }
                else if (i == 3)
                {
                    tempVal3 = dValue[i - 1];
                }
                else if (i == 4)
                {
                    tempVal4 = dValue[i - 1];
                }
                else
                {
                    tempVal5 = dValue[i - 1];
                }

            }


            dealerTotal = tempVal1 + tempVal2 + tempVal3 + tempVal4 + tempVal5;

        }

        private void winCheck()
        {
            CheckSum();
            if (playerTotal == 21)
            {
                outputLabel.Text = "YOU WIN!";
                winPopUp.Visible = true;
                Refresh();
                DrawTable();
            }
            else if (playerTotal > 21)
            {
                outputLabel.Text = "BUST!";
                lossPopUp.Visible = true;
                Refresh();
                DrawTable();
            }
        }

        private void TurnRotation()
        {
            if (playerTurn)
            {
                standButton.Enabled = true;
                hitButton.Enabled = true;
            }
            else
            {
                standButton.Enabled = false;
                hitButton.Enabled = false;

                DealerTurn();
            }
        }

        private void EndRound()
        {

        }
    }

}
