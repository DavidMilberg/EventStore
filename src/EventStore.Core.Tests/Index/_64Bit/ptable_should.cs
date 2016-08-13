using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class ptable_should: _32Bit.ptable_should
    {
        public ptable_should()
        {
            ptableVersion = 2;
        }
    }
}