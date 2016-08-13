using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture, Explicit]
    public class opening_a_ptable_with_more_than_64Bits_of_records: _32Bit.opening_a_ptable_with_more_than_32bits_of_records
    {
        public opening_a_ptable_with_more_than_64Bits_of_records()
        {
            ptableVersion = 2;
        }
    }
}