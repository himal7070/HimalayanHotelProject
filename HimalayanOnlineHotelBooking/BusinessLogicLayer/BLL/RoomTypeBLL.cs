using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace BusinessLogicLayer.BLL
{
    public class RoomTypeBLL : IRoomTypeBLL
    {
        private IRoomTypeDAL roomTypeDAL;

        public RoomTypeBLL(IRoomTypeDAL roomTypeDAL)
        {
            this.roomTypeDAL = roomTypeDAL;
        }



        public bool AddRoomType(RoomType roomType)
        {
            try
            {
                return roomTypeDAL.AddRoomType(roomType);
            }
            catch (Exception)
            {

                throw;
            }
         
         
        }


        public bool UpdateRoomType(RoomType roomType, int roomTypeId)
        {
            try
            {
                return roomTypeDAL.UpdateRoomType(roomType, roomTypeId);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public bool DeleteRoomType(string roomTypeId)
        {
            try
            {
                return roomTypeDAL.DeleteRoomType(roomTypeId);
            }
            catch (Exception)
            {

                throw;
            }
          
        }


        public DataTable GetAllRoomTypes()
        {
            try
            {
                return roomTypeDAL.GetAllRoomTypes();
            }
            catch (Exception)
            {

                throw;
            }
           
          
        }

        public int GetRoomTypeIdByName(string name)
        {
            try
            {
                return roomTypeDAL.GetRoomTypeIdByName(name);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public int GetRoomIdByName(string name)
        {
            try
            {
                return roomTypeDAL.GetRoomIdByName(name);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<string> GetRoomTypesForHotel()
        {
            try
            {
                return roomTypeDAL.GetDistinctRoomTypesForHotel();
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        public double GetCost(string name)
        {
            try
            {
                return roomTypeDAL.GetCost(name);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

    }
}
