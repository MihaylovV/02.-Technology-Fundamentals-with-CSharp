using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonDontGo
{
    class PokemonDontGo
    {
        static List<int> GetUserInputIntoList()
        {
            string input = Console.ReadLine();
            char[] separators = new char[] { ' ' };
            string[] inputArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<int> userNumbersList = new List<int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                userNumbersList.Add(int.Parse(inputArray[i]));
            }
            return userNumbersList;
        }

        static void Main()
        {
            List<int> pokemonList = GetUserInputIntoList();
            int sum = 0;

            bool isRunning = true;
            while (isRunning == true)
            {
                int index = int.Parse(Console.ReadLine());
                int capturedPokemon = 0;

                if (index >= 0 && index < pokemonList.Count)
                {
                    capturedPokemon = pokemonList[index];
                    sum += capturedPokemon;
                    pokemonList.RemoveAt(index);
                }
                else if (index < 0)
                {
                    sum += pokemonList[0];
                    capturedPokemon = pokemonList[0];
                    int temp = pokemonList[pokemonList.Count - 1];
                    pokemonList.RemoveAt(0);
                    pokemonList.Insert(0, temp);
                }
                else if (index >= pokemonList.Count)
                {
                    sum += pokemonList[pokemonList.Count - 1];
                    capturedPokemon = pokemonList[pokemonList.Count - 1];
                    int temp = pokemonList[0];
                    pokemonList.RemoveAt(pokemonList.Count - 1);
                    pokemonList.Add(temp);
                }

                for (int i = 0; i < pokemonList.Count; i++)
                {
                    if (pokemonList[i] <= capturedPokemon)
                    {
                        pokemonList[i] += capturedPokemon;
                    }
                    else if (pokemonList[i] > capturedPokemon)
                    {
                        pokemonList[i] -= capturedPokemon;
                    }
                }

                if (pokemonList.Count == 0)
                {
                    Console.WriteLine("{0}", sum);
                    isRunning = false;
                    break;
                }
            }
        }
    }
}
