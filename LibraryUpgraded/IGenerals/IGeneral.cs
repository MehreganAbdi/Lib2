using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUpgraded.IGenerals
{
    public interface IGeneral<Thing>
        where Thing : class
    {
        void AddThis(Thing thing);

        void RemoveThis(Thing thing);
    }
}
