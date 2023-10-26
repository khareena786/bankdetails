using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bankdetails.Account;

namespace bankdetails
{
    internal class bankaccount : ISavingsaccount, ICurrentaccount, IGoldloanaccount
    {
        public double Calculatesavingsinterest(double Balance)
        {
            return Balance * 0.02;//let us take 2%interest
        }
        public double Calculatecurrentinterest(double balance)
        {
            return balance * 0.01;//calculating for 1% interest
        }
        public double Calculategoldinterest(double Principal)
        {
            return Principal * 0.05;//let it be 5% interest
        }



    }
}
