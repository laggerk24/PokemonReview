using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int pokeid);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeid);
        bool PokemonExists(int pokeid);

    }
}
