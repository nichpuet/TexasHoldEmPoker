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
        bool endRound = false;
        bool playerTurn = true;
        double p1Balance = 100;
        int tempValue;
        int tempNum;
        string tempSuit;
        string filename;
        double pot;
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

            tempNum = deckNum[randGen];
            tempSuit = deckSuit[randGen];
            tempNum = deckValue[randGen];

            p1Num.Add(tempNum);
            p1Suit.Add(tempSuit);
            p1Value.Add(tempValue);

            deckNum.RemoveAt(randGen);
            deckSuit.RemoveAt(randGen);
            deckValue.RemoveAt(randGen);

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

            CheckSum();
            winCheck();

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
            bool dealerTurn = true;
            while (dealerTurn)
            {
                CheckSum();
                winCheck();
                if (dealerTotal >= 17)
                {
                    dealerTurn = false;
                    CheckSum();
                    winCheck();
                    playerTurn = true;
                    EndRound();
                    TurnRotation();

                }
                else if (dealerTotal <= 16)
                {
                    while (dealerTotal <= 16)
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
                                break;
                            case 4:
                                dCard1.Visible = true;
                                break;
                            case 5:
                                dCard5.Visible = true;
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


        }

        private void CheckSum()
        {

            int quickMaths1 = 0, quickMaths2 = 0;
            int tempVal1 = 0, tempVal2 = 0, tempVal3 = 0, tempVal4 = 0, tempVal5 = 0;
            
                for (int i = 1; i <= p1Value.Count(); i++)
                {
                    if (i == 1)
                    {
                        tempVal1 = p1Value[i - 1];
                    }
                    else if (i == 2)
                    {
                        tempVal2 = p1Value[i - 1];
                    }
                    else if (i == 3)
                    {
                        tempVal3 = p1Value[i - 1];
                    }
                    else if (i == 4)
                    {
                        tempVal4 = p1Value[i - 1];
                    }
                    else
                    {
                        tempVal5 = p1Value[i - 1];
                    }
                    quickMaths1 = tempVal1 + tempVal2 + tempVal3 + tempVal4 + tempVal5;

                    if (p1Value[i - 1] == 11)
                    {
                        p1Value[i - 1] = 1;
                    }

                }
                for (int i = 1; i <= p1Value.Count(); i++)
                {
                    if (i == 1)
                    {
                        tempVal1 = p1Value[i - 1];
                    }
                    else if (i == 2)
                    {
                        tempVal2 = p1Value[i - 1];
                    }
                    else if (i == 3)
                    {
                        tempVal3 = p1Value[i - 1];
                    }
                    else if (i == 4)
                    {
                        tempVal4 = p1Value[i - 1];
                    }
                    else
                    {
                        tempVal5 = p1Value[i - 1];
                    }
                    quickMaths2 = tempVal1 + tempVal2 + tempVal3 + tempVal4 + tempVal5;

                }
            

            if (quickMaths1 > quickMaths2 && quickMaths1 <= 21)
            {
                playerTotal = quickMaths1;
            }
            else if (quickMaths2 <= 21)
            {
                playerTotal = quickMaths2;
            }
            else
            {
                playerTotal = quickMaths1;
            }

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
                    if (dValue[i-1] == 11)
                    {
                        dValue[i - 1] = 1;
                    }
                }

               quickMaths1 = tempVal1 + tempVal2 + tempVal3 + tempVal4 + tempVal5;

                for (int i =1; i <= dValue.Count(); i++)
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
                    if (dValue[i - 1] == 11)
                    {
                        dValue[i - 1] = 1;
                    }
                    
                }
            quickMaths2 = tempVal1 + tempVal2 + tempVal3 + tempVal4 + tempVal5;

            if (quickMaths1 > quickMaths2 && quickMaths1 <= 21)
            {
                playerTotal = quickMaths1;
            }
            else if (quickMaths2 <= 21)
            {
                dealerTotal = quickMaths2;
            }
            else
            {
                dealerTotal = quickMaths1;
            }
        }

        private void winCheck()
        {
            CheckSum();


            if (playerTotal == 21)
            {
                outputLabel.Text = "YOU WIN!";
                WinWindow winForm = new WinWindow();
                winForm.Show();

                pot = pot * 1.5;
                p1Balance = p1Balance + pot;
                pot = 0;

                balLabel.Text = "Balance: " + p1Balance;
                potLabel.Text = "Pot: " + pot;


                hitButton.Enabled = false;
                standButton.Enabled = false;

                Refresh();

                newHandButton.Visible = true;

                DrawTable();
            }
            else if (playerTotal >= 22)
            {
                outputLabel.Text = "BUST!";
                LossWindow lossForm = new LossWindow();
                lossForm.Show();

                pot = 0;

                balLabel.Text = "Balance: " + p1Balance;
                potLabel.Text = "Pot: " + pot;

                hitButton.Enabled = false;
                standButton.Enabled = false;

                Refresh();

                newHandButton.Visible = true;

                DrawTable();
            }
            else if (endRound)
            {
                endRound = false;
                if (dealerTotal > playerTotal && dealerTotal <=21)
                {
                    outputLabel.Text = "You Lost!";
                    LossWindow lossForm = new LossWindow();
                    lossForm.Show();

                    pot = 0;

                    balLabel.Text = "Balance: " + p1Balance;
                    potLabel.Text = "Pot: " + pot;

                    hitButton.Enabled = false;
                    standButton.Enabled = false;
                    newHandButton.Visible = true;

                    Refresh();
                    DrawTable();
                }
                else
                {
                    outputLabel.Text = "YOU WIN!";
                    WinWindow winForm = new WinWindow();
                    winForm.Show();

                    pot = pot * 1.5;
                    p1Balance = p1Balance + pot;
                    pot = 0;

                    balLabel.Text = "Balance: " + p1Balance;
                    potLabel.Text = "Pot: " + pot;

                    hitButton.Enabled = false;
                    standButton.Enabled = false;
                    newHandButton.Visible = true;

                    Refresh();
                    DrawTable();
                }
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
            endRound = true;
            for (int i = 1; i < dNum.Count()+1 ; i++)
            {
                int dumbMath;
                dumbMath = 5 + i;

                switch (dumbMath)
                {
                    case 6:
                        dumbMath = 7;
                        break;
                    case 7:
                        dumbMath = 8;
                        break;
                    case 8:
                        dumbMath = 9;
                        break;
                    case 9:
                        dumbMath = 6;
                        break;
                    case 10:
                        dumbMath = 10;
                        break;
                }
                DrawCard(dumbMath, dNum[i-1], dSuit[i-1]);
            }
            Refresh();
            DrawTable();

            CheckSum();
            winCheck();


        }

        private void newHandButton_Click(object sender, EventArgs e)
        {
            _5Button.Enabled = true;
            _10Button.Enabled = true;
            _25Button.Enabled = true;
            _50Button.Enabled = true;
            hitButton.Enabled = true;
            standButton.Enabled = true;
            hitButton.Visible = false;
            standButton.Visible = false;
            newHandButton.Visible = false;

            pCard1.Visible = false;
            pCard4.Visible = false;
            pCard5.Visible = false;
            dCard1.Visible = false;
            dCard4.Visible = false;
            dCard5.Visible = false;

            outputLabel.Text = "Please select an amount to bet";

            pCard2.Image = Image.FromFile("CardBack.png");
            pCard3.Image = Image.FromFile("CardBack.png");
            dCard2.Image = Image.FromFile("CardBack.png");
            dCard3.Image = Image.FromFile("CardBack.png");

            p1Num.Clear();
            p1Value.Clear();
            p1Suit.Clear();
            dNum.Clear();
            dValue.Clear();
            dSuit.Clear();

            if (deckSuit.Count < 10)
            {
                deckSuit.Clear();
                deckNum.Clear();
                deckValue.Clear();

                gameInit();
            }

            cardsInHand = 2;
            dealerHand = 2;

            gameInit();
            DrawTable();
        }
    }

}
