using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IGuestDAL
    {
        bool AddGuest(Guest guest);
        bool UpdateGuest(Guest guest, string guestId);
        bool UpdateGuestReserStatus(string guestId);
        bool UpdateGuestStatus(int guestId);
        bool DeleteGuest(string strGuestId);
        List<int> GetAvailableGuestIds();
        DataTable GetAllGuestsInfo();
        Guest GetGuestDetails(int guestPersonId);

    }
}
