using Newtonsoft.Json;
using PokemonDiscordBot.Entities;
using PokemonDiscordBot.Objects;
using System;
using System.IO;

namespace PokemonDiscordBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load all pokemon ig...");

            Pokemons.Init();
        }
    }
}
