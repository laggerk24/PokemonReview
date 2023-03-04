using PokemonReview.Data;
using PokemonReview.Interfaces;
using PokemonReview.Models;

namespace PokemonReview.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) 
        {
            _context= context;
        }
        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }

        public Pokemon GetPokemon(int pokeid)
        {
            return _context.Pokemons.Where(p => p.Id == pokeid).FirstOrDefault();

        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemons.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeid)
        {
            var reviews = _context.Reviews.Where(p => p.Id == pokeid);
            if(reviews.Count() <=0 ) 
            {
                return 0;
            }
            return((decimal)reviews.Sum(review => review.Rating)/reviews.Count());
        }

        public bool PokemonExists(int pokeid)
        {
            return _context.Pokemons.Any(p=>p.Id== pokeid);
           
        }
    }
}
