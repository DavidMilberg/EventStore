using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class saving_index_with_six_items_to_a_file: _32Bit.saving_index_with_six_items_to_a_file
    {
        public saving_index_with_six_items_to_a_file()
        {
            ptableVersion = 2;
        }
    }
}