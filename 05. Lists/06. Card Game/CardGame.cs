using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Card_Game
{
    class CardGame
    {
        static List<int> GetPlayerCardDeck()
        {
            string input = Console.ReadLine();
            char[] separators = new char[] { ' ' };
            string[] inputArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<int> playerCards = new List<int>();
            foreach (string card in inputArray)
            {
                playerCards.Add(int.Parse(card));
            }
            return playerCards;
        }

        static List<int> PlayGame(List<int> playerOneDeck, List<int> playerTwoDeck)
        {
            List<int> winningDeck = new List<int>();

            bool isWorking = true;
            while (isWorking == true)
            {
                if (playerOneDeck.Count <= 0 || playerTwoDeck.Count <= 0)
                {
                    if (playerOneDeck.Count != 0 && playerOneDeck.Count > playerTwoDeck.Count)
                    {
                        foreach (int card in playerOneDeck)
                        {
                            winningDeck.Add(card);
                        }
                        Console.Write("First player wins! Sum: ");
                    }
                    else if (playerTwoDeck.Count != 0 && playerOneDeck.Count < playerTwoDeck.Count)
                    {
                        foreach (int card in playerTwoDeck)
                        {
                            winningDeck.Add(card);
                        }
                        Console.Write("Second player wins! Sum: ");
                    }
                    else
                    {
                        foreach (int card in playerOneDeck)
                        {
                            winningDeck.Add(card);
                        }
                        Console.Write("First player wins! Sum: ");
                    }

                    isWorking = false;
                    break;
                }

                int playerOneCard = playerOneDeck.ElementAt(0);
                int playerTwoCard = playerTwoDeck.ElementAt(0);

                playerOneDeck.RemoveAt(0);
                playerTwoDeck.RemoveAt(0);

                if (playerOneCard > playerTwoCard)
                {
                    playerOneDeck.Add(playerOneCard);
                    playerOneDeck.Add(playerTwoCard);
                }
                else if (playerOneCard < playerTwoCard)
                {
                    playerTwoDeck.Add(playerTwoCard);
                    playerTwoDeck.Add(playerOneCard);
                }
            }

            return winningDeck;
        }

        static void PrintResults(List<int> winningDeck)
        {
            int sum = 0;
            foreach (int card in winningDeck)
            {
                sum += card;
            }
            Console.Write(sum);
            Console.WriteLine();
        }

        static void Main()
        {
            // Get Player One Cards Method
            List<int> playerOneDeck = GetPlayerCardDeck();

            // Get Player Two Cards Same Method
            List<int> playerTwoDeck = GetPlayerCardDeck();

            // Method To Playing the full game
            List<int> winningDeck = PlayGame(playerOneDeck, playerTwoDeck);
            // 
            // Method to Summing and Printing results
            PrintResults(winningDeck);
        }
    }
}
