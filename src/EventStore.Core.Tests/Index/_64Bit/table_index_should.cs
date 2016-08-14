using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class table_index_should : _32Bit.table_index_should
    {
        public table_index_should()
        {
            ptableVersion = PTableVersions.Index64Bit;
        }
    }
}