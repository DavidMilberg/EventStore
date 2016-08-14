using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class when_creating_ptable_from_memtable: _32Bit.when_creating_ptable_from_memtable
    {
        public when_creating_ptable_from_memtable()
        {
            ptableVersion = PTableVersions.Index64Bit;
        }
    }
}