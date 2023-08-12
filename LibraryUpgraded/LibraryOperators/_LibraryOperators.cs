using LibraryUpgraded.Book;
using LibraryUpgraded.Data;
using LibraryUpgraded.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUpgraded.LibraryOperators
{
    public static class _LibraryOperators
    {
        public static bool IsBan(_Member member)
        {
            bool answer = false;
            foreach (var item in _Data.BannedMembers)
            {
                if (item == member)
                {
                    answer = true;
                }
            }
            return answer;
        }


        public static void Loan(_Member member, _Book book)
        {
            if ((!IsBan(member) && BookOperations.IsAvailable(book))
                ||(_Data.BannedMembers.Count==0 && BookOperations.IsAvailable(book)))
            {

                foreach (var item in _Data.AvailableBooks)
                {
                    if (item == book && item.NumberOfBook > 1
                        && MemberOperations.NumOfLoanBooksByMember(member) < 6)

                    {
                        item.NumberOfBook--;

                        _Data.LoanedBooks.Add(book);
                        _Data.Loaned_Members.Add(member);
                        book.LoaningDate = DateTime.Now;

                    }

                    else if (item == book && item.NumberOfBook == 1
                        && MemberOperations.NumOfLoanBooksByMember(member) < 6)

                    {
                        BookOperations.RemoveThis(book);

                        _Data.LoanedBooks.Add(book);
                        _Data.Loaned_Members.Add(member);
                        book.LoaningDate = DateTime.Now;
                    }

                    else

                    {
                        Console.WriteLine("book is not available or the member reach max legal number of loan books");
                    }
                }

            }

            if (IsBan(member))
            {
                Console.WriteLine($"you have been charged {member.Fine_dollars}$ due to delay for giving back books, " +
                    $"if you don't pay it , you will remain banned(pay and try again)");
            }
        }


        private static int GetIndexInLoanList(_Member member, _Book book)
        {
            int index = -1;

            for (int i = 0; i < _Data.Loaned_Members.Count; i++)
            {
                if (_Data.Loaned_Members[i] == member && _Data.LoanedBooks[i] == book)
                {
                    index = i;

                }
            }

            return index;
        }


        //we scan both ids
        public static void Receive(_Book book, _Member member)
        {
            int index = GetIndexInLoanList(member, book);
            if((book.LoaningDate-DateTime.Now).Days > 14)
            {
                member.Fine_dollars = member.Fine_dollars + (0.25) * ((book.LoaningDate - DateTime.Now).Days);

                _Data.BannedMembers.Add(member);
                _Data.Loaned_Members.RemoveAt(index);
                _Data.LoanedBooks.RemoveAt(index);
            }
            else
            {
                _Data.Loaned_Members.RemoveAt(index);
                _Data.LoanedBooks.RemoveAt(index);
            }
            


        }
    
    
        public static void PayCharges(_Member member)
        {
            Console.WriteLine($"you fined : {member.Fine_dollars}$ " +
                $"(now is 0$)");
            member.Fine_dollars = 0;
        }
    
    
    
    
    }
}
