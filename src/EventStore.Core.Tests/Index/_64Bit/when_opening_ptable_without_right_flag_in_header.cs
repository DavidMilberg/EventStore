using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class when_opening_ptable_without_right_flag_in_header: _32Bit.when_opening_ptable_without_right_flag_in_header
    {
        public when_opening_ptable_without_right_flag_in_header()
        {
            ptableVersion = 2;
        }
    }
}
