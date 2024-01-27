using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
       

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }

        [HttpPut("ApprovedBookingStatus")]
        public IActionResult ApprovedBookingStatus(Booking booking)
        {
            _bookingService.TBookingStatusChangedApproved(booking);
            return Ok();
        }

        [HttpPut("RejectedBookingStatus")]
        public IActionResult RejectedBookingStatus(Booking booking)
        {
            _bookingService.TBookingStatusChangedRejected(booking);
            return Ok();
        }

        [HttpPut("WaitedBookingStatus")]
        public IActionResult WaitedBookingStatus(Booking booking)
        {
            _bookingService.TBookingStatusChangedWaited(booking);
            return Ok();
        }


     

    }
}
