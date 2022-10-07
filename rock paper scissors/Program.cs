using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //here what wee need to cook game ;)

            Random random = new Random();   // random object
            bool playAgain = true;          // Y or N for play again While Loop
            String player;                   // will be used for player chose 
            String computer;                // will be used for computer choses 
            String answer;
                                            //-----------------------------------------------------------------------

            while (playAgain == true)                                   // creating while loop
            {
                player = "";            // assigne player empty chose
                computer = "";          // assigne computer  empty chose
                answer = "";            // assigne empty chose


                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")    // while to prevent diffrent input then game input!
                {
                    Console.WriteLine(" enter rock paper or scissors");     // ask for input
                    player = Console.ReadLine();                            // user input
                    player = player.ToUpper();                              //convert to UP LETTERS
                }
               
                switch(random.Next(1, 4))    //random for computer uisg switch methode   1 and 4 becouse is 1 and 3 need add 1 
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break ;
                    case 3:
                        computer = "SCISSORS";
                        break ;
                    default:
                        Console.WriteLine("sss");
                        break;
                }
                Console.WriteLine("Player: " + player);      // assigne player empty chose
                Console.WriteLine("computer" + computer);    // assigne computer empty chose

                switch (player)                 // exam who was the winner base on player chose. switch and if statmens
                {
                    case "ROCK":
                        if(computer == "ROCK")
                        {
                            Console.WriteLine("it a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("you lose");
                        }
                        else
                        {
                            Console.WriteLine("you won");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("it a draw");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("you lose");
                        }
                        else
                        {
                            Console.WriteLine("you won");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("it a draw");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("you lose");
                        }
                        else
                        {
                            Console.WriteLine("you won");
                        }
                        break;

                }


                Console.WriteLine("do you wont to continue game Y/N");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("thx for playing");

        }
    }
}
