using System.Collections.Generic;

namespace EventStore.Core.Index
{
    public interface ITableIndex
    {
        long CommitCheckpoint { get; }
        long PrepareCheckpoint { get; }

        void Initialize(long chaserCheckpoint);
        void Close(bool removeFiles = true);

        void Add(long commitPos, ulong stream, int version, long position);
        void AddEntries(long commitPos, IList<IIndexEntry> entries);
        
        bool TryGetOneValue(ulong stream, int version, out long position);
        bool TryGetLatestEntry(ulong stream, out IIndexEntry entry);
        bool TryGetOldestEntry(ulong stream, out IIndexEntry entry);

        IEnumerable<IIndexEntry> GetRange(ulong stream, int startVersion, int endVersion, int? limit = null);
    }
}