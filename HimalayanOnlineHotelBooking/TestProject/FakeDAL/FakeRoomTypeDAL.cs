using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;


namespace DataAccessLayer.FakeRoomTypeDAL
{
    public class FakeRoomTypeDAL : IRoomTypeDAL
    {
        public bool AddRoomType(RoomType roomType)
        {
            return true;
        }

        public DataTable GetAllRoomTypes()
        {
            return new DataTable();
        }

        public bool UpdateRoomType(RoomType roomType, int roomTypeID)
        {
            return true;
        }

        public bool DeleteRoomType(string roomTypeId)
        {
            return true;
        }

        public int GetRoomTypeIdByName(string name)
        {
            return 0;
        }

        public int GetRoomIdByName(string name)
        {
            return 0;
        }

        public List<string> GetDistinctRoomTypesForHotel()
        {
            return new List<string>();
        }

        public double GetCost(string name)
        {
            return 0;
        }
    }
}
