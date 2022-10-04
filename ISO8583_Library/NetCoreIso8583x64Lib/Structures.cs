using System.Runtime.InteropServices;

namespace NetCoreIso8583x64Lib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DL_ISO8583_FIELD_DEF
    {
        public byte fieldType;
        public uint len;
        public byte varLen;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DL_ISO8583_HANDLER
    {
        public IntPtr fieldArr;
        public byte fieldItems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DL_ISO8583_MSG_FIELD
    {
        public uint len;
        public IntPtr ptr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DL_ISO8583_MSG
    {
        public IntPtr sPtrNext;
        public IntPtr sPtrEnd;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 128)]
        public DL_ISO8583_MSG_FIELD[] field;
    }
}
