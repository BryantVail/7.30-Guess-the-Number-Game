using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryantVNumberGuess7_30
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessThatNumber NumberGame = new GuessThatNumber();
            bool Infinite = false;
            while ( Infinite == false)
            {
            GuessMessage.WelcomeMessage();
            GuessMessage.letsPlay();
            NumberGame.RandGenerator();

                
            while(NumberGame.GuessCorrect == false)
            {
                GuessMessage.GuessNumber();
                
                string userInput ;
                userInput = Console.ReadLine();
                NumberGame.NumberGuess(userInput);

            }
            }
            
           

        }
    }

    

}
