using System;
using System.Collections.Generic;
using System.Text;

namespace Playing_Dice
{
    class TenSided  : GoodDice
    {
        public override int Num //2
        { 
            get { return _Num;  }   //2b
            set     //2c
            { 
                if((value > 0) && (value <= 10))    //2c - 1
                {
                    _Num = value;
                }
                else        //2c - 2
                {
                    throw new Exception("Bad number : " + value);
                }
            }
        }// end of Num
        public override void GenerateNumber()
        {
            Num = random.Next(1, 10);   //changes array from 1, 6 to 1, 10 increasing the die by 4
        }// end of GenerateNumber
        public TenSided(string inColour) : base(inColour)
        {
            GenerateNumber();
        }
    }// end of class
}// end of namespace
