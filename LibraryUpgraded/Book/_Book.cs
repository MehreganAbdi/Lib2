using LibraryUpgraded.IGenerals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUpgraded.Book
{
    public class _Book : IGeneralProperties
    {
        public int NumberOfBook;


        public string name;
        
        string IGeneralProperties.Name
        {
            
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


        public string author;

        public _Book(string name, int ID,int NumberOfBook,string author = "NOT DEFINED")
        {
            name = name.ToLower().Replace(" ", "");
            author = author.ToLower().Replace(" ", "");

            this.name = name;
            this.author = author;
            this.id = ID;
            this.NumberOfBook = NumberOfBook;

            this.addedDate = DateTime.Now;
        }


        public DateTime LoaningDate; 
    }
}
