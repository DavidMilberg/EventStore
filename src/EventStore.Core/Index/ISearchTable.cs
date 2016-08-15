using System;
using System.Collections.Generic;

namespace EventStore.Core.Index
{
    public interface ISearchTable
    {
        Guid Id { get; }
        long Count { get; }

        bool TryGetOneValue(ulong stream, int number, out long position);
        bool TryGetLatestEntry(ulong stream, out IIndexEntry entry);
        bool TryGetOldestEntry(ulong stream, out IIndexEntry entry);
        IEnumerable<IIndexEntry> GetRange(ulong stream, int startNumber, int endNumber, int? limit = null);
        IEnumerable<IIndexEntry> IterateAllInOrder();
    }
}