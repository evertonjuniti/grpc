using System.Runtime.InteropServices;

namespace NetCoreIso8583x64Lib
{
    public class Message : IMessage
    {
        private const string LIB_PATH = @"iso8583.dll";

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_DEFS_1987_GetHandler", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GetHandler1987(ref DL_ISO8583_HANDLER handler);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_DEFS_1993_GetHandler", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GetHandler1993(ref DL_ISO8583_HANDLER handler);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_Init", CallingConvention = CallingConvention.Cdecl)]
        private static extern void Init(IntPtr buffer, uint bufferSize, ref DL_ISO8583_MSG message);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_SetField_Str", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint MsgSetField(uint field, string dataStr, ref DL_ISO8583_MSG message);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_Pack", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint PackMessage(ref DL_ISO8583_HANDLER handler, ref DL_ISO8583_MSG message, byte[] byteArray, ref uint numBytes);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_Unpack", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint UnpackMessage(ref DL_ISO8583_HANDLER handler, byte[] byteArray, uint numBytes, ref DL_ISO8583_MSG message);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_GetField_Str", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GetFieldString(uint field, ref DL_ISO8583_MSG message, out string data);

        [DllImport(LIB_PATH, EntryPoint = "DL_ISO8583_MSG_Free", CallingConvention = CallingConvention.Cdecl)]
        private static extern void FreeMessage(ref DL_ISO8583_MSG message);

        private IDictionary<uint, string> messages;

        private DL_ISO8583_HANDLER handler;
        private DL_ISO8583_MSG isoMessage;

        private STANDARD standard;

        /// <summary>
        /// Default constructor, it assumes the default use of ISO-8583 message standard from 1993
        /// </summary>
        public Message()
        {
            InitializeVariables();
            this.standard = STANDARD.ISO_8583_1993;
        }

        /// <summary>
        /// Constructor where you define which standard will be used for ISO-8583 messages
        /// </summary>
        /// <param name="standard">enum where you can choose the ISO-8583 standard, that can be the 1993 standard or 1987 standard</param>
        public Message(STANDARD standard)
        {
            InitializeVariables();
            this.standard = standard;
        }

        private void InitializeVariables()
        {
            this.messages = new Dictionary<uint, string>();
        }

        private void InitializeIsoMessage()
        {
            this.handler = new DL_ISO8583_HANDLER();

            switch(this.standard)
            {
                case STANDARD.ISO_8583_1987:
                    GetHandler1987(ref this.handler);
                    break;
                default:
                    GetHandler1993(ref this.handler);
                    break;
            }

            uint bufferSize = 0;
            this.isoMessage = new DL_ISO8583_MSG();

            Init(IntPtr.Zero, bufferSize, ref this.isoMessage);
        }

        public IDictionary<uint, string> GetMessages()
        {
            return this.messages;
        }

        public byte[] PackMessage()
        {
            InitializeIsoMessage();

            uint messagesSize = 0;

            foreach (KeyValuePair<uint, string> message in this.messages)
                MsgSetField(message.Key, message.Value, ref this.isoMessage);
            
            for (uint index = 0; index < this.isoMessage.field.Length; index++)
            {
                if (this.isoMessage.field[index].len > 0)
                {
                    Enumeration field;

                    switch (this.standard)
                    {
                        case STANDARD.ISO_8583_1987:
                            field = Enumeration.GetAll<ISO_8583_1987_FIELD>().FirstOrDefault(field => field.Position == index);
                            break;
                        default:
                            field = Enumeration.GetAll<ISO_8583_1993_FIELD>().FirstOrDefault(field => field.Position == index);
                            break;
                    }

                    if (field.FieldType.Equals(FIELD_TYPE.VARIABLE_99) ||
                        field.FieldType.Equals(FIELD_TYPE.VARIABLE_999))
                        messagesSize += this.isoMessage.field[index].len;
                    else
                        messagesSize += field.MaxFieldSize;
                }                
            }

            byte[] byteArray = new byte[messagesSize - 1];
            uint packedSize = 0;

            PackMessage(ref this.handler, ref this.isoMessage, byteArray, ref packedSize);

            FreeMessage(ref this.isoMessage);

            return byteArray;
        }

        public void SetMessage(uint position, string message)
        {
            if (this.messages.ContainsKey(position))
                this.messages[position] = message;
            else
                this.messages.Add(new KeyValuePair<uint, string>(position, message));
        }

        public void SetMessages(IDictionary<uint, string> messages)
        {
            this.messages = messages;
        }

        public void UnpackMessage(byte[] byteArray)
        {
            InitializeIsoMessage();
            UnpackMessage(ref this.handler, byteArray, (uint)byteArray.Length, ref this.isoMessage);

            this.messages = new Dictionary<uint, string>();

            for (uint index = 0; index < this.isoMessage.field.Length; index++)
                if (this.isoMessage.field[index].len > 0)
                {
                    byte[] byteFieldValue = new byte[this.isoMessage.field[index].len];
                    Marshal.Copy(this.isoMessage.field[index].ptr, byteFieldValue, 0, (int)this.isoMessage.field[index].len);
                    string fieldValue = System.Text.Encoding.Default.GetString(byteFieldValue);
                    this.messages.Add(new KeyValuePair<uint, string>(index, fieldValue));
                }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            this.messages.Clear();
        }
    }
}