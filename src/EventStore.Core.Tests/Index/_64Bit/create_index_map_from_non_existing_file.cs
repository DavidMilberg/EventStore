using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class create_index_map_from_non_existing_file : _32Bit.create_index_map_from_non_existing_file
    {
        public create_index_map_from_non_existing_file()
        {
            ptableVersion = PTableVersions.Index64Bit;
        }
    }
}
