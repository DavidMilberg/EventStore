using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class when_trying_to_get_oldest_entry: _32Bit.when_trying_to_get_oldest_entry
    {
        public when_trying_to_get_oldest_entry()
        {
            ptableVersion = 2;
        }
    }
}
