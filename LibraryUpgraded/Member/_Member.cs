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
        private string name;
        string IGeneralProperties.Name {
            get => name; 
            set => name = value;  
        }


        private int id;
         int IGeneralProperties.ID 
        {
            get => id;  
            set => id = value;
        
        }


        private DateTime addedDate;
        DateTime IGeneralProperties.AddedDate
        {
            get => addedDate;
            set => addedDate = value;
        }

       public  _Member(string name , int ID )
        {
            this.name = name;
            this.id = ID;
            this.addedDate = DateTime.Now;

        }


    }
}
