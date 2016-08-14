using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class destroying_ptable: _32Bit.destroying_ptable
    {
        public destroying_ptable()
        {
            ptableVersion = PTableVersions.Index64Bit;
        }
    }
}