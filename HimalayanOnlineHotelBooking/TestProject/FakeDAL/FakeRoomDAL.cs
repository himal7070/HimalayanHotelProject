using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace DataAccessLayer.FakeDAL
{
    public class FakeRoomDAL : IRoomDAL
    {
        public bool AddRoom(Room room)
        {
            return true;
        }

        public bool DeleteRoom(int roomId)
        {
            return true;
        }

        public DataTable GetAllRooms()
        {
            return new DataTable();
        }

        public List<string> GetRoomTypeName()
        {
            return new List<string>();
        }

        public bool UpdateRoom(Room room, int roomId)
        {
            return true;
        }

        public bool UpdateRoomStatusNo(int roomId)
        {
            return false;
        }

        public bool UpdateRoomStatusYes(int roomId)
        {
            return true;
        }

        public List<Tuple<string, string, string, int, DateTime, DateTime, double>> GetRoomsByBookingId(int bookingId)
        {
            List<Tuple<string, string, string, int, DateTime, DateTime, double>> roomList = new List<Tuple<string, string, string, int, DateTime, DateTime, double>>();

            roomList.Add(new Tuple<string, string, string, int, DateTime, DateTime, double>("Room1", "Standard", "Standard room description", 3, DateTime.Now, DateTime.Now.AddDays(3), 100.0));
            roomList.Add(new Tuple<string, string, string, int, DateTime, DateTime, double>("Room2", "Deluxe", "Deluxe room description", 5, DateTime.Now, DateTime.Now.AddDays(7), 200.0));
            roomList.Add(new Tuple<string, string, string, int, DateTime, DateTime, double>("Room3", "Suite", "Suite room description", 2, DateTime.Now, DateTime.Now.AddDays(2), 300.0));

            return roomList;
        }


    }
}
