using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class index_map_should_detect_corruption: _32Bit.index_map_should_detect_corruption
    {
        public index_map_should_detect_corruption()
        {
            ptableVersion = 2;
        }
    }
}
