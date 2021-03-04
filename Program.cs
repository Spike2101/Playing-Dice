using System;

namespace Playing_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            playCards_Test();
            Console.ReadKey();
        }
       
        static private void playGame1_V1()
        {
            int result1 = 0; int result2 = 0;       // 1
            try     // 2
            {
                BadDice player1;    //3a
                player1 = new BadDice();    //3b
                player1.Num = 4;    //4a
                player1.Colour = "Green";   //4b
                result1 = player1.Num;      //5a
                Console.WriteLine("Player 1 rolled " + result1 + " on " + player1.Colour + " die"); //5b

                BadDice player2 = new BadDice();    //3
                player2.Num = -2;   //4a
                player2.Colour = "gggggggggggggaaaaaaaaaaaaaawwwwwwwwwwwwwwwrrrrrrrrrrrr";  //4b
                result2 = player2.Num;  //5a
                Console.WriteLine("Player 2 rolled " + result2 + " on " + player2.Colour + " die"); //5b
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error " + e.Message);    //2b
            }
        }// end of playGame1_V1

        static private void playGame1_V2()  //1
        {
            int result1 = 0;
            try     //2
            {
                GoodDice player1 = new GoodDice();  //3
                player1.Num = 0;    //4
                player1.Colour = "asedgfvfSDFDVSSDVsfvd£";  //4b
                player1.GenerateNumber();   //4c
                result1 = player1.Num;  //5
                Console.WriteLine("Player 1 rolled " + player1.Colour + " " + player1.Num); //5b
                Console.WriteLine("Player 1 rolled " + player1.ToString()); //5c
            }
            catch (Exception e)
            {

                Console.WriteLine("Error " + e.Message);    //2b
            }
        }// end of playGame1_V2
        static private void playGame1_V3()
        {
            int result1, result2 = 0; //1
            try     //2
            {
                GoodDice player1;
                player1 = new GoodDice("Blue"); //3
                result1 = player1.Num;  //4
                
                GoodDice player2;
                player2 = new GoodDice("Red");  //3
                result2 = player2.Num;  //4

                if (player1.Num > player2.Num)
                {
                    Console.WriteLine("Player 1 rolled " + player1.ToString());
                }
                else 
                {
                    Console.WriteLine("Player 2 rolled " + player2.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }// end of playGame1_V3
        static private void playGame2_TenSided()
        {
            int result1, result2 = 0; //1
            try     //2
            {
                TenSided player1;
                player1 = new TenSided("Blue"); //3
                result1 = player1.Num;  //4

                TenSided player2;
                player2 = new TenSided("Red");  //3
                result2 = player2.Num;  //4

                if (player1.Num > player2.Num)
                {
                    Console.WriteLine("Player 1 rolled " + player1.ToString());
                }
                else
                {
                    Console.WriteLine("Player 2 rolled " + player2.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }// end of playGame2_TenSided
        static private void playCards_Test()
        {
            try 
            {
                Console.WriteLine("Playing Card game one");
                PlayingCard player1;

                player1 = new PlayingCard(1, "Red", CardSuit.Clubs, CardName.King);
                Console.WriteLine("What is this? \n" + player1.ToString() + "\n");

                player1 = new PlayingCard(1, "Red", CardSuit.Clubs);
                Console.WriteLine("What is this? \n" + player1.ToString() + "\n");

                player1 = new PlayingCard(1, "Red", CardSuit.Clubs);
                Console.WriteLine("What is this? \n" + player1.ToString() + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }// end of playCards_Test
        static private void playCards_V1()
        {

            try
            {
                PlayingCard player1 = new PlayingCard("Red", CardSuit.Clubs);
                Console.WriteLine("Player 1 1 drew " + player1.ToString());

                PlayingCard player2 = new PlayingCard("Red", CardSuit.Clubs);
                Console.WriteLine("Player 3 1 drew " + player1.ToString());

                Console.WriteLine(FindWinner(player1, player2));

            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }
        private static string FindWinner(PlayingCard p1, PlayingCard p2)
        {
            string result = "";
            if(p1.Num > p2.Num)
            {
                result = String.Format("Player 1 won as {0} is worth more than {1}",  p1.Num, p2.Num);
            }
            else if(p1.Num < p2.Num)
            {
                result = String.Format("Player 1 won as {0} is worth more than {1}",  p1.Num, p2.Num);
            }
            else
            {
                result = String.Format("Draw as {0} matched {1}", p1.Num, p2.Num);
            }
        }
    }// end of Class
}// end of namespace
