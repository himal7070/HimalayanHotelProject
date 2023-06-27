using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesBLL
{
    public interface IGuestBLL
    {
        bool AddGuest(Guest guest);
        bool UpdateGuest(Guest guest, string guestId);
        bool DeleteGuest(string strGuestID);
        DataTable GetAllGuestInfo();
        bool UpdateGuestReserStatus(string guestId);
        bool UpdateGuestStatus(int guestId);
        List<int> GetAvailableGuestIds();
        Guest GetGuestDetails(int guestPersonId);
    }
}
