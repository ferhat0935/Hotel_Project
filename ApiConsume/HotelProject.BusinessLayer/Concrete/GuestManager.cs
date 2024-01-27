using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TDelete(Guest t)
        {
            throw new NotImplementedException();
        }

        public Guest TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public int TGetCustomerCount()
        {
            return _guestDal.GetCustomerCount();
        }

        public List<Guest> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Guest t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Guest t)
        {
            throw new NotImplementedException();
        }
    }
}
