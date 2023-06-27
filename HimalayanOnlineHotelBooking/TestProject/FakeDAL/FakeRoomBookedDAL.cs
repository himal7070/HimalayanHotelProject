using BusinessLogicLayer.InterfacesDAL;

namespace DataAccessLayer.FakeDAL
{
    public class FakeRoomBookedDAL : IRoomBookedDAL
    {
        private Dictionary<int, int> roomBookings;

        public FakeRoomBookedDAL()
        {
            roomBookings = new Dictionary<int, int>();
        }

        public void InsertRoomBooked(int roomId, int bookingId)
        {
            roomBookings[bookingId] = roomId;
        }

        public int GetRoomId(int bookingId)
        {
            if (roomBookings.ContainsKey(bookingId))
            {
                return roomBookings[bookingId];
            }

            //return a default value (0 in this case) if the booking doesn't exist
            return 0;
        }
    }
}
