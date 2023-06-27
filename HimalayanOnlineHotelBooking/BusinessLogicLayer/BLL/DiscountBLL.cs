using BusinessLogicLayer.InterfacesDAL;
using DataTransferClasses.Classes;
using System.Data;


namespace BusinessLogicLayer.BLL
{
    public class DiscountBLL : IDiscountDAL
    {
        private IDiscountDAL discountDAL;

        public DiscountBLL(IDiscountDAL discountDAL)
        {
            this.discountDAL = discountDAL;
        }

        public bool InsertDiscount(Discount discount)
        {
            try
            {
                return discountDAL.InsertDiscount(discount);
            }
            catch (Exception)
            {
                throw;
            }
          
        }

        public bool UpdateDiscount(Discount discount, string discountId)
        {
            try
            {
                return discountDAL.UpdateDiscount(discount, discountId);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public bool DeleteDiscount(int discountId)
        {
            try
            {
                return discountDAL.DeleteDiscount(discountId);
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        public DataTable GetAllDiscountInfo()
        {
            try
            {
                return discountDAL.GetAllDiscountInfo();
            }
            catch (Exception)
            {
                throw;
            }
         
           
        }

        public int GetDiscountRate(string discountId)
        {
            try
            {
                return discountDAL.GetDiscountRate(discountId);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public List<string> GetDiscountNames()
        {
            try
            {
                return discountDAL.GetDiscountNames();
            }
            catch (Exception)
            {
                throw;
            }
          
        }

    }
}
