using AutoMapper;
using PokemonReview.Dto;
using PokemonReview.Models;

namespace PokemonReview.Mappper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
