using System.Collections;

namespace NetCoreIso8583x64Lib
{
    /// <summary>
    /// This interface represents a C# implementation as a library to use a ISO-8583 Library (in C language) provided by Oscar Sanderson (https://oscarsanderson.com/iso-8583/)
    /// Read the README with instruction about the fields that you can use with a common definition (1993 version)
    /// </summary>
    public interface IMessage : IDisposable
    {
        /// <summary>
        /// Gets the collection of fields in a messages already set (always from the last message), no matter if it was set by SetMessage or SetMessages method
        /// </summary>
        /// <returns>An IDictionary<uint, string> strucure where TKey (uint) is one of 129 positions of available fields and TValue (string) is the message in the referenced position</returns>
        IDictionary<uint, string> GetMessageFields();

        /// <summary>
        /// Gets the collection of fields in a message already set (always from the last message), no matter if it was set by SetMessage or SetMessages method
        /// </summary>
        /// <returns>An IDictionary<ISO_8583_1987, string> strucure where TKey (ISO_8583_1987 enum) is one of 129 positions of available fields and TValue (string) is the message in the referenced position</returns>
        IDictionary<ISO_8583_1987, string> GetMessageFieldsEnum1987();

        /// <summary>
        /// Gets the collection of fields in a message already set (always from the last message), no matter if it was set by SetMessage or SetMessages method
        /// </summary>
        /// <returns>An List<ISO_8583_1987_FIELD> with ISO_8583_1987_FIELD custom enum field representation</returns>
        List<ISO_8583_1987_FIELD> GetMessageFieldsCustomEnum1987();

        /// <summary>
        /// Gets the collection of fields in a message already set, no matter if it was set by SetMessage or SetMessages method
        /// </summary>
        /// <returns>An IDictionary<ISO_8583_1993, string> strucure where TKey (ISO_8583_1993 enum) is one of 129 positions of available fields and TValue (string) is the message in the referenced position</returns>
        IDictionary<ISO_8583_1993, string> GetMessageFieldsEnum1993();

        /// <summary>
        /// Gets the collection of fields in a message already set (always from the last message), no matter if it was set by SetMessage or SetMessages method
        /// </summary>
        /// <returns>An List<ISO_8583_1993_FIELD> with ISO_8583_1993_FIELD custom enum field representation</returns>
        List<ISO_8583_1993_FIELD> GetMessageFieldsCustomEnum1993();

        /// <summary>
        /// Get the T class structure where custom class and field/property attributes where set, to get the fields of a message
        /// </summary>
        /// <typeparam name="T">A class representation that uses ISO_8583 class Attribute and ISO_8583_1993 or ISO_8583_1987 field/property Attribute</typeparam>
        /// <returns>A class that has ISO_8583 class Attribute and fields are defined in properties on class with ISO_8583_1993 or ISO_8583_1987 field/property Attribute</returns>
        T GetMessage<T>() where T : class;

        /// <summary>
        /// Pack the ISO-8583 message. It transforms all given fields in the IDictionary collection into an packed message in hex for transport
        /// </summary>
        /// <returns>A byte array representation after processing the ISO-8583 message with all fields</returns>
        byte[] PackMessage();

        /// <summary>
        /// Sets a field in a message in one of 129 fields available. Internally it will add the message in a IDictionary<uint, string> structure
        /// </summary>
        /// <param name="position">An unsigned integer (uint) that represents the field position, from 0 to 128</param>
        /// <param name="message">The message to be set on a field</param>
        void SetMessageField(uint position, string message);

        /// <summary>
        /// Sets a field in a message in one of 129 fields available. Internally it will add the message in a IDictionary<uint, string> structure
        /// </summary>
        /// <param name="field">An ISO_8583_1987 enum that represents the field</param>
        /// <param name="message">The message to be set on a field</param>
        void SetMessageField(ISO_8583_1987 field, string message);

        /// <summary>
        /// Sets a field in a message in one of 129 fields available. Internally it will add the message in a IDictionary<uint, string> structure
        /// </summary>
        /// <param name="field">An ISO_8583_1987_FIELD custom enum that represents the field. The message can be set using Message property</param>
        void SetMessageField(ISO_8583_1987_FIELD field);

        /// <summary>
        /// Sets a field in a message in one of 129 fields available. Internally it will add the message in a IDictionary<uint, string> structure
        /// </summary>
        /// <param name="field">An ISO_8583_1993 enum that represents the field</param>
        /// <param name="message">The message to be set on a field</param>
        void SetMessageField(ISO_8583_1993 field, string message);

        /// <summary>
        /// Sets a field in a message in one of 129 fields available. Internally it will add the message in a IDictionary<uint, string> structure
        /// </summary>
        /// <param name="field">An ISO_8583_1993_FIELD custom enum that represents the field. The message can be set using Message property</param>
        void SetMessageField(ISO_8583_1993_FIELD field);

        /// <summary>
        /// Sets a message using some of 129 fields available. Internally it will add the message in a IDictionary<uint, string> structure
        /// </summary>
        /// <typeparam name="T">A class representation that uses ISO_8583 class Attribute and ISO_8583_1993 or ISO_8583_1987 field/property Attribute</typeparam>
        /// <param name="message">The class representation that have all fields parameterized with ISO_8583_1993 or ISO_8583_1987 enum fields</param>
        void SetMessage<T>(T message) where T : class;

        /// <summary>
        /// Sets a collection of fields in a message in a limit of 129 fields available. If a message was already set through SetMessageField or SetMessageFields, this method will replace the old message with the new one if in the same position (TKey)
        /// </summary>
        /// <param name="fields">A collection of messages with a position as a TKey (uint) and a message as a TValue (string) of an IDictionary object</param>
        void SetMessageFields(IDictionary<uint, string> fields);

        /// <summary>
        /// Sets a collection of fields in a message in a limit of 129 fields available. If a message was already set through SetMessageField or SetMessageFields, this method will replace the old message with the new one if in the same position (TKey)
        /// </summary>
        /// <param name="fields">A collection of messages with a ISO_8583_1987 enum field representation as a TKey (ISO_8583_1987) and a message as a TValue (string) of an IDictionary object</param>
        void SetMessageFields(IDictionary<ISO_8583_1987, string> fields);

        /// <summary>
        /// Sets a collection of fields in a message in a limit of 129 fields available. If a message was already set through SetMessageField or SetMessageFields, this method will replace the old message with the new one if in the same position (TKey)
        /// </summary>
        /// <param name="fields">A list of messages with a ISO_8583_1987_FIELD custom enum field representation</param>
        void SetMessageFields(List<ISO_8583_1987_FIELD> fields);

        /// <summary>
        /// Sets a collection of fields in a message in a limit of 129 fields available. If a message was already set through SetMessageField or SetMessageFields, this method will replace the old message with the new one if in the same position (TKey)
        /// </summary>
        /// <param name="fields">A collection of messages with a ISO_8583_1993 enum field representation as a TKey (ISO_8583_1993) and a message as a TValue (string) of an IDictionary object</param>
        void SetMessageFields(IDictionary<ISO_8583_1993, string> fields);

        /// <summary>
        /// Sets a collection of fields in a message in a limit of 129 fields available. If a message was already set through SetMessageField or SetMessageFields, this method will replace the old message with the new one if in the same position (TKey)
        /// </summary>
        /// <param name="fields">A list of messages with a ISO_8583_1993_FIELD custom enum field representation</param>
        void SetMessageFields(List<ISO_8583_1993_FIELD> fields);

        /// <summary>
        /// Unpack the ISO-8583 message. It transforms an packed message in hex into fields for an ISO-8583 message using an IDictionary<uint, string> structure, that can be consumed with GetMessages method
        /// </summary>
        /// <param name="byteArray">A byte array that represents a packed ISO-8583 message</param>
        void UnpackMessage(byte[] byteArray);
    }
}
