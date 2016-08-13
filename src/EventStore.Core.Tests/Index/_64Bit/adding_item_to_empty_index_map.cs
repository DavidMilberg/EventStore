using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class adding_item_to_empty_index_map: _32Bit.adding_item_to_empty_index_map
    {
        public adding_item_to_empty_index_map()
        {
            ptableVersion = 2;
        }
    }
}