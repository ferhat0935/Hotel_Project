﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangedApproved(Booking booking);

        void TBookingStatusChangedRejected(Booking booking);

        void TBookingStatusChangedWaited(Booking booking);

     
    }
}
