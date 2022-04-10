using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratejiDesign
{
   public class PaymentOperation
    {
        private IOdemeYontem odemeYontem;
        public PaymentOperation(IOdemeYontem odemeYontem)
        {
            this.odemeYontem = odemeYontem;
        }
        public void Pay()
        {
            odemeYontem.Ode();
        }
    }
}
