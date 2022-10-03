using ConsoleAppDotNetLibTest.iso8583.Structure;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleAppDotNetLibTest.iso8583
{
    public class Message : IMessage
    {
        [DllImport(@"\lib\iso8583.dll", EntryPoint = "DL_ISO8583_DEFS_1993_GetHandler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetHandler(ref DL_ISO8583_HANDLER handler);

        [DllImport(@"\lib\iso8583.dll", EntryPoint = "DL_ISO8583_MSG_Init", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Init(IntPtr buffer, uint bufferSize, ref DL_ISO8583_MSG message);

        [DllImport(@"\lib\iso8583.dll", EntryPoint = "DL_ISO8583_MSG_SetField_Str", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint MsgSetField(uint field, string dataStr, ref DL_ISO8583_MSG message);

        [DllImport(@"\lib\iso8583.dll", EntryPoint = "DL_ISO8583_MSG_Pack", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint PackMessage(ref IntPtr handler, ref DL_ISO8583_MSG message, ref byte[] byteArray, ref uint numBytes);

        [DllImport(@"\lib\iso8583.dll", EntryPoint = "DL_ISO8583_MSG_Dump", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DumpMessage(IntPtr file, IntPtr EoLStr, ref DL_ISO8583_HANDLER handler, ref DL_ISO8583_MSG message);

        private uint bufferSize;
        private DL_ISO8583_HANDLER handler;
        private DL_ISO8583_MSG isoMessage;

        public Message()
        {
            handler = new DL_ISO8583_HANDLER();
            GetHandler(ref handler);

            bufferSize = 0;
            isoMessage = new DL_ISO8583_MSG();

            Init(IntPtr.Zero, bufferSize, ref isoMessage);
        }

        public void AddMessage(uint position, string message)
        {
            MsgSetField(position, message, ref isoMessage);
        }

        public string GetMessage()
        {
            return isoMessage.ToString();
        }

        public void Dump()
        {
            FileStream fs = new FileStream(@"C:\Temp\out.txt", FileMode.Create);
            //DumpMessage(fs.SafeFileHandle.DangerousGetHandle(), IntPtr.Zero, ref handler, ref isoMessage);
        }

        public void Dispose()
        {
            
        }
    }
}
