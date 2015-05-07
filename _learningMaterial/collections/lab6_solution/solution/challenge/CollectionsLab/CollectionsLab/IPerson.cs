using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsLab
{
    public interface IPerson
    {
        string ID { get; set; }

        string GetFullName(); 
    }
}
