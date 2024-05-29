using AutoMapper;
using Hotels.Models;
using Hotels.ViewModel;
using Microsoft.CodeAnalysis.Operations;

namespace Hotels.Mappers
{
    public class BooksProfile : Profile
    {
        public BooksProfile() 
        {
            CreateMap<Book, BooksListViewModel>()
                .ForMember(dest => dest.CustomerName, opt=>opt.MapFrom(src=>src.Customer.Name));
            CreateMap<Book, CreateBookViewModel>()
                .ForMember(dest => dest.BranchId, opt => opt.MapFrom(src => src.BranchId))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Customer.PhoneNumber))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
                .ForMember(dest => dest.NationalId, opt => opt.MapFrom(src => src.Customer.NationalId))
                /*.ForMember(dest => dest.Customer_Id, opt => opt.MapFrom(src => src.))*/
                .ForMember(dest => dest.rooms, opt => opt.MapFrom(src =>
                        src.Rooms.Select(i =>
                            new Room
                            {
                                AdultsNumber = i.AdultsNumber,
                                ChildrenNumber = i.ChildrenNumber,
                                RoomType = i.RoomType,
                                // Id = Guid.NewGuid().ToString(),
                                BookId = src.Id,
                            }).ToList()
                        )
                ).ReverseMap();


        }
    }
}
