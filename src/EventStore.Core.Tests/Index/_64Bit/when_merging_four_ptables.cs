using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class when_merging_four_ptables: _32Bit.when_merging_four_ptables
    {
        public when_merging_four_ptables()
        {
            ptableVersion = 2;
        }
    }
}