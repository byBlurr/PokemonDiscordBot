using Newtonsoft.Json;
using PokemonDiscordBot.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PokemonDiscordBot.Entities
{
    public class Pokemons
    {
        public static Pokemon[] Mons;

        public static void Init()
        {
            LoadPokemon();
        }

        private static void LoadPokemon()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "pokemon.json");
            if (File.Exists(path))
            {
                Mons = JsonConvert.DeserializeObject<Pokemon[]>(File.ReadAllText(path));
            }
        }
    }
}
