using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IRoomTypeDAL
    {
        bool AddRoomType(RoomType roomType);
        DataTable GetAllRoomTypes();
        bool UpdateRoomType(RoomType roomType, int roomTypeID);
        bool DeleteRoomType(string roomTypeId);
        int GetRoomTypeIdByName(string name);
        int GetRoomIdByName(string name);
        List<string> GetDistinctRoomTypesForHotel();
        double GetCost(string name);
    }

}
