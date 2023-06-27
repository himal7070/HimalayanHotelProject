using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IRoomBookedDAL
    {
        void InsertRoomBooked(int roomId, int bookingId);
        int GetRoomId(int bookingId);
    }
}
