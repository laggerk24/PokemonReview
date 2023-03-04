using Microsoft.EntityFrameworkCore;
using PokemonReview.Data;
using PokemonReview.Interfaces;
using PokemonReview.Models;

namespace PokemonReview.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public bool CategoryExists(int categoryId)
        {
            return _context.Categories.Any(p => p.Id == categoryId);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.OrderBy(p => p.Id).ToList();
        }

        public Category GetCategory(int categoryId)
        {
            return _context.Categories.Where(p => p.Id == categoryId).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(p=>p.Id== categoryId).Select(c=>c.Pokemon).ToList();
        }
    }
}
