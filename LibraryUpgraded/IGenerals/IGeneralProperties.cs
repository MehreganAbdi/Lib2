using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUpgraded.IGenerals
{
    public interface IGeneralProperties 
         
    {
        string Name { get; set; }

        int ID { get; set; }

        DateTime AddedDate { get; set;  }
    }
}
