using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
 
        // member variables
        public Player player1;
        public Player player2;
        // constructor
        public Game()
        {
            //Player.Game player1; 

        }

        public void RunGame() 
        {
            DisplayRules();
            GetPlayer();
            string playerOneMove = player1.ChooseMove();
            string playerTwoMove = player2.ChooseMove();
            compareUserMoves(playerOneMove, playerTwoMove);

           // callChamp();
            
        }
        // member methods
        public void DisplayRules()
        {
            Console.WriteLine("Welcome To Rock, Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("Here Are The Rules");
            Console.WriteLine("The rules follow the same rules as Rock, Paper, Scissors, except with a few caveats thrown in.");
            Console.WriteLine("Rock beats (or smashes) scissoras as always.");
            Console.WriteLine("Scissors beats (or cuts) paper");
            Console.WriteLine("Paper beats (or covers) rock.");
            Console.WriteLine("Rock also crushes Lizard in addition to smashing scissors.");
            Console.WriteLine("Scissors cuts Lizard in addition to cutting paper.");
            Console.WriteLine("Paper beats (or disproves) Spock in addition to covering Rock");
            Console.WriteLine("Spock beats (or vaporizes) Rock");
            Console.WriteLine("Spock beats (or smashes) Scissors");
            Console.WriteLine("Lizard beats (or poisons) Spock");
            Console.WriteLine("Lizard beats (or eats) Paper.");
            Console.WriteLine("... Good Luck ...");
        }

        public void GetPlayer()
            
        {
            //userInput
            Console.WriteLine("How many Players? [1] Human vs Human, [2] Human vs AI");
            string userInput = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Name If You Want To Play");
            if (userInput == "2")
            {
                player1 = new Player();
                player2 = new Player();

            }
            else if (userInput == "1")
            {
                player1 = new Player();
                player2 = new AI();
            }
            else
            {
                Console.WriteLine("Sorry. Only 2 players per game.");
                GetPlayer();
            }
        }
       // public string getScore(playerOneMove, playerTwoMove)
         //   {

           // }

        public void compareUserMoves(string playerOneMove, string playerTwoMove)
        {
            switch (playerOneMove)
            {
                case "Rock":
                    if (playerOneMove == playerTwoMove)
                    {
                        Console.WriteLine("Tie");
                    }
                    else if (playerTwoMove == "Paper")
                    {
                        player2.score++;
                       Console.WriteLine("Paper Covers Rock! " + player2.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Scissors")
                    {
                        player1.score++;
                        Console.WriteLine("Rock Smashes Scissors! " + player1.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Lizard")
                    { 
                        player1.score++;
                        Console.WriteLine("Rock Smashes Lizard! " + player1.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Spock")
                    {
                        player2.score++;
                        Console.WriteLine("Spock Vaporizes Rock! " + player2.userName + "Wins!");
                    }
                    break;
                case "Paper":
                    if (playerOneMove == playerTwoMove)
                    {
                        Console.WriteLine("Tie!");
                    }
                    else if (playerTwoMove == "Rock")
                    {
                        player1.score++;
                        Console.WriteLine("Paper Covers Rock! " + player1.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Scissors")
                    {
                        player2.score++;
                        Console.WriteLine("Scissors Cuts Paper! " + player2.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Lizard")
                    {
                        player1.score++;
                        Console.WriteLine("Lizard Eats Paper! " + player1.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Spock")
                    {
                        player2.score++;
                        Console.WriteLine("Spock Vaporizes Paper! " + player2.userName + "Wins!");
                    }
                    break;

                case "Scissors":
                    if (playerOneMove == playerTwoMove)
                    {
                        Console.WriteLine("Tie!");
                    }
                    else if (playerTwoMove == "Rock")
                    {
                        player2.score++;
                        Console.WriteLine("Rock Smashes Scissors! " + player2.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Paper")
                    {
                        player1.score++;
                        Console.WriteLine("Scissors Cuts Paper! " + player1.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Lizard")
                    {
                        player1.score++;
                        Console.WriteLine("Scissors Cuts Lizard! " + player1.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Spock")
                    {
                        player2.score++;
                        Console.WriteLine("Spock Smashes Scissors! " + player2.userName + "Wins!");
                    }

                    break;
                case "Lizard":
                    if (playerOneMove == playerTwoMove)
                    {
                        Console.WriteLine("Tie!");
                    }
                    else if (playerTwoMove == "Rock")
                    {
                        player2.score++;
                        Console.WriteLine("Rock Smashes Lizard! " + player2.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Paper")
                    {
                        player1.score++;
                        Console.WriteLine("Lizard Eats Paper! " + player1.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Scissors")
                    {
                        player2.score++;
                        Console.WriteLine("Scissors Cuts Lizard! " + player2.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Spock")
                    {
                        player1.score++;
                        Console.WriteLine("Lizard Poisons Spock! " + player1.userName + "Wins!");
                    }

                    break;
                case "Spock":
                    if (playerOneMove == playerTwoMove)
                    {
                        Console.WriteLine("Tie!");
                    }
                    else if (playerTwoMove == "Rock")
                    {
                        player1.score++;
                        Console.WriteLine("Spock Vaporizes Rock! " + player1.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Paper")
                    {
                        player2.score++;
                        Console.WriteLine("Paper Disproves Spock! " + player2.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Scissors")
                    {
                        player1.score++;
                        Console.WriteLine("Spock Smashes Scissors! " + player1.userName + "Wins!");
                    }
                    else if (playerTwoMove == "Lizard")
                    {
                        player2.score++;
                        Console.WriteLine("Lizard Poisons Spock! " + player2.userName + "Wins!");
                    }

                    break;

                    if(player1.score == 2)
                    {
                        Console.WriteLine("Congrats " + player1.userName + " ! You Won!");
                    }
                    else
                    {
                        Console.WriteLine("Congrats " + player2.userName + " ! You Won!");
                    }

                    

                  //  public int callChamp;

                    // if (player1.score = 3);
                   // {
                       // Console.WriteLine(player1 + " Is The Champ!");
                    // }
                    // else 
                    // {
                      //  Console.WriteLine(player2 + " Is The Champ!");
                    // }
                    //"Rock, Lizard, Scissors":
                    //Console.WriteLine("Rock beats

            }


        }

    }
}



// if-else statement
//if (condition)
//{
//    then-statement;
//}
//else
//{
//    else-statement;
//}
//// Next statement in the program.

//// if statement without an else
//if (condition)
//{
//    then-statement;
//}
//// Next statement in the program.