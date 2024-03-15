using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRepositoryLib
{
    public class PokemonRepository : IPokemonRepository
    {
        private int _nextId = 152;


        private List<Pokemon> _pokemons = new List<Pokemon>
        {
            new Pokemon { PokemonId = 1, Name = "Bulbasaur", Type = "Grass" },
            new Pokemon { PokemonId = 2, Name = "Ivysaur", Type = "Grass" },
            new Pokemon { PokemonId = 3, Name = "Venusaur", Type = "Grass" },
            new Pokemon { PokemonId = 4, Name = "Charmander", Type = "Fire" },
            new Pokemon { PokemonId = 5, Name = "Charmeleon", Type = "Fire" },
            new Pokemon { PokemonId = 6, Name = "Charizard", Type = "Fire" },
            new Pokemon { PokemonId = 7, Name = "Squirtle", Type = "Water" },
            new Pokemon { PokemonId = 8, Name = "Wartortle", Type = "Water" },
            new Pokemon { PokemonId = 9, Name = "Blastoise", Type = "Water" },
            new Pokemon { PokemonId = 10, Name = "Caterpie", Type = "Bug" },
            new Pokemon { PokemonId = 11, Name = "Metapod", Type = "Bug" },
            new Pokemon { PokemonId = 12, Name = "Butterfree", Type = "Bug" },
            new Pokemon { PokemonId = 13, Name = "Weedle", Type = "Bug" },
            new Pokemon { PokemonId = 14, Name = "Kakuna", Type = "Bug" },
            new Pokemon { PokemonId = 15, Name = "Beedrill", Type = "Bug" },
            new Pokemon { PokemonId = 16, Name = "Pidgey", Type = "Normal" },
            new Pokemon { PokemonId = 17, Name = "Pidgeotto", Type = "Normal" },
            new Pokemon { PokemonId = 18, Name = "Pidgeot", Type = "Normal" },
            new Pokemon { PokemonId = 19, Name = "Rattata", Type = "Normal" },
            new Pokemon { PokemonId = 20, Name = "Raticate", Type = "Normal" },
            new Pokemon { PokemonId = 21, Name = "Spearow", Type = "Normal" },
            new Pokemon { PokemonId = 22, Name = "Fearow", Type = "Normal" },
            new Pokemon { PokemonId = 23, Name = "Ekans", Type = "Poison" },
            new Pokemon { PokemonId = 24, Name = "Arbok", Type = "Poison" },
            new Pokemon { PokemonId = 25, Name = "Pikachu", Type = "Electric" },
            new Pokemon { PokemonId = 26, Name = "Raichu", Type = "Electric" },
            new Pokemon { PokemonId = 27, Name = "Sandshrew", Type = "Ground" },
            new Pokemon { PokemonId = 28, Name = "Sandslash", Type = "Ground" },
            new Pokemon { PokemonId = 29, Name = "Nidoran♀", Type = "Poison" },
            new Pokemon { PokemonId = 30, Name = "Nidorina", Type = "Poison" },
            new Pokemon { PokemonId = 31, Name = "Nidoqueen", Type = "Poison" },
            new Pokemon { PokemonId = 32, Name = "Nidoran♂", Type = "Poison" },
            new Pokemon { PokemonId = 33, Name = "Nidorino", Type = "Poison" },
            new Pokemon { PokemonId = 34, Name = "Nidoking", Type = "Poison" },
            new Pokemon { PokemonId = 35, Name = "Clefairy", Type = "Fairy" },
            new Pokemon { PokemonId = 36, Name = "Clefable", Type = "Fairy" },
            new Pokemon { PokemonId = 37, Name = "Vulpix", Type = "Fire" },
            new Pokemon { PokemonId = 38, Name = "Ninetales", Type = "Fire" },
            new Pokemon { PokemonId = 39, Name = "Jigglypuff", Type = "Normal" },
            new Pokemon { PokemonId = 40, Name = "Wigglytuff", Type = "Normal" },
            new Pokemon { PokemonId = 41, Name = "Zubat", Type = "Poison" },
            new Pokemon { PokemonId = 42, Name = "Golbat", Type = "Poison" },
            new Pokemon { PokemonId = 43, Name = "Oddish", Type = "Grass" },
            new Pokemon { PokemonId = 44, Name = "Gloom", Type = "Grass" },
            new Pokemon { PokemonId = 45, Name = "Vileplume", Type = "Grass" },
            new Pokemon { PokemonId = 46, Name = "Paras", Type = "Bug" },
            new Pokemon { PokemonId = 47, Name = "Parasect", Type = "Bug" },
            new Pokemon { PokemonId = 48, Name = "Venonat", Type = "Bug" },
            new Pokemon { PokemonId = 49, Name = "Venomoth", Type = "Bug" },
            new Pokemon { PokemonId = 50, Name = "Diglett", Type = "Ground" },
            new Pokemon { PokemonId = 51, Name = "Dugtrio", Type = "Ground" },
            new Pokemon { PokemonId = 52, Name = "Meowth", Type = "Normal" },
            new Pokemon { PokemonId = 53, Name = "Persian", Type = "Normal" },
            new Pokemon { PokemonId = 54, Name = "Psyduck", Type = "Water" },
            new Pokemon { PokemonId = 55, Name = "Golduck", Type = "Water" },
            new Pokemon { PokemonId = 56, Name = "Mankey", Type = "Fighting" },
            new Pokemon { PokemonId = 57, Name = "Primeape", Type = "Fighting" },
            new Pokemon { PokemonId = 58, Name = "Growlithe", Type = "Fire" },
            new Pokemon { PokemonId = 59, Name = "Arcanine", Type = "Fire" },
            new Pokemon { PokemonId = 60, Name = "Poliwag", Type = "Water" },
            new Pokemon { PokemonId = 61, Name = "Poliwhirl", Type = "Water" },
            new Pokemon { PokemonId = 62, Name = "Poliwrath", Type = "Water" },
            new Pokemon { PokemonId = 63, Name = "Abra", Type = "Psychic" },
            new Pokemon { PokemonId = 64, Name = "Kadabra", Type = "Psychic" },
            new Pokemon { PokemonId = 65, Name = "Alakazam", Type = "Psychic" },
            new Pokemon { PokemonId = 66, Name = "Machop", Type = "Fighting" },
            new Pokemon { PokemonId = 67, Name = "Machoke", Type = "Fighting" },
            new Pokemon { PokemonId = 68, Name = "Machamp", Type = "Fighting" },
            new Pokemon { PokemonId = 69, Name = "Bellsprout", Type = "Grass" },
            new Pokemon { PokemonId = 70, Name = "Weepinbell", Type = "Grass" },
            new Pokemon { PokemonId = 71, Name = "Victreebel", Type = "Grass" },
            new Pokemon { PokemonId = 72, Name = "Tentacool", Type = "Water" },
            new Pokemon { PokemonId = 73, Name = "Tentacruel", Type = "Water" },
            new Pokemon { PokemonId = 74, Name = "Geodude", Type = "Rock" },
            new Pokemon { PokemonId = 75, Name = "Graveler", Type = "Rock" },
            new Pokemon { PokemonId = 76, Name = "Golem", Type = "Rock" },
            new Pokemon { PokemonId = 77, Name = "Ponyta", Type = "Fire" },
            new Pokemon { PokemonId = 78, Name = "Rapidash", Type = "Fire" },
            new Pokemon { PokemonId = 79, Name = "Slowpoke", Type = "Water" },
            new Pokemon { PokemonId = 80, Name = "Slowbro", Type = "Water" },
            new Pokemon { PokemonId = 81, Name = "Magnemite", Type = "Electric" },
            new Pokemon { PokemonId = 82, Name = "Magneton", Type = "Electric" },
            new Pokemon { PokemonId = 83, Name = "Farfetch'd", Type = "Normal" },
            new Pokemon { PokemonId = 84, Name = "Doduo", Type = "Normal" },
            new Pokemon { PokemonId = 85, Name = "Dodrio", Type = "Normal" },
            new Pokemon { PokemonId = 86, Name = "Seel", Type = "Water" },
            new Pokemon { PokemonId = 87, Name = "Dewgong", Type = "Water" },
            new Pokemon { PokemonId = 88, Name = "Grimer", Type = "Poison" },
            new Pokemon { PokemonId = 89, Name = "Muk", Type = "Poison" },
            new Pokemon { PokemonId = 90, Name = "Shellder", Type = "Water" },
            new Pokemon { PokemonId = 91, Name = "Cloyster", Type = "Water" },
            new Pokemon { PokemonId = 92, Name = "Gastly", Type = "Ghost" },
            new Pokemon { PokemonId = 93, Name = "Haunter", Type = "Ghost" },
            new Pokemon { PokemonId = 94, Name = "Gengar", Type = "Ghost" },
            new Pokemon { PokemonId = 95, Name = "Onix", Type = "Rock" },
            new Pokemon { PokemonId = 96, Name = "Drowzee", Type = "Psychic" },
            new Pokemon { PokemonId = 97, Name = "Hypno", Type = "Psychic" },
            new Pokemon { PokemonId = 98, Name = "Krabby", Type = "Water" },
            new Pokemon { PokemonId = 99, Name = "Kingler", Type = "Water" },
            new Pokemon { PokemonId = 100, Name = "Voltorb", Type = "Electric" },
            new Pokemon { PokemonId = 101, Name = "Electrode", Type = "Electric" },
            new Pokemon { PokemonId = 102, Name = "Exeggcute", Type = "Grass" },
            new Pokemon { PokemonId = 103, Name = "Exeggutor", Type = "Grass" },
            new Pokemon { PokemonId = 104, Name = "Cubone", Type = "Ground" },
            new Pokemon { PokemonId = 105, Name = "Marowak", Type = "Ground" },
            new Pokemon { PokemonId = 106, Name = "Hitmonlee", Type = "Fighting" },
            new Pokemon { PokemonId = 107, Name = "Hitmonchan", Type = "Fighting" },
            new Pokemon { PokemonId = 108, Name = "Lickitung", Type = "Normal" },
            new Pokemon { PokemonId = 109, Name = "Koffing", Type = "Poison" },
            new Pokemon { PokemonId = 110, Name = "Weezing", Type = "Poison" },
            new Pokemon { PokemonId = 111, Name = "Rhyhorn", Type = "Ground" },
            new Pokemon { PokemonId = 112, Name = "Rhydon", Type = "Ground" },
            new Pokemon { PokemonId = 113, Name = "Chansey", Type = "Normal" },
            new Pokemon { PokemonId = 114, Name = "Tangela", Type = "Grass" },
            new Pokemon { PokemonId = 115, Name = "Kangaskhan", Type = "Normal" },
            new Pokemon { PokemonId = 116, Name = "Horsea", Type = "Water" }, 
            new Pokemon { PokemonId = 117, Name = "Seadra", Type = "Water" },
            new Pokemon { PokemonId = 118, Name = "Goldeen", Type = "Water" },
            new Pokemon { PokemonId = 119, Name = "Seaking", Type = "Water" },
            new Pokemon { PokemonId = 120, Name = "Staryu", Type = "Water" },
            new Pokemon { PokemonId = 121, Name = "Starmie", Type = "Water" },
            new Pokemon { PokemonId = 122, Name = "Mr. Mime", Type = "Psychic" },
            new Pokemon { PokemonId = 123, Name = "Scyther", Type = "Bug" },
            new Pokemon { PokemonId = 124, Name = "Jynx", Type = "Ice" },
            new Pokemon { PokemonId = 125, Name = "Electabuzz", Type = "Electric" },
            new Pokemon { PokemonId = 126, Name = "Magmar", Type = "Fire" },
            new Pokemon { PokemonId = 127, Name = "Pinsir", Type = "Bug" },
            new Pokemon { PokemonId = 128, Name = "Tauros", Type = "Normal" },
            new Pokemon { PokemonId = 129, Name = "Magikarp", Type = "Water" },
            new Pokemon { PokemonId = 130, Name = "Gyarados", Type = "Water" },
            new Pokemon { PokemonId = 131, Name = "Lapras", Type = "Water" },
            new Pokemon { PokemonId = 132, Name = "Ditto", Type = "Normal" },
            new Pokemon { PokemonId = 133, Name = "Eevee", Type = "Normal" },
            new Pokemon { PokemonId = 134, Name = "Vaporeon", Type = "Water" },
            new Pokemon { PokemonId = 135, Name = "Jolteon", Type = "Electric" },
            new Pokemon { PokemonId = 136, Name = "Flareon", Type = "Fire" },
            new Pokemon { PokemonId = 137, Name = "Porygon", Type = "Normal" },
            new Pokemon { PokemonId = 138, Name = "Omanyte", Type = "Rock" },
            new Pokemon { PokemonId = 139, Name = "Omastar", Type = "Rock" },
            new Pokemon { PokemonId = 140, Name = "Kabuto", Type = "Rock" },
            new Pokemon { PokemonId = 141, Name = "Kabutops", Type = "Rock" },
            new Pokemon { PokemonId = 142, Name = "Aerodactyl", Type = "Rock" },
            new Pokemon { PokemonId = 143, Name = "Snorlax", Type = "Normal" },
            new Pokemon { PokemonId = 144, Name = "Articuno", Type = "Ice" },
            new Pokemon { PokemonId = 145, Name = "Zapdos", Type = "Electric" },
            new Pokemon { PokemonId = 146, Name = "Moltres", Type = "Fire" },
            new Pokemon { PokemonId = 147, Name = "Dratini", Type = "Dragon" },
            new Pokemon { PokemonId = 148, Name = "Dragonair", Type = "Dragon" },
            new Pokemon { PokemonId = 149, Name = "Dragonite", Type = "Dragon" },
            new Pokemon { PokemonId = 150, Name = "Mewtwo", Type = "Psychic" },
            new Pokemon { PokemonId = 151, Name = "Mew", Type = "Psychic" }
        };


        public List<Pokemon> GetAll()
        {
            return new List<Pokemon>(_pokemons);
        }

        public IEnumerable<Pokemon> Get(string? type = null, string? nameIncludes = null, string? sortBy = null)
        {
            IEnumerable<Pokemon> result = new List<Pokemon>(_pokemons);

            if (!string.IsNullOrEmpty(type))
            {
                result = result.Where(b => b.Type.Equals(type, StringComparison.OrdinalIgnoreCase)); // Filtering by Type
            }

            if (!string.IsNullOrEmpty(nameIncludes))
            {
                result = result.Where(b => b.Name.IndexOf(nameIncludes, StringComparison.OrdinalIgnoreCase) >= 0); // The StringComparison.OrdinalIgnoreCase flag ensures a case-insensitive search
            }


            if (sortBy != null)
            {
                sortBy = sortBy.ToLower();
                switch (sortBy)
                {
                    case "name":
                        result = result.OrderBy(b => b.Name); //Sorting by name
                        break;
                    case "name_desc":
                        result = result.OrderByDescending(b => b.Name); //Sorting by name descending
                        break;
                    case "type":
                        result = result.OrderBy(b => b.Type); //Sorting by ABV
                        break;
                    case "type_desc":
                        result = result.OrderByDescending(b => b.Type); //Sorting by ABV descending
                        break;
                    case "id":
                        result = result.OrderBy(b => b.PokemonId); //Sorting by id
                        break;
                    case "id_desc":
                        result = result.OrderByDescending(b => b.PokemonId); //Sorting by id descending
                        break;
                    default:
                        break;

                }
            }
            return result.ToList();
        }

        public Pokemon? GetPokemonById(int id)
        {
            return _pokemons.FirstOrDefault(b => b.PokemonId == id);
        }

        public Pokemon Add(Pokemon pokemon)
        {
            pokemon.ValidatePokemon();
            pokemon.PokemonId = _nextId++;
            _pokemons.Add(pokemon);
            return pokemon;
        }

        public Pokemon? Remove(int id)
        {
            Pokemon? pokemon = _pokemons.FirstOrDefault(b => b.PokemonId == id);
            if (pokemon == null)
            {
                return null;
            }
            _pokemons.Remove(pokemon);
            return pokemon;
        }

        public Pokemon? Update(int id, Pokemon pokemon)
        {
            pokemon.ValidatePokemon();
            Pokemon? pokemonToUpdate = GetPokemonById(id);
            if (pokemonToUpdate == null)
            {
                return null;
            }
            pokemonToUpdate.Name = pokemon.Name;
            pokemonToUpdate.Type = pokemon.Type;
            return pokemonToUpdate;
        }

        public override string ToString()
        {
            return string.Join("\n", _pokemons);
        }


    }
}
