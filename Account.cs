using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Services.Account;

namespace bankdetails
{
        
    
        interface ISavingsaccount // using interface method
        {
            double Calculatesavingsinterest(double Balance);
        }
        interface ICurrentaccount
        {
            double Calculatecurrentinterest(double Balance);
        }
        interface IGoldloanaccount//for calculating the interest
        {
            double Calculategoldinterest(double Principal);
        }
    }


