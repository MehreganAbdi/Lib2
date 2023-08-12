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

        //[Fact]
        //public void Loan_AddingToLoanListsTest_CheckingListsManually()
        //{
        //    var memb1518 = new _Member("John", 1518);
        //    var testBook1518 = new _Book("Travis", 2111, 3);

        //    BookOperations.AddThis(testBook1518);
        //    MemberOperations.AddThis(memb1518);


        //    _LibraryOperators.Loan(memb1518, testBook1518);

        //    Assert.True(_Data.LoanedBooks.Contains(testBook1518) && _Data.Loaned_Members.Contains(memb1518));
        //}

        //[Fact]
        //public void Recieve_CheckListsManually()
        //{
        //    var validMember = new _Member("John", 1818);
        //    var testBook = new _Book("Travis", 1111, 3);

        //    BookOperations.AddThis(testBook);
        //    MemberOperations.AddThis(validMember);


        //    _LibraryOperators.Loan(validMember, testBook);
        //    _LibraryOperators.Receive(testBook, validMember);


        //    Assert.True(!_Data.LoanedBooks.Contains(testBook) && !_Data.Loaned_Members.Contains(validMember));

        //}
    }
}
