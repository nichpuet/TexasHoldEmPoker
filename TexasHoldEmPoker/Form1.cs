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
        List<int> p2Value = new List<int>();
        List<string> p2Suit = new List<string>();
        List<int> p3Value = new List<int>();
        List<string> p3Suit = new List<string>();
        List<int> p4Value = new List<int>();
        List<string> p4Suit = new List<string>();
        List<int> flop1Value = new List<int>();
        List<string> flop1Suit = new List<string>();
        List<int> flop2Value = new List<int>();
        List<string> flop2Suit = new List<string>();
        List<int> flop3Value = new List<int>();
        List<string> flop3Suit = new List<string>();
        List<int> turnValue = new List<int>();
        List<string> turnSuit = new List<string>();
        List<int> riverValue = new List<int>();
        List<string> riverSuit = new List<string>();
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
            for (int i = 1; i<=5; i++)
            {
                turnOrder.Add(i);
            }
        }

        int p2Balance = 100;
        int p3Balance = 100;
        int p4Balance = 100;
        int p1Balance = 100;
        int lastBet = 10;
        int tempValue;
        string tempSuit;
        int pot;

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
            potLabel.Visible = true;
            outputLabel.Visible = true;

            BackColor = Color.SandyBrown;

            System.Threading.Thread.Sleep(1);
            Refresh();

            DrawTable();

            balLabel.Text = "Balance: " + p1Balance;
            potLabel.Text = "Pot: " + pot;

            gameInit();

            DealHand(1);
            CenterCards("Flop");

            Thread.Sleep(1000);
            Refresh();
            DrawTable();

            CenterCards("Turn");

            Thread.Sleep(1000);
            Refresh();
            DrawTable();

            CenterCards("River");
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

        private void Call(int player)
        {
            switch (player)
            {
                case 1:
                    if (lastBet > p1Balance)
                    {
                        outputLabel.Text = "Your balance is insufficient to complete\n this action please select another option";

                    }
                    else if (p1Balance > lastBet)
                    {
                        p1Balance = p1Balance - lastBet;
                        pot = pot + lastBet;

                        balLabel.Text = "Balance: " + p1Balance;
                        potLabel.Text = "Pot: " + pot;
                    }
                    break;
                case 2:
                    if (lastBet > p2Balance)
                    {
                        outputLabel.Text = "Your balance is insufficient to complete\n this action please select another option";

                    }
                    else if (p2Balance > lastBet)
                    {
                        p2Balance = p2Balance - lastBet;
                        pot = pot + lastBet;
                    }
                    break;
                case 3:
                    if (lastBet > p3Balance)
                    {
                        outputLabel.Text = "Your balance is insufficient to complete\n this action please select another option";

                    }
                    else if (p3Balance > lastBet)
                    {
                        p3Balance = p3Balance - lastBet;
                        pot = pot + lastBet;
                    }
                    break;
                case 4:
                    if (lastBet > p4Balance)
                    {
                        outputLabel.Text = "Your balance is insufficient to complete\n this action please select another option";

                    }
                    else if (p4Balance > lastBet)
                    {
                        p4Balance = p4Balance - lastBet;
                        pot = pot + lastBet;
                    }
                    break;

            }

        }

        private void Fold()
        {

        }

        private void Bet()
        {

        }

        private void CenterCards(string turnIdentifier)
        {
            int randGen = rand.Next(1, deckValue.Count );

            tempValue = deckValue[randGen];
            tempSuit = deckSuit[randGen];

            switch (turnIdentifier)
            {
                case "Flop":
                    flop1Value.Add(tempValue);
                    flop1Suit.Add(tempSuit);
                    DrawCard(tempValue, tempSuit, 3);

                    deckValue.RemoveAt(randGen);
                    deckSuit.RemoveAt(randGen);

                    randGen = rand.Next(1, deckValue.Count);

                    tempValue = deckValue[randGen];
                    tempSuit = deckSuit[randGen];

                    flop2Value.Add(tempValue);
                    flop2Suit.Add(tempSuit);
                    DrawCard(tempValue, tempSuit, 4);

                    deckValue.RemoveAt(randGen);
                    deckSuit.RemoveAt(randGen);

                    randGen = rand.Next(1, deckValue.Count);

                    tempValue = deckValue[randGen];
                    tempSuit = deckSuit[randGen];

                    flop3Value.Add(tempValue);
                    flop3Suit.Add(tempSuit);
                    DrawCard(tempValue, tempSuit, 5);

                    deckValue.RemoveAt(randGen);
                    deckSuit.RemoveAt(randGen);
                    break;

                case "Turn":
                    turnValue.Add(tempValue);
                    turnSuit.Add(tempSuit);
                    DrawCard(tempValue, tempSuit, 6);

                    deckValue.RemoveAt(randGen);
                    deckSuit.RemoveAt(randGen);
                    break;

                case "River":
                    riverValue.Add(tempValue);
                    riverSuit.Add(tempSuit);
                    DrawCard(tempValue, tempSuit, 7);

                    deckValue.RemoveAt(randGen);
                    deckSuit.RemoveAt(randGen);
                    break;
            }


        }

        private void DealHand(int player)
        {


            switch (player)
            {
                case 1:
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
                                DrawCard(tempValue, tempSuit, 1);
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
                        int randGen = rand.Next(1, deckValue.Count + 1);

                        tempValue = deckValue[randGen];
                        tempSuit = deckSuit[randGen];

                        p2Value.Add(tempValue);
                        p2Suit.Add(tempSuit);

                        deckValue.RemoveAt(randGen);
                        deckSuit.RemoveAt(randGen);
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

                        deckValue.RemoveAt(randGen);
                        deckSuit.RemoveAt(randGen);
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

                        deckValue.RemoveAt(randGen);
                        deckSuit.RemoveAt(randGen);
                    }
                    break;

            }



        }

        private void DrawCard(int value, string suit, int CardToDraw)
        {
            switch (suit)
            {
                case ("Hearts"):
                    if (value == 2)
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
                    else if (value == 3)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._3Hearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._3Hearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._3Hearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._3Hearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._3Hearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._3Hearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._3Hearts;
                                break;
                        }
                    }
                    else if (value == 4)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._4Hearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._4Hearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._4Hearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._4Hearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._4Hearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._4Hearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._4Hearts;
                                break;
                        }
                    }
                    else if (value == 5)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._5Hearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._5Hearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._5Hearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._5Hearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._5Hearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._5Hearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._5Hearts;
                                break;
                        }
                    }
                    else if (value == 6)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._6Hearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._6Hearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._6Hearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._6Hearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._6Hearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._6Hearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._6Hearts;
                                break;
                        }
                    }
                    else if (value == 7)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._7Hearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._7Hearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._7Hearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._7Hearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._7Hearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._7Hearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._7Hearts;
                                break;
                        }
                    }
                    else if (value == 8)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._8Hearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._8Hearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._8Hearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._8Hearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._8Hearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._8Hearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._8Hearts;
                                break;
                        }
                    }
                    else if (value == 9)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._9Hearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._9Hearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._9Hearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._9Hearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._9Hearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._9Hearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._9Hearts;
                                break;
                        }
                    }
                    else if (value == 10)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._10Hearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._10Hearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._10Hearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._10Hearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._10Hearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._10Hearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._10Hearts;
                                break;
                        }
                    }
                    else if (value == 11)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.jackHearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.jackHearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.jackHearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.jackHearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.jackHearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.jackHearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.jackHearts;
                                break;
                        }
                    }
                    else if (value == 12)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.queenHearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.queenHearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.queenHearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.queenHearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.queenHearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.queenHearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.queenHearts;
                                break;
                        }
                    }
                    else if (value == 13)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.kingHearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.kingHearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.kingHearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.kingHearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.kingHearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.kingHearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.kingHearts;
                                break;
                        }
                    }
                    else if (value == 14)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.aceHearts;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.aceHearts;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.aceHearts;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.aceHearts;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.aceHearts;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.aceHearts;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.aceHearts;
                                break;
                        }
                    }

                    break;

                case ("Diamonds"):
                    if (value == 2)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._2Diamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._2Diamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._2Diamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._2Diamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._2Diamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._2Diamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._2Diamonds;
                                break;
                        }
                    }
                    else if (value == 3)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._3Diamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._3Diamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._3Diamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._3Diamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._3Diamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._3Diamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._3Diamonds;
                                break;
                        }
                    }
                    else if (value == 4)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._4Diamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._4Diamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._4Diamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._4Diamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._4Diamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._4Diamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._4Diamonds;
                                break;
                        }
                    }
                    else if (value == 5)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._5Diamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._5Diamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._5Diamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._5Diamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._5Diamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._5Diamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._5Diamonds;
                                break;
                        }
                    }
                    else if (value == 6)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._6Diamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._6Diamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._6Diamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._6Diamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._6Diamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._6Diamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._6Diamonds;
                                break;
                        }
                    }
                    else if (value == 7)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._7Diamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._7Diamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._7Diamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._7Diamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._7Diamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._7Diamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._7Diamonds;
                                break;
                        }
                    }
                    else if (value == 8)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._8Diamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._8Diamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._8Diamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._8Diamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._8Diamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._8Diamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._8Diamonds;
                                break;
                        }
                    }
                    else if (value == 9)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._9Diamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._9Diamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._9Diamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._9Diamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._9Diamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._9Diamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._9Diamonds;
                                break;
                        }
                    }
                    else if (value == 10)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._10Diamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._10Diamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._10Diamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._10Diamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._10Diamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._10Diamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._10Diamonds;
                                break;
                        }
                    }
                    else if (value == 11)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.jackDiamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.jackDiamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.jackDiamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.jackDiamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.jackDiamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.jackDiamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.jackDiamonds;
                                break;
                        }
                    }
                    else if (value == 12)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.queenDiamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.queenDiamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.queenDiamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.queenDiamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.queenDiamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.queenDiamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.queenDiamonds;
                                break;
                        }
                    }
                    else if (value == 13)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.kingDiamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.kingDiamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.kingDiamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.kingDiamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.kingDiamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.kingDiamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.kingDiamonds;
                                break;
                        }
                    }
                    else if (value == 14)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.aceDiamonds;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.aceDiamonds;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.aceDiamonds;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.aceDiamonds;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.aceDiamonds;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.aceDiamonds;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.aceDiamonds;
                                break;
                        }
                    }

                    break;
                case ("Clubs"):
                    if (value == 2)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._2Clubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._2Clubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._2Clubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._2Clubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._2Clubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._2Clubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._2Clubs;
                                break;
                        }
                    }
                    else if (value == 3)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._3Clubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._3Clubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._3Clubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._3Clubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._3Clubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._3Clubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._3Clubs;
                                break;
                        }
                    }

                    else if (value == 4)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._4Clubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._4Clubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._4Clubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._4Clubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._4Clubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._4Clubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._4Clubs;
                                break;
                        }
                    }

                    else if (value == 5)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._5Clubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._5Clubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._5Clubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._5Clubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._5Clubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._5Clubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._5Clubs;
                                break;
                        }
                    }
                    else if (value == 6)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._6Clubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._6Clubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._6Clubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._6Clubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._6Clubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._6Clubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._6Clubs;
                                break;
                        }
                    }
                    else if (value == 7)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._7Clubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._7Clubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._7Clubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._7Clubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._7Clubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._7Clubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._7Clubs;
                                break;
                        }
                    }
                    else if (value == 8)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._8Clubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._8Clubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._8Clubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._8Clubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._8Clubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._8Clubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._8Clubs;
                                break;
                        }
                    }
                    else if (value == 9)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._9Clubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._9Clubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._9Clubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._9Clubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._9Clubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._9Clubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._9Clubs;
                                break;
                        }
                    }
                    else if (value == 10)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._10Clubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._10Clubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._10Clubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._10Clubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._10Clubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._10Clubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._10Clubs;
                                break;
                        }
                    }
                    else if (value == 11)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.jackClubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.jackClubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.jackClubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.jackClubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.jackClubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.jackClubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.jackClubs;
                                break;
                        }
                    }
                    else if (value == 12)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.queenClubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.queenClubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.queenClubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.queenClubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.queenClubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.queenClubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.queenClubs;
                                break;
                        }
                    }
                    else if (value == 13)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.kingClubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.kingClubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.kingClubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.kingClubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.kingClubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.kingClubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.kingClubs;
                                break;
                        }
                    }
                    else if (value == 14)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.aceClubs;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.aceClubs;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.aceClubs;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.aceClubs;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.aceClubs;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.aceClubs;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.aceClubs;
                                break;
                        }
                    }
                    break;
                case ("Spades"):
                    if (value == 2)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._2Spades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._2Spades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._2Spades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._2Spades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._2Spades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._2Spades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._2Spades;
                                break;
                        }
                    }
                    else if (value == 3)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._3Spades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._3Spades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._3Spades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._3Spades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._3Spades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._3Spades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._3Spades;
                                break;
                        }
                    }
                    else if (value == 4)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._4Spades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._4Spades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._4Spades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._4Spades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._4Spades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._4Spades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._4Spades;
                                break;
                        }
                    }
                    else if (value == 5)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._5Spades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._5Spades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._5Spades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._5Spades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._5Spades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._5Spades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._5Spades;
                                break;
                        }
                    }
                    else if (value == 6)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._6Spades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._6Spades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._6Spades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._6Spades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._6Spades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._6Spades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._6Spades;
                                break;
                        }
                    }
                    else if (value == 7)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._7Spades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._7Spades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._7Spades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._7Spades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._7Spades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._7Spades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._7Spades;
                                break;
                        }
                    }
                    else if (value == 8)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._8Spades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._8Spades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._8Spades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._8Spades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._8Spades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._8Spades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._8Spades;
                                break;
                        }
                    }
                    else if (value == 9)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._9Spades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._9Spades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._9Spades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._9Spades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._9Spades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._9Spades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._9Spades;
                                break;
                        }
                    }
                    else if (value == 10)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources._10Spades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources._10Spades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources._10Spades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources._10Spades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources._10Spades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources._10Spades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources._10Spades;
                                break;
                        }
                    }
                    else if (value == 11)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.jackSpades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.jackSpades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.jackSpades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.jackSpades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.jackSpades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.jackSpades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.jackSpades;
                                break;
                        }
                    }
                    else if (value == 12)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.queenSpades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.queenSpades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.queenSpades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.queenSpades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.queenSpades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.queenSpades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.queenSpades;
                                break;
                        }
                    }
                    else if (value == 13)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.kingSpades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.kingSpades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.kingSpades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.kingSpades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.kingSpades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.kingSpades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.kingSpades;
                                break;
                        }
                    }
                    else if (value == 14)
                    {
                        switch (CardToDraw)
                        {
                            case 1:
                                p1Card1.Image = TexasHoldEmPoker.Properties.Resources.aceSpades;
                                break;
                            case 2:
                                p1Card2.Image = TexasHoldEmPoker.Properties.Resources.aceSpades;
                                break;
                            case 3:
                                flopCard1.Image = TexasHoldEmPoker.Properties.Resources.aceSpades;
                                break;
                            case 4:
                                flopCard2.Image = TexasHoldEmPoker.Properties.Resources.aceSpades;
                                break;
                            case 5:
                                flopCard3.Image = TexasHoldEmPoker.Properties.Resources.aceSpades;
                                break;
                            case 6:
                                turnCard.Image = TexasHoldEmPoker.Properties.Resources.aceSpades;
                                break;
                            case 7:
                                riverCard.Image = TexasHoldEmPoker.Properties.Resources.aceSpades;
                                break;
                        }
                    }
                    break;

            }
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            Call(1);
        }

        private void Turns()
        {
           for (int i = 1; i >=  turnOrder.Count; i++)
            {
                if (i > 4)
                {
                    i = 1;
                }
            }
        }
    }

}
