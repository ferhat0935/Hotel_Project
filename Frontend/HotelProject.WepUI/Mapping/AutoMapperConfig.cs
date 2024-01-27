using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WepUI.Dtos.AboutDto;
using HotelProject.WepUI.Dtos.BookingDto;
using HotelProject.WepUI.Dtos.ContactDto;

using HotelProject.WepUI.Dtos.LoginDto;
using HotelProject.WepUI.Dtos.RegisterDto;
using HotelProject.WepUI.Dtos.ServiceDto;
using HotelProject.WepUI.Dtos.SubscribeDto;

namespace HotelProject.WepUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<CreateNewUserDto,AppUser>().ReverseMap(); 
            CreateMap<LoginUserDto,AppUser>().ReverseMap(); 
            CreateMap<ResultAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();
            CreateMap<CreateSubscribeDto,Subscribe>().ReverseMap();
            CreateMap<CreateBookingDto,Booking>().ReverseMap();
            CreateMap<ResultBookingDto,Booking>().ReverseMap();
            CreateMap<ApprovedBookingDto,Booking>().ReverseMap();
            CreateMap<CreateContactDto,Contact>().ReverseMap();
          
        }
    }
}
