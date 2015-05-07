using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCUBankModel
{
    public class DebitException : Exception
    {
        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
        }

        public DebitException(decimal amount)
        {
            this.amount = amount;
        }


    }
}
