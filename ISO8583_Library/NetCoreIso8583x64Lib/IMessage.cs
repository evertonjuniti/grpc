namespace NetCoreIso8583x64Lib
{
    /// <summary>
    /// This interface represents a C# implementation as a library to use a ISO-8583 Library (in C language) provided by Oscar Sanderson (https://oscarsanderson.com/iso-8583/)
    /// Read the README with instruction about the fields that you can use with a common definition (1993 version)
    /// </summary>
    public interface IMessage : IDisposable
    {
        /// <summary>
        /// Gets the collection of messages already set, no matter if it was set by SetMessage or SetMessages method
        /// </summary>
        /// <returns>An IDictionary<uint, string> strucure where TKey (uint) is one of 129 positions of available fields and TValue (string) is the message in the referenced position</returns>
        IDictionary<uint, string> GetMessages();

        /// <summary>
        /// Pack the ISO-8583 message. It transforms all given fields in the IDictionary collection into an packed message in hex for transport
        /// </summary>
        /// <returns>A byte array representation after processing the ISO-8583 message with all fields</returns>
        byte[] PackMessage();

        /// <summary>
        /// Sets a message in one of 129 fields available. Internally it will add the message in a IDictionary<uint, string> structure
        /// </summary>
        /// <param name="position">An unsigned integer (uint) that represents the field position, from 0 to 128</param>
        /// <param name="message">The message to be set on a field</param>
        void SetMessage(uint position, string message);

        /// <summary>
        /// Sets a collection of messages in a limit of 129 fields available. If a message was already set through SetMessage or SetMessages, this method will replace the old message with the new one if in the same position (TKey)
        /// </summary>
        /// <param name="messages">A collection of messages with a position as a TKey (uint) and a message as a TValue (string) of an IDictionary object</param>
        void SetMessages(IDictionary<uint, string> messages);

        /// <summary>
        /// Unpack the ISO-8583 message. It transforms an packed message in hex into fields for an ISO-8583 message using an IDictionary<uint, string> structure, that can be consumed with GetMessages method
        /// </summary>
        /// <param name="byteArray">A byte array that represents a packed ISO-8583 message</param>
        void UnpackMessage(byte[] byteArray);
    }
}
