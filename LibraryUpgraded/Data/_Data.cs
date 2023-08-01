using LibraryUpgraded.Book;
using LibraryUpgraded.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUpgraded.Data
{
    public static class _Data
    {
        public static List<_Member> Members = new List<_Member>();

        public static List<_Book> AllBooks = new List<_Book>();

        public static List<_Book> AvailableBooks = new List<_Book>();
        
        public static List<_Book> LoanedBooks = new List<_Book>();

        public static List<_Member> Loaned_Members = new List<_Member>();

        public static List<_Member> BannedMembers = new List<_Member>();


    }
}
