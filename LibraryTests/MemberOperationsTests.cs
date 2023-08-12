

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
            var mem67 = new _Member("mem67", 9000);
            MemberOperations.AddThis(mem67);

            MemberOperations.RemoveThis(mem67);

            Assert.DoesNotContain(mem67, _Data.Members);
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
