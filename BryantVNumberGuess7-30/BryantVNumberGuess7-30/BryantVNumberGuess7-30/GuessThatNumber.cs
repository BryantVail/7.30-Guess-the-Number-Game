using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryantVNumberGuess7_30
{
    class GuessThatNumber
    {
        
        protected bool guessCorrect = false;
        int guessCount = 0;
        public int randRange;
        protected int intRandRange;

        public void RandGenerator()
        {
                Random randNum = new Random();
                randRange = randNum.Next(1, 1000);
                intRandRange = randRange;
        }

        //Correct Guess Switch
        public bool GuessCorrect
        {
            get
            {
                return guessCorrect;
            }
            set
            {
                guessCorrect = value;
            }
        }

        public void NumberGuess(string numGuess)
        {
                

            try
            {
                //Validate Input
                double NumGuess = double.Parse(numGuess);
                

                //Logic for the guesses by user
                while (NumGuess != intRandRange )
                {
                    

                    if (NumGuess < 1)
                    {
                        Console.WriteLine("Out Of Range! Guess Again.");
                        break;
                        
                    }
                    else if (NumGuess < randRange)
                    { Console.WriteLine("Too Low, Try Again. {0}", randRange);
                    guessCount += 1;
                    break;
                    
                    }
                    else if (NumGuess > randRange)
                    { Console.WriteLine("Too High, Try Again.");
                    guessCount += 1;
                    break;
                    
                    }
                    else if (NumGuess == randRange)
                    {
                        guessCorrect = true;
                        guessCount += 1;
                        Console.WriteLine("Congratulations! You Guessed the number in {0} attempts!", guessCount);
                        break;
                    }
                }

            }
            catch
            {
                Console.WriteLine("Please select a proper value to guess the number");
            }
            
        
        
        }



    }

    class GuessMessage
    {
        static public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Guess That Number!");
        }

        static public void letsPlay()
        {
            Console.WriteLine("Lets Play! The number is between 1 & 1000");
        }

        static public void GuessNumber()
        {
            
            Console.WriteLine("Type in your guess");
        }

        
    }
}
