﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal:GenericRepository<Booking>,IBookingDal
    {
        public EfBookingDal(Context context):base(context) 
        {
            
        }
                                                   
        public void BookingStatusChangedApproved(Booking booking)
        {
            var context = new Context();
           var values= context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            values.Status = "Onaylandı";
            context.Update(values);
            context.SaveChanges();
        }

        public void BookingStatusChangedRejected(Booking booking)
        {
            var context = new Context();
            var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            values.Status = "İptal Edildi";
            context.Update(values);
            context.SaveChanges();
        }

        public void BookingStatusChangedWaited(Booking booking)
        {
            var context = new Context();
            var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            values.Status = "Bekletiliyor";
            context.Update(values);
            context.SaveChanges();
        }

     
    }
}
