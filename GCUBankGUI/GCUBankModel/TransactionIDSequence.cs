using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCUBankModel
{
    /// <summary>
    /// generates IDs for ITransaction objects
    /// in a real application these IDs would be generated only when
    /// data is stored in a database
    /// </summary>
    public class TransactionIDSequence
    {
        private int nextIDNumber;

        public string NextID
        {
            get 
            { 
                string value = string.Format("T{0}",nextIDNumber.ToString());
                nextIDNumber++;
                return value;
            }

        }

        public void Reset()
        {
            nextIDNumber = 1;
        }

        private static TransactionIDSequence instance = null;

        public TransactionIDSequence()
        {
            nextIDNumber = 1;
        }

        public static TransactionIDSequence Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TransactionIDSequence();
                }
                return instance;
            }
        }



    }
}
