using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCountController : ControllerBase
    {

        private readonly IStaffService _staffService;

        private readonly IRoomService _roomService;

        private readonly IGuestService _guestService;

        private readonly Context _context;

        public GetCountController(Context context, IStaffService staffService, IRoomService roomService, IGuestService guestService)
        {
            _context = context;
            _staffService = staffService;
            _roomService = roomService;
            _guestService = guestService;
        }


        [HttpGet]
        public IActionResult GetCount()
        {
            var room = _roomService.TGetRoomCount();
        
            var value = _staffService.TGetStaffCount();
            var guest = _guestService.TGetCustomerCount();
            var result = new
            {
                RoomCount = room,
                StaffCount = value,
                GuestCount = guest,
            };
            return Ok(result);

        }
    }
}
