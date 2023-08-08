using LibraryUpgraded.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUpgraded.Book
{
    public static class BookOperations
    {
        public static void AddThis(_Book book)
        {
            int count = 0;
            foreach (var item in _Data.AllBooks)
            {
                if (item.name == book.name && (item.author == book.author || item.author == "notdefined"))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                _Data.AllBooks.Add(book);
                _Data.AvailableBooks.Add(book);
            }
            else
            {
                Console.WriteLine($"{book.name} is already in the library");
            }
        }

        /// <summary>
        /// it will remove one version of your book.
        /// </summary>
        /// <param name="book"></param>
        public static void RemoveThis(_Book book)
        {
            int count = 0;
            foreach(var item in _Data.AvailableBooks)
            {
                if(item.id == book.id && item.NumberOfBook>=1)
                {
                    if (book.NumberOfBook == 1)
                    {
                    global: _Data.AvailableBooks.Remove(book); ;
                        
                    }
                    else
                    {
                        book.NumberOfBook--;
                    }
                    count++;
                }
            }
            //if (count == 0)
            //{
            //    foreach (var item in _Data.LoanedBooks)
            //    {
            //        if (item.id == book.id)
            //        {
            //            Console.WriteLine("The book is on loan , you have to recieve it first");
            //            count++;
            //        }
            //    }
            //}

            if (count == 0)
            {
                Console.WriteLine("couldn't find your requested book");
            }
        
        }




        private static _Book FindBook(string name)
        {
            name = name.ToLower().Replace(" ", "");
            _Book modalBook = new _Book("", 0,0 ,""); 
            
            foreach (var item in _Data.AllBooks)
            {
                if(item.name == name)
                {
                    modalBook = item;
                }
            }

            return modalBook;

        } 

        public static void SearchByName(string name)
        {
            name = name.ToLower().Replace(" ", "");

            _Book modalBook = new _Book("", 0, 0, "");
            
            foreach (var item in _Data.AllBooks)
            {
                if (item.name == name)
                {
                    modalBook = item;
                }
            }
            if (modalBook.id != 0)
            {
                Console.WriteLine($"{modalBook.name} by {modalBook.author} with id {modalBook.id} \n" +
                    $" added in {modalBook.addedDate.ToString()} , remaining{modalBook.NumberOfBook}" );
            }
            else
            {
                Console.WriteLine("An Error! Try Again");
            }

        }



        public static bool IsAvailable(_Book book)
        {
            bool answer = false;

            foreach (var item in _Data.AvailableBooks)
            {
                if(book == item && item.NumberOfBook > 0)
                {
                    answer = true;
                }
            }
            return answer;
        }


    }
}
