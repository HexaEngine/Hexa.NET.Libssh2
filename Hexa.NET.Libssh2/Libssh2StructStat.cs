namespace Hexa.NET.Libssh2
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Libssh2StructStat
    {
        public uint StDev;
        public ushort StIno;
        public ushort StMode;
        public short StNlink;
        public short StUid;
        public short StGid;
        public uint StRdev;
        public long StSize;
        public long StAtime;
        public long StMtime;
        public long StCtime;

        public Libssh2StructStat(uint stDev, ushort stIno, ushort stMode, short stNlink, short stUid, short stGid, uint stRdev, long stSize, long stAtime, long stMtime, long stCtime)
        {
            StDev = stDev;
            StIno = stIno;
            StMode = stMode;
            StNlink = stNlink;
            StUid = stUid;
            StGid = stGid;
            StRdev = stRdev;
            StSize = stSize;
            StAtime = stAtime;
            StMtime = stMtime;
            StCtime = stCtime;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Stat
    {
        public uint StDev;
        public ushort StIno;
        public ushort StMode;
        public short StNlink;
        public short StUid;
        public short StGid;
        public uint StRdev;
        public int StSize;
        public long StAtime;
        public long StMtime;
        public long StCtime;

        public Stat(uint stDev, ushort stIno, ushort stMode, short stNlink, short stUid, short stGid, uint stRdev, int stSize, long stAtime, long stMtime, long stCtime)
        {
            StDev = stDev;
            StIno = stIno;
            StMode = stMode;
            StNlink = stNlink;
            StUid = stUid;
            StGid = stGid;
            StRdev = stRdev;
            StSize = stSize;
            StAtime = stAtime;
            StMtime = stMtime;
            StCtime = stCtime;
        }
    }
}