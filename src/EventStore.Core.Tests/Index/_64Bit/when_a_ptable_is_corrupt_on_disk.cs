using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class when_a_ptable_is_corrupt_on_disk: _32Bit.when_a_ptable_is_corrupt_on_disk
    {
        public when_a_ptable_is_corrupt_on_disk()
        {
            ptableVersion = PTableVersions.Index64Bit;
        }
    }
}
