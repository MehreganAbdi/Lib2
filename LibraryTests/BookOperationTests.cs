using LibraryUpgraded.Book;
using LibraryUpgraded.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTests
{
    public class BookOperationTests
    {




        [Fact]
        public void Addthis_ABookInstance_AddToData()
        {
            var testBook = new _Book("TestBook", 1111, 5, "TestAuthor");

            BookOperations.AddThis(testBook);

            Assert.True(_Data.AllBooks.Contains(testBook));
                
        }


        [Fact]
        public void RemoveThis_ABookInstance__NumOfAddedIsMoreThan1___AddItAndThenDeleteIt()
        {
            _Data.AvailableBooks.Clear();

            var testBook2 = new _Book("TestBook2", 2222, 2, "TestAuthor2");

            _Data.AvailableBooks.Add(testBook2);
           
            BookOperations.RemoveThis(testBook2);
            
            

            Assert.True(testBook2.NumberOfBook == 1);

        }

        [Fact]
        public void RemoveThis_ABookInstance__NumOfAddedIs1___AddItAndThenDeleteIt()
        {
            var book1 = new _Book("abc", 3333, 1);
            _Data.AvailableBooks.Add(book1);

            BookOperations.RemoveThis(book1);

            Assert.DoesNotContain(book1,_Data.AvailableBooks);
        }

        [Fact]
        public void IsAvailable_ABookInstance_ItDoesNotExist_returnFalse()
        {
            var testBook = new _Book("aaa", 5555, 4);

            Assert.False(BookOperations.IsAvailable(testBook));
        }

        [Fact]
        public void IsAvailable_ABookInstance_Exists_returnTrue()
        {
            var testBook = new _Book("aaa", 5555, 4);
            BookOperations.AddThis(testBook);
            Assert.True(BookOperations.IsAvailable(testBook));
        }
    }
}
