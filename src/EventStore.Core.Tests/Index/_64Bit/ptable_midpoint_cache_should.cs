using System;
using EventStore.Common.Log;
using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    public class ptable_midpoint_cache_should: _32Bit.ptable_midpoint_cache_should
    {
        public ptable_midpoint_cache_should()
        {
            ptableVersion = 2;
        }
    }
}
