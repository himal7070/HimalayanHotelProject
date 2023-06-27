using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace BusinessLogicLayer.BLL
{
    public class GuestBLL : IGuestBLL
    {
        private IGuestDAL guestDAL;

        public GuestBLL(IGuestDAL guestDAL)
        {
            this.guestDAL = guestDAL;
        }

        public bool AddGuest(Guest guest)
        {
            try
            {
                return guestDAL.AddGuest(guest);
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        public bool UpdateGuest(Guest guest, string guestId)
        {
            try
            {
                return guestDAL.UpdateGuest(guest, guestId);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public bool DeleteGuest(string guestId)
        {
            try
            {
                return guestDAL.DeleteGuest(guestId);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public DataTable GetAllGuestInfo()
        {
            try
            {
                return guestDAL.GetAllGuestsInfo();
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        public bool UpdateGuestReserStatus(string guestId)
        {
            try
            {
                return guestDAL.UpdateGuestReserStatus(guestId);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public bool UpdateGuestStatus(int guestId)
        {
            try
            {
                return guestDAL.UpdateGuestStatus(guestId);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public List<int> GetAvailableGuestIds()
        {
            try
            {
                return guestDAL.GetAvailableGuestIds();
            }
            catch (Exception)
            {

                throw;
            }
           
         
        }

        public Guest GetGuestDetails(int guestPersonId)
        {
            try
            {
                return guestDAL.GetGuestDetails(guestPersonId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
