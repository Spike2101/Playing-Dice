using System;
using System.Collections.Generic;
using System.Text;

namespace Playing_Dice
{
    class GoodDice
    {
        protected int _Num;   //1
        protected string _Colour;
        public virtual int Num      //2
        {
            get { return _Num;  }  //2a
            set     //2b
            {
                if ((value > 0) && (value <= 6))    //2b-1
                {
                    this._Num = value;
                }
                else
                {
                    throw new Exception("Bad number : " + value); //2b-2
                }
            }
        }// end of Num
        public string Colour        //3
        {
            get     //3a
            {
                return _Colour;
            }
            set     //3b
            {
                if ((value.Length > 0) && (value.Length <= 10))     //3b-1
                {
                    this._Colour = value;
                }
                else    //3b-2
                {
                    throw new Exception("Bad number : " + value);
                }
            }
        }// end of colour
        public GoodDice()   //4
        {
            Num = 1;
            Colour = "Black";
        }// end of dice constructor

        public GoodDice(int inNum, string inColour)     //5
        {
            Num = inNum;
            Colour = inColour;
        }// end of Dice
        protected static Random random = new Random();      //6
        public virtual void GenerateNumber()    //6b
        {
            Num = random.Next(1, 6);    //6c
        }// end of GenerateNumber
        public GoodDice(string colour)  //8
        {
            GenerateNumber();
            Colour = colour;
        }// end of colour
        public override string ToString()   //9
        {
            return this.Colour + " " + this.Num;
        }// end of ToString
    }// end of class
}// end of namespace
