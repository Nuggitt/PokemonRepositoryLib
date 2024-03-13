using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRepositoryLib
{
    public class PokemonRepository : IPokemonRepository
    {
        private int _nextId = 6;

        private List<Pokemon> _pokemons = new List<Pokemon>
        {
            new Pokemon { PokemonId = 1, Name = "Pikachu", Type = "Electric" },
            new Pokemon { PokemonId = 2, Name = "Charmander", Type = "Fire" },
            new Pokemon { PokemonId = 3, Name = "Bulbasaur", Type = "Grass" },
            new Pokemon { PokemonId = 4, Name = "Squirtle", Type = "Water" },
            new Pokemon { PokemonId = 5, Name = "Warturtle", Type = "Water" }
        };

        public List<Pokemon> GetAll()
        {
            return new List<Pokemon>(_pokemons);
        }

        public IEnumerable<Pokemon> Get(string? type = null, string? nameIncludes = null, string? sortBy = null)
        {
            IEnumerable<Pokemon> result = new List<Pokemon>(_pokemons);

            if (type != null)
            {
                result = result.Where(b => b.Type == type); //Filtering by ABV
            }
            if (nameIncludes != null)
            {
                result = result.Where(b => b.Name.Contains(nameIncludes)); //Filtering by name
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
