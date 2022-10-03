using System;

namespace ConsoleAppDotNetLibTest.iso8583
{
    public interface IMessage : IDisposable
    {
        void AddMessage(uint position, string message);

        string GetMessage();
    }
}
