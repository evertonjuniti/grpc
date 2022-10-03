using ConsoleAppDotNetLibTest.iso8583;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDotNetLibTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Message message = new Message())
            {
                message.AddMessage(0, "1234");
                message.AddMessage(2, "1234567890123456");
                message.AddMessage(4, "5699");
                message.AddMessage(11, "234");
                message.AddMessage(39, "4");
                message.AddMessage(41, "12345");
                message.AddMessage(42, "678901234");
                message.AddMessage(125, "BLAH BLAH");

                Console.WriteLine(message.GetMessage());

                Console.WriteLine(Environment.NewLine);

                message.Dump();
            }
            /*
            Byte buffer = new Byte();
            UInt32 bufferSize = new UInt32();
            bufferSize = 0;
            IntPtr message = Marshal.AllocHGlobal(205004);
            IntPtr handler = Marshal.AllocHGlobal(205004);
            Byte[] byteArray = new Byte[1000];
            UInt32 numBytes = new UInt32();

            Init(out buffer, bufferSize, out message);
            MsgSetField(0, "1234", out message);
            MsgSetField(2, "1234567890123456", out message);
            MsgSetField(4, "5699", out message);
            MsgSetField(11, "234", out message);
            MsgSetField(39, "4", out message);
            MsgSetField(41, "12345", out message);
            MsgSetField(42, "678901234", out message);
            MsgSetField(125, "BLAH BLAH", out message);

            Console.WriteLine("message as is: ");
            Console.WriteLine(message);

            PackMessage(out handler, out message, out byteArray, out numBytes);

            Console.WriteLine("packed message: ");
            Console.WriteLine(numBytes.ToString());
            Console.WriteLine(message);
            Console.WriteLine(byteArray);
            */
            Console.Read();
        }
    }
}
