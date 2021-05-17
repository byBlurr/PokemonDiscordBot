using Newtonsoft.Json;
using PokemonDiscordBot.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonDiscordBot.Objects
{
    public class Pokemon
    {

        // Main info
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dex_number")]
        public int DexNumber { get; set; }

        [JsonProperty("name.en")]
        public string DisplayName { get; set; }

        [JsonProperty("name.ja")]
        public string DisplayNameJap { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type.0")]
        public Types PrimaryType { get; set; }

        [JsonProperty("type.1")]
        public Types SecondaryType { get; set; }

        // Other Info
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("catchable")]
        public bool Catchable { get; set; }

        [JsonProperty("abundance")]
        public int Abundance { get; set; }

        [JsonProperty("mythical")]
        public bool Mythical { get; set; }

        [JsonProperty("legendary")]
        public bool Legendary { get; set; }

        [JsonProperty("ultra_beast")]
        public bool UltraBeast { get; set; }

        [JsonProperty("event")]
        public bool Event { get; set; }


        // Stats
        [JsonProperty("base.hp")]
        public int BaseHealth { get; set; }

        [JsonProperty("base.atk")]
        public int BaseAttack { get; set; }

        [JsonProperty("base.def")]
        public int BaseDefence { get; set; }

        [JsonProperty("base.satk")]
        public int BaseSpecialAttack { get; set; }

        [JsonProperty("base.sdef")]
        public int BaseSpecialDefence { get; set; }

        [JsonProperty("base.speed")]
        public int BaseSpeed { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }


        // Evolution
        [JsonProperty("evo.to")]
        public string EvolveTo { get; set; } // String because some have multiple, need to turn into int[] but this needs to be done in data file first

        [JsonProperty("evo.from")]
        public int EvolveFrom { get; set; }

        [JsonProperty("evo.mega")]
        public int EvolveMega { get; set; }

        [JsonProperty("evo.mega_x")]
        public int EvolveMegaX { get; set; }

        [JsonProperty("evo.mega_y")]
        public int EvolveMegaY { get; set; }
    }
}
