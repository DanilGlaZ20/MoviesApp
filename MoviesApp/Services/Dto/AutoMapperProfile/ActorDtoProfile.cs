using AutoMapper;
using MoviesApp.Models;
using MoviesApp.ViewModels;

namespace MoviesApp.Services.Dto.AutoMapperProfile
{
    public class ActorDtoProfile:Profile
    {
        public ActorDtoProfile()
        {
            CreateMap<Actor, ActorDto>().ReverseMap();
        }
    }
}