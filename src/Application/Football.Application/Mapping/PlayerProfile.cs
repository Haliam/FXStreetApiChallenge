using AutoMapper;
using Football.Application.CQRS.Commands;
using Football.Application.CQRS.Queries;
using Football.Application.CQRS.Responses;
using Football.Domain.Models;

namespace Football.Application.Mapping
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<Player, CreatePlayerCommand>().ReverseMap();
            CreateMap<Player, CreatePlayerResponse>().ReverseMap();

            CreateMap<Player, GetPlayerByIdQuery>().ReverseMap();
            CreateMap<Player, GetPlayerByIdResponse>().ReverseMap();
        }
    }
}
