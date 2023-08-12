

using LibraryUpgraded.Data;
using LibraryUpgraded.Member;

namespace LibraryTests
{
    public class MemberOperationsTests
    {
        [Fact]
        public void AddThis_AMemberInstance()
        {
            var mem = new _Member("mem", 1234);
            MemberOperations.AddThis(mem);

            Assert.Contains(mem, _Data.Members);
        }

        [Fact]
        public void RemoveThis_AMemInstance()
        {
            var mem = new _Member("mem", 1234);
            MemberOperations.AddThis(mem);

            MemberOperations.RemoveThis(mem);

            Assert.DoesNotContain(mem, _Data.Members);
        }

        [Fact]
        public void NumOfLoanBooksByMember_AddToLoanListManually()
        {
            var mem = new _Member("mem", 1234);
            MemberOperations.AddThis(mem);


            _Data.Loaned_Members.Add(mem);
            _Data.Loaned_Members.Add(mem);
            _Data.Loaned_Members.Add(mem);

            Assert.True(MemberOperations.NumOfLoanBooksByMember(mem) == 3);
        }
    }
}
