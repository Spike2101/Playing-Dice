using System;
using System.Collections.Generic;
using System.Text;

namespace Playing_Dice
{
    public enum CardSuit
    {
        Spades, Clubs, Diamonds, Hearts,
    }
    enum CardName
    {
        Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13,
    }
    class PlayingCard : GoodDice
    {
        public CardSuit Suit { get; set; }
        public CardName Name { get; set; }

        public override int Num 
        { 
            get { return _Num; }
            set
            {
                if((value > 0 ) && (value <= 13))
                {
                    _Num = value;
                }
                else
                {
                    throw new Exception("Bad number : " + value);
                }
            }
        }
        public override void GenerateNumber()
        {
            Num = random.Next(1, 13);
        }
        public override string ToString()
        {
            return this.Colour + " " + this.Name + " worth " + this.Num + " points";
        }
        public PlayingCard(int inNum, string inColour, CardSuit inSuit, CardName inName) : base(inNum, inColour)
        {
            Suit = inSuit;
            Name = inName;
        }
        public PlayingCard(int inNum, string inColour, CardSuit inSuit) : base(inNum, inColour)
        {
            Suit = inSuit;
            Name = (CardName)inNum;
        }
        public PlayingCard(string inColour, CardSuit inSuit) : base(inColour)
        {
            GenerateNumber();
            Suit = inSuit;
            Name = (CardName)base.Num;
        }
    }
}
