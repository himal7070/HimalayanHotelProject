using BusinessLogicLayer.InterfacesBLL;
using DataTransferClasses.Classes;
using System.Data;
using BusinessLogicLayer.InterfacesDAL;

namespace BusinessLogicLayer.BLL
{
    public class PaymentBLL : IPaymentBLL
    {

        private IPaymentDAL paymentDAL;

        public PaymentBLL(IPaymentDAL paymentDAL)
        {
            this.paymentDAL = paymentDAL;
        }



        public bool AddPayment(Payment payment)
        {
            try
            {
                return paymentDAL.AddPayment(payment);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetAllPaymentInfo()
        {
            try
            {
                return paymentDAL.GetAllPaymentInfo();
            }
            catch (Exception)
            {
                throw;
            }
        }




    }

    

}
