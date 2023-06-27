using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesBLL
{
    public interface IRoomBLL
    {
        bool AddRoom(Room room);
        bool UpdateRoom(Room room, int roomId);
        bool DeleteRoom(int roomId);
        List<string> GetRoomTypeName();
        DataTable GetAllRooms();
        bool UpdateRoomStatusNo(int roomId);
        bool UpdateRoomStatusYes(int roomId);
        //List<Tuple<string, string, string>> GetRoomsByBookingId(int bookingId);

        List<Tuple<string, string, string, int, DateTime, DateTime, double>> GetRoomsByBookingId(int bookingId);

    }
}
