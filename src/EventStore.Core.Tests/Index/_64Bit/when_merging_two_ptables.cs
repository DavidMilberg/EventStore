using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class when_merging_two_ptables: _32Bit.when_merging_two_ptables
    {
        public when_merging_two_ptables()
        {
            ptableVersion = 2;
        }
    }
}