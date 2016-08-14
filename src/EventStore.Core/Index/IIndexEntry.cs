using System;

namespace EventStore.Core.Index
{
    public interface IIndexEntry
    {
        UInt64 Key { get; set; }
        Int64 Position { get; set; }
        int CompareTo(IndexEntry32 max);
    }
}
