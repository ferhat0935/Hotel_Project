﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

       

        public void TBookingStatusChangedApproved(Booking booking)
        {
            _bookingDal.BookingStatusChangedApproved(booking);
        }

        public void TBookingStatusChangedRejected(Booking booking)
        {
            _bookingDal.BookingStatusChangedRejected(booking);
        }

        public void TBookingStatusChangedWaited(Booking booking)
        {
            _bookingDal.BookingStatusChangedWaited(booking);
        }

        public void TDelete(Booking t)
        {
           _bookingDal.Delete(t);   
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

      
        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
