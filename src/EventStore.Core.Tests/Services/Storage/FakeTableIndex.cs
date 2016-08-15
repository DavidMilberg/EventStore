using System;
using System.Collections.Generic;
using EventStore.Core.Index;

namespace EventStore.Core.Tests.Services.Storage
{
    public class FakeTableIndex: ITableIndex
    {
        internal static readonly IndexEntry32 InvalidIndexEntry = new IndexEntry32(0, -1, -1);

        public long PrepareCheckpoint { get { throw new NotImplementedException(); } }
        public long CommitCheckpoint { get { throw new NotImplementedException(); } }

        public void Initialize(long chaserCheckpoint)
        {
        }

        public void Close(bool removeFiles = true)
        {
        }

        public void Add(long commitPos, ulong stream, int version, long position)
        {
            throw new NotImplementedException();
        }

        public void AddEntries(long commitPos, IList<IIndexEntry> entries)
        {
            throw new NotImplementedException();
        }

        public bool TryGetOneValue(ulong stream, int version, out long position)
        {
            position = -1;
            return false;
        }

        public bool TryGetLatestEntry(ulong stream, out IIndexEntry entry)
        {
            entry = InvalidIndexEntry;
            return false;
        }

        public bool TryGetOldestEntry(ulong stream, out IIndexEntry entry)
        {
            entry = InvalidIndexEntry;
            return false;
        }

        public IEnumerable<IIndexEntry> GetRange(ulong stream, int startVersion, int endVersion, int? limit = null)
        {
            yield break;
        }
    }
}