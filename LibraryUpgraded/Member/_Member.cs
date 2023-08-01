using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUpgraded.IGenerals;
using LibraryUpgraded.Data;

namespace LibraryUpgraded.Member
{
    public class _Member : IGeneralProperties
    {
        public string name;
        string IGeneralProperties.Name {
            get => name; 
            set => name = value;  
        }


        public int id;
         int IGeneralProperties.ID 
        {
            get => id;  
            set => id = value;
        
        }


        public DateTime addedDate;
        DateTime IGeneralProperties.AddedDate
        {
            get => addedDate;
            set => addedDate = value;
        }

        public  double Fine_dollars ;
        
       public  _Member(string name , int ID )
        {
            name = name.ToLower().Replace(" ", "");
            this.name = name;
            this.id = ID;
            this.addedDate = DateTime.Now;
            this.Fine_dollars = 0;
        }


    }
}
