using System;
using System.IO;

namespace EventStore.Core.Index
{
    public interface IIndexEntry
    {
        ulong GetKey();
        long GetPosition();
        int GetVersion();
        ulong GetStream();
        int CompareTo(IIndexEntry max);
        void CopyInto(Stream stream, byte[] buffer);
    }
    public class IndexEntryFactory
    {
        public int IndexEntrySize { get { return _indexEntrySize; } }
        private readonly int _indexEntrySize;
        private Func<ulong, int, long, IIndexEntry> _entryFactory;
        private Func<ulong, long, IIndexEntry> _entryByKeyFactory;
        public IndexEntryFactory(int ptableVersion)
        {
            if (ptableVersion == PTableVersions.Index32Bit)
            {
                _indexEntrySize = PTable.IndexEntry32Size;
                _entryFactory = (stream, version, position) =>
                {
                    return new IndexEntry32((uint)stream, version, position);
                };
                _entryByKeyFactory = (key, position) =>
                {
                    return new IndexEntry32(key, position);
                };
            }
            if (ptableVersion == PTableVersions.Index64Bit)
            {
                _indexEntrySize = PTable.IndexEntry64Size;
                _entryFactory = (stream, version, position) =>
                {
                    return new IndexEntry64(stream, version, position);
                };
                _entryByKeyFactory = (key, position) =>
                {
                    return new IndexEntry64(key, position);
                };
            }
        }
        public IIndexEntry Create(ulong stream, int version, long position)
        {
            return _entryFactory(stream, version, position);
        }
        public IIndexEntry Create(ulong key, long position)
        {
            return _entryByKeyFactory(key, position);
        }
    }
}
