using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratejiDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentOperation paymentOperation = new PaymentOperation(new BankaTransfer());
            paymentOperation.Pay();
            Console.ReadLine();
            
        }
    }
}
