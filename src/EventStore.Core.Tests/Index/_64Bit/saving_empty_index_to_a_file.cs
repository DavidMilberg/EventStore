using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class saving_empty_index_to_a_file: _32Bit.saving_empty_index_to_a_file
    {
        public saving_empty_index_to_a_file()
        {
            ptableVersion = PTableVersions.Index64Bit;
        }
    }
}