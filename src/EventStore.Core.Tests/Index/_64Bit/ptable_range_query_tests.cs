using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class ptable_range_query_tests: _32Bit.ptable_range_query_tests
    {
        public ptable_range_query_tests()
        {
            ptableVersion = 2;
        }
    }
}