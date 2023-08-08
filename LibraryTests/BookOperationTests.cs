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

            var testBook2 = new _Book("TestBook2", 2222, 5, "TestAuthor2");

            _Data.AvailableBooks.Add(testBook2);
           
            BookOperations.RemoveThis(testBook2);

            

            Assert.True(testBook2.NumberOfBook == 4);

        }


        [Fact]
        public void RemoveThis_ABookInstance__NumOfAddedIs1___AddItAndThenDeleteIt()
        {

            var testBook3 = new _Book("TestBook3", 3333, 1, "TestAuthor2");

            _Data.AvailableBooks.Add(testBook3);

            BookOperations.RemoveThis(testBook3);



            Assert.False(_Data.AvailableBooks.Contains(testBook3));

        }

    }
}
