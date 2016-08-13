using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class adding_two_items_to_empty_index_map_with_two_tables_per_level_causes_merge: _32Bit.adding_two_items_to_empty_index_map_with_two_tables_per_level_causes_merge
    {
        public adding_two_items_to_empty_index_map_with_two_tables_per_level_causes_merge()
        {
            ptableVersion = 2;
        }
    }
}