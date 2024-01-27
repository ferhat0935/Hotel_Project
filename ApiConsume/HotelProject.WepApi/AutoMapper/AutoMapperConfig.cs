using AutoMapper;
using HotelProject.DtoLayer.DTOS.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WepApi.AutoMapper
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto,Room>().ReverseMap();
            CreateMap<RoomUpdateDto,Room>().ReverseMap();   

          
        }
    }
}
