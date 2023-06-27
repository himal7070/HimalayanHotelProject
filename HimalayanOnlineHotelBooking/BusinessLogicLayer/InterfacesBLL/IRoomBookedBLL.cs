using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesBLL
{
    public interface IRoomBookedBLL
    {
        void InsertRoomBooking(int roomId, int bookingId);
        int GetRoomId(int bookingId);
    }
}
