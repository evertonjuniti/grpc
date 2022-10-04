using System;

namespace ConsoleAppDotNetLibTest.iso8583
{
    /// <summary>
    /// This interface represents a C# implementation as a library to use a ISO-8583 Library (in C language) provided by Oscar Sanderson
    /// </summary>
    public interface IMessage : IDisposable
    {
        /// <summary>
        /// Sets a message in one of 128 fields available
        /// </summary>
        /// <param name="position">An unsigned integer that represents the field position, from 0 to 128</param>
        /// <param name="message">The message to be set on a field</param>
        void SetMessage(uint position, string message);

        /// <summary>
        /// Pack the ISO-8583 message. It transforms all given fields into an packed message in hex for transport
        /// </summary>
        void PackMessage();

        /// <summary>
        /// Unpack the ISO-8583 message. It transforms an packed message in hex into fields for an ISO-8583 message
        /// </summary>
        void UnpackMessage();

        string GetMessage();

        void Dump();
    }
}
