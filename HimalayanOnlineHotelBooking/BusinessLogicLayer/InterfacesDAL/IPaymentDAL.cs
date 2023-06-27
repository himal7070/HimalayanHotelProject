using DataTransferClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InterfacesDAL
{
    public interface IPaymentDAL
    {
        bool AddPayment(Payment payment);
        DataTable GetAllPaymentInfo();
    }
}
