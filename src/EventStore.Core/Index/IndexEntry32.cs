using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EventStore.Core.Index
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct IndexEntry32 : IComparable<IIndexEntry>, IEquatable<IIndexEntry>, IIndexEntry
    {
        [FieldOffset(0)]public UInt64 Key;
        [FieldOffset(0)]public fixed byte Bytes[16];
        [FieldOffset(0)]public Int32 Version;
        [FieldOffset(4)]public UInt32 Stream;
        [FieldOffset(8)]public Int64 Position;

        public UInt64 GetKey()
        {
            return Key;
        }
        public Int32 GetVersion()
        {
            return Version;
        }
        public UInt64 GetStream()
        {
            return Stream;
        }
        public Int64 GetPosition()
        {
            return Position;
        }
        public IndexEntry32(ulong key, long position) : this()
        {
            Key = key;
            Position = position;
        }

        public IndexEntry32(uint stream, int version, long position) : this()
        {
            Stream = stream;
            Version = version;
            Position = position;
        }

        public int CompareTo(IIndexEntry other)
        {
            var keyCmp = Key.CompareTo(other.GetKey());
            if (keyCmp != 0)
                return keyCmp;
            return Position.CompareTo(other.GetPosition());
        }

        public bool Equals(IIndexEntry other)
        {
            return Key == other.GetKey() && Position == other.GetPosition();
        }

        public override string ToString()
        {
            return string.Format("Key: {0}, Stream: {1}, Version: {2}, Position: {3}", Key, Stream, Version, Position);
        }

        public void CopyInto(Stream stream, byte[] buffer)
        {
            fixed (byte* ptr = Bytes)
            {
                Marshal.Copy((IntPtr)ptr, buffer, 0, PTable.IndexEntry32Size);
                stream.Write(buffer, 0, PTable.IndexEntry32Size);
            }
        }
    }
}