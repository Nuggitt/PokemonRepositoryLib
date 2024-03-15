using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRepositoryLib
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            if (Name.Length < 2)
            {
                throw new ArgumentException("Name must be at least 2 characters long");
            }
        }


        public void ValidateType(string type)
        {
            switch (type.ToLower())
            {
                case "fire":
                case "water":
                case "grass":
                case "electric":
                case "rock":
                case "ground":
                case "ice":
                case "fairy":
                case "dragon":
                case "psychic":
                case "dark":
                case "ghost":
                case "normal":
                case "fighting":
                case "flying":
                case "poison":
                case "bug":
                case "steel":
                    break;
                default:
                    throw new ArgumentException("Invalid type: " + type);
            }
        }

        public override string ToString()
        {
            return $"{PokemonId} - {Name} - {Type}";
        }

        public void ValidatePokemon()
        {
            ValidateName();
            ValidateType(Type);
        }

    }
}
