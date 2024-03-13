
namespace PokemonRepositoryLib
{
    public interface IPokemonRepository
    {
        Pokemon Add(Pokemon pokemon);
        IEnumerable<Pokemon> Get(string? type = null, string? nameIncludes = null, string? sortBy = null);
        List<Pokemon> GetAll();
        Pokemon? GetPokemonById(int id);
        Pokemon? Remove(int id);
        string ToString();
        Pokemon? Update(int id, Pokemon pokemon);
    }
}