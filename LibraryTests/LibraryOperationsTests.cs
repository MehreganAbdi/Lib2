using LibraryUpgraded.Book;
using LibraryUpgraded.Data;
using LibraryUpgraded.LibraryOperators;
using LibraryUpgraded.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTests
{
    public class LibraryOperationsTests
    {
        [Fact]
        public void IsBan_AddingToBannedListManualy_ReturnTrue()
        {
            var mem = new _Member("Scott", 6180);

            _Data.BannedMembers.Add(mem);

            Assert.True(_LibraryOperators.IsBan(mem));
        }

        [Fact]
        public void Looan_SearchingDataListsManually()
        {
            var book9897 = new _Book("Book9897", 9897, 10);
            var mem9897 = new _Member("Scott9897", 98972);

            MemberOperations.AddThis(mem9897);
            BookOperations.AddThis(book9897);

            _LibraryOperators.Loan(mem9897, book9897);
            bool x = _Data.LoanedBooks.Contains(book9897) && _Data.Loaned_Members.Contains(mem9897);

            Assert.True(x);
        }
       
    }
}
