using ConsoleAppDotNetLibTest.iso8583.Structure;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleAppDotNetLibTest.iso8583
{
    public class Message : IMessage
    {
        private const string LIB_PATH = @"\lib\iso8583.dll";

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_DEFS_1993_GetHandler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetHandler(ref DL_ISO8583_HANDLER handler);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_Init", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Init(IntPtr buffer, uint bufferSize, ref DL_ISO8583_MSG message);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_SetField_Str", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint MsgSetField(uint field, string dataStr, ref DL_ISO8583_MSG message);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_Pack", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint PackMessage(ref DL_ISO8583_HANDLER handler, ref DL_ISO8583_MSG message, byte[] byteArray, ref uint numBytes);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_Unpack", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint UnpackMessage(ref DL_ISO8583_HANDLER handler, byte[] byteArray, uint numBytes, ref DL_ISO8583_MSG message);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_Free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void FreeMessage(ref DL_ISO8583_MSG message);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_Dump", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DumpMessage([In] CFile file, IntPtr EolStr, ref DL_ISO8583_HANDLER handler, ref DL_ISO8583_MSG message);

        [DllImport("kernel32.dll")]
        public static extern bool SetStdHandle(int stdHandle, IntPtr handle);

        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        private uint bufferSize;
        private DL_ISO8583_HANDLER handler;
        private DL_ISO8583_MSG isoMessage;
        byte[] byteArray;
        uint packedSize;

        public Message()
        {
            handler = new DL_ISO8583_HANDLER();
            GetHandler(ref handler);

            bufferSize = 0;
            isoMessage = new DL_ISO8583_MSG();

            Init(IntPtr.Zero, bufferSize, ref isoMessage);
        }

        public void SetMessage(uint position, string message)
        {
            MsgSetField(position, message, ref isoMessage);
        }

        public void PackMessage()
        {
            byteArray = new byte[1000];
            packedSize = 0;

            PackMessage(ref handler, ref isoMessage, byteArray, ref packedSize);

            FreeMessage(ref isoMessage);
        }

        public void UnpackMessage()
        {
            bufferSize = 0;
            Init(IntPtr.Zero, bufferSize, ref isoMessage);
            UnpackMessage(ref handler, byteArray, packedSize, ref isoMessage);
        }

        public string GetMessage()
        {
            return isoMessage.ToString();
        }

        public void Dump()
        {
            //CFile file = new CFile();
            //DumpMessage(file, IntPtr.Zero, ref handler, ref isoMessage);
        }

        public void Dispose()
        {
            
        }
    }
}
