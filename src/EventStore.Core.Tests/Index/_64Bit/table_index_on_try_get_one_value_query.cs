using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class table_index_on_try_get_one_value_query: _32Bit.table_index_on_try_get_one_value_query
    {
        public table_index_on_try_get_one_value_query()
        {
            ptableVersion = PTableVersions.Index64Bit;
        }
    }
}