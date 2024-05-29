using AutoMapper;
using Hotels.Models;
using Hotels.ViewModel;

namespace Hotels.Mappers
{
    public class RoomProfile : Profile
    {
        public RoomProfile() 
        {
            CreateMap<Room, RoomViewModel>().ReverseMap();
        }
    }
}
