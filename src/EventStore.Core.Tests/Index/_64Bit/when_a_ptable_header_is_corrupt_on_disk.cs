using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class when_a_ptable_header_is_corrupt_on_disk: _32Bit.when_a_ptable_header_is_corrupt_on_disk
    {
        public when_a_ptable_header_is_corrupt_on_disk()
        {
            ptableVersion = 2;
        }
    }
}
