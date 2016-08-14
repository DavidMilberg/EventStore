using System;
using System.Collections.Generic;

namespace EventStore.Core.Index
{
    public interface ISearchTable
    {
        Guid Id { get; }
        long Count { get; }

        bool TryGetOneValue(uint stream, int number, out long position);
        bool TryGetLatestEntry(uint stream, out IndexEntry32 entry);
        bool TryGetOldestEntry(uint stream, out IndexEntry32 entry);
        IEnumerable<IndexEntry32> GetRange(uint stream, int startNumber, int endNumber, int? limit = null);
        IEnumerable<IndexEntry32> IterateAllInOrder();
    }
}