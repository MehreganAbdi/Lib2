using LibraryUpgraded.Data;
using LibraryUpgraded.IGenerals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUpgraded.Member
{
    public static class MemberOperations
    {
        public static void AddThis(_Member member)
        {
            _Data.Members.Add(member);
        }

        public static void RemoveThis(_Member member)
        {
            _Data.Members.Remove(member);
        }
    
    
    
        public static int NumOfLoanBooksByMember(_Member member)
        {
            int result = 0;
            foreach (var item in _Data.Loaned_Members)
            {
                if(item == member)
                {
                    result++;
                }
            }
            return result;

        }



    }
}
