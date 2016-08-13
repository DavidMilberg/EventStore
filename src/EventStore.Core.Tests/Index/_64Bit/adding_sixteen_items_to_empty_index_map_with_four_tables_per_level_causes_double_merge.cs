using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class adding_sixteen_items_to_empty_index_map_with_four_tables_per_level_causes_double_merge: _32Bit.adding_sixteen_items_to_empty_index_map_with_four_tables_per_level_causes_double_merge
    {
        public adding_sixteen_items_to_empty_index_map_with_four_tables_per_level_causes_double_merge()
        {
            ptableVersion = 2;
        }
    }
}