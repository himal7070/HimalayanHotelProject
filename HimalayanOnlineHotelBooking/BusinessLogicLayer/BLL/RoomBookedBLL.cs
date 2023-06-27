using BusinessLogicLayer.InterfacesBLL;
using BusinessLogicLayer.InterfacesDAL;

namespace BusinessLogicLayer.BLL
{
    public class RoomBookedBLL : IRoomBookedBLL
    {
        private IRoomBookedDAL roomBookedDAL;

        public RoomBookedBLL(IRoomBookedDAL roomBookedDAL)
        {
            this.roomBookedDAL = roomBookedDAL;
        }

        public void InsertRoomBooking(int roomId, int bookingId)
        {
            try
            {
                roomBookedDAL.InsertRoomBooked(roomId, bookingId);
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        public int GetRoomId(int bookingId)
        {
            try
            {
                return roomBookedDAL.GetRoomId(bookingId);
            }
            catch (Exception)
            {
                throw;
            }
           
          
        }
    }
}
