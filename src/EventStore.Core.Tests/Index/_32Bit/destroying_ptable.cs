using System.IO;
using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index._32Bit
{
    [TestFixture]
    public class destroying_ptable: SpecificationWithFile
    {
        private PTable _table;
        protected int ptableVersion = PTableVersions.Index32Bit;

        [SetUp]
        public void Setup()
        {
            var mtable = new HashListMemTable(maxSize: 10);
            mtable.Add(0x0101, 0x0001, 0x0001);
            mtable.Add(0x0105, 0x0001, 0x0002);
            _table = PTable.FromMemtable(mtable, Filename, ptableVersion);
            _table.MarkForDestruction();
        }

        [Test]
        public void the_file_is_deleted()
        {
            _table.WaitForDisposal(1000);
            Assert.IsFalse(File.Exists(Filename));
        }

        [Test]
        public void wait_for_destruction_returns()
        {
            Assert.DoesNotThrow(() => _table.WaitForDisposal(1000));
        }

        [TearDown]
        public void Teardown()
        {
            _table.WaitForDisposal(1000);
            File.Delete(Filename);
        }
    }
}