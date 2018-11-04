using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEvent
{
    public class TestEvent
    {
        public static void SendNotification(object sender, TransactionEventArgs e)
        {
            Console.WriteLine("Your Account is {0} for US$.{1} ", e.TranactionType, e.TranactionAmount);
        }
        public static void SendNotification2(object sender, EventArgs e)
        {
            TransactionEventArgs args = e as TransactionEventArgs;
            if (args != null)
            {
                Console.WriteLine("Your Account is {0} for US$.{1} ", args.TranactionType, args.TranactionAmount);
            }
        }
    }
}
