using System;
using System.IO;
using System.Linq;
using EventStore.Core.Index;
using EventStore.Core.Util;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._64Bit
{
    [TestFixture]
    public class saving_index_with_single_item_to_a_file: _32Bit.saving_index_with_single_item_to_a_file
    {
        public saving_index_with_single_item_to_a_file()
        {
            ptableVersion = PTableVersions.Index64Bit;
        }
    }
}