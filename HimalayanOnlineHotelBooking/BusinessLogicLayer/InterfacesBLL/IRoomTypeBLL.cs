using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesBLL
{
    public interface IRoomTypeBLL
    {
        bool AddRoomType(RoomType roomType);
        bool UpdateRoomType(RoomType roomType, int roomTypeId);
        bool DeleteRoomType(string roomTypeId);
        DataTable GetAllRoomTypes();
        int GetRoomTypeIdByName(string name);
        int GetRoomIdByName(string name);
        List<string> GetRoomTypesForHotel();
        double GetCost(string name);
    }
}
