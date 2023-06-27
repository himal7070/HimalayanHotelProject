using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace BusinessLogicLayer.BLL
{
    public class RoomBLL : IRoomBLL
    {
        private IRoomDAL roomDAL;

        public RoomBLL(IRoomDAL roomDAL)
        {
            this.roomDAL = roomDAL;
        }

        public bool AddRoom(Room room)
        {
            try
            {
                return roomDAL.AddRoom(room);
            }
            catch (Exception) { throw; }
        }

        public bool UpdateRoom(Room Room, int roomId)
        {
            try
            {
                return roomDAL.UpdateRoom(Room, roomId);
            }
            catch (Exception) 
            { 
                throw; 
            }
        }

        public bool DeleteRoom(int roomId)
        {
            try
            {
                return roomDAL.DeleteRoom(roomId);
            }
            catch (Exception)
            {
                throw;
            }
        }      

        public List<string> GetRoomTypeName()
        {
            try
            {
                return roomDAL.GetRoomTypeName();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DataTable GetAllRooms()
        {
            try
            {
                return roomDAL.GetAllRooms();
            }
            catch (Exception) { throw; }
        }


        public bool UpdateRoomStatusNo(int roomId)
        {
            try
            {
                return roomDAL.UpdateRoomStatusNo(roomId);
            }
            catch (Exception) { throw; }
        }


        public bool UpdateRoomStatusYes(int roomId)
        {
            try
            {
                return roomDAL.UpdateRoomStatusYes(roomId);
            }
            catch (Exception) { throw; }
        }

        public List<Tuple<string, string, string, int, DateTime, DateTime, double>> GetRoomsByBookingId(int bookingId)
        {
            try
            {
                return roomDAL.GetRoomsByBookingId(bookingId);
            }
            catch (Exception)
            {

                throw;
            }
            
        }


    }
}
