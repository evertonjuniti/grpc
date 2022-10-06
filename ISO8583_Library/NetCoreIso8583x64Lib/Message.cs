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
        private IDictionary<ISO_8583_1987, string>? messages1987;
        private List<ISO_8583_1987_FIELD>? messages1987CustomEnum;
        private IDictionary<ISO_8583_1993, string>? messages1993;
        private List<ISO_8583_1993_FIELD>? messages1993CustomEnum;

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

        private void InitializeMessages1987()
        {
            if (this.messages1987 == null)
                this.messages1987 = new Dictionary<ISO_8583_1987, string>();
        }

        private void InitializeMessages1987CustomEnum()
        {
            if (this.messages1987CustomEnum == null)
                this.messages1987CustomEnum = new List<ISO_8583_1987_FIELD>();
        }

        private void InitializeMessages1993()
        {
            if (this.messages1993 == null)
                this.messages1993 = new Dictionary<ISO_8583_1993, string>();
        }

        private void InitializeMessages1993CustomEnum()
        {
            if (this.messages1993CustomEnum == null)
                this.messages1993CustomEnum = new List<ISO_8583_1993_FIELD>();
        }

        private uint SumMessageFieldSize()
        {
            uint messagesSize = 0;

            for (uint index = 0; index < this.isoMessage.field.Length; index++)
            {
                if (this.isoMessage.field[index].len > 0)
                {
                    Enumeration field;

                    switch (this.standard)
                    {
                        case STANDARD.ISO_8583_1987:
                            field = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == index);
                            break;
                        default:
                            field = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == index);
                            break;
                    }

                    messagesSize += (field.FieldType.Equals(FIELD_TYPE.VARIABLE_99) ||
                                     field.FieldType.Equals(FIELD_TYPE.VARIABLE_999))
                                     ? this.isoMessage.field[index].len
                                     : field.MaxFieldSize;
                }
            }

            return messagesSize - 1;
        }

        public IDictionary<uint, string> GetMessages()
        {
            return this.messages;
        }

        public IDictionary<ISO_8583_1987, string> GetMessages1987()
        {
            this.InitializeMessages1987();
            this.messages1987.Clear();

            foreach(KeyValuePair<uint, string> field in this.messages)
                this.messages1987.Add(new KeyValuePair<ISO_8583_1987, string>((ISO_8583_1987)field.Key, field.Value));

            return this.messages1987;
        }

        public List<ISO_8583_1987_FIELD> GetMessages1987CustomEnum()
        {
            this.InitializeMessages1987CustomEnum();
            this.messages1987CustomEnum.Clear();

            foreach (KeyValuePair<uint, string> field in this.messages)
            {
                ISO_8583_1987_FIELD newField = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(fieldItem => fieldItem.Position == field.Key);
                this.messages1987CustomEnum.Add(newField);
            }

            return this.messages1987CustomEnum;
        }

        public IDictionary<ISO_8583_1993, string> GetMessages1993()
        {
            this.InitializeMessages1993();
            this.messages1993.Clear();

            foreach (KeyValuePair<uint, string> field in this.messages)
                this.messages1993.Add(new KeyValuePair<ISO_8583_1993, string>((ISO_8583_1993)field.Key, field.Value));
            
            return this.messages1993;
        }

        public List<ISO_8583_1993_FIELD> GetMessages1993CustomEnum()
        {
            this.InitializeMessages1993CustomEnum();
            this.messages1993CustomEnum.Clear();

            foreach (KeyValuePair<uint, string> field in this.messages)
            {
                ISO_8583_1993_FIELD newField = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(fieldItem => fieldItem.Position == field.Key);
                this.messages1993CustomEnum.Add(newField);
            }

            return this.messages1993CustomEnum;
        }

        public byte[] PackMessage()
        {
            InitializeIsoMessage();

            foreach (KeyValuePair<uint, string> message in this.messages)
                MsgSetField(message.Key, message.Value, ref this.isoMessage);
            
            byte[] byteArray = new byte[SumMessageFieldSize()];
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

        public void SetMessage(ISO_8583_1987 field, string message)
        {
            this.InitializeMessages1987();

            if (this.messages1987.ContainsKey(field))
                this.messages1987[field] = message;
            else
                this.messages1987.Add(new KeyValuePair<ISO_8583_1987, string>(field, message));

            SetMessage((uint)field, message);
        }

        public void SetMessage(ISO_8583_1987_FIELD field)
        {
            this.InitializeMessages1987CustomEnum();

            ISO_8583_1987_FIELD? oldItem = this.messages1987CustomEnum.Find(item => item.Position == field.Position);

            if (this.messages1987CustomEnum.Contains(oldItem))
                this.messages1987CustomEnum.Remove(oldItem);
            
            this.messages1987CustomEnum.Add(field);

            SetMessage(field.Position, field.Message);
        }

        public void SetMessage(ISO_8583_1993 field, string message)
        {
            this.InitializeMessages1993();

            if (this.messages1993.ContainsKey(field))
                this.messages1993[field] = message;
            else
                this.messages1993.Add(new KeyValuePair<ISO_8583_1993, string>(field, message));

            SetMessage((uint)field, message);
        }

        public void SetMessage(ISO_8583_1993_FIELD field)
        {
            this.InitializeMessages1993CustomEnum();

            ISO_8583_1993_FIELD? oldItem = this.messages1993CustomEnum.Find(item => item.Position == field.Position);

            if (this.messages1993CustomEnum.Contains(oldItem))
                this.messages1993CustomEnum.Remove(oldItem);
            
            this.messages1993CustomEnum.Add(field);

            SetMessage(field.Position, field.Message);
        }

        public void SetMessages(IDictionary<uint, string> messages)
        {
            this.messages = messages;
        }

        public void SetMessages(IDictionary<ISO_8583_1987, string> messages)
        {
            this.messages1987 = messages;

            this.messages.Clear();

            foreach (KeyValuePair<ISO_8583_1987, string> message in messages)
                this.messages.Add((uint)message.Key, message.Value);
        }

        public void SetMessages(List<ISO_8583_1987_FIELD> messages)
        {
            this.messages1987CustomEnum = messages;

            this.messages.Clear();

            foreach (ISO_8583_1987_FIELD field in messages)
                this.messages.Add(field.Position, field.Message);
        }

        public void SetMessages(IDictionary<ISO_8583_1993, string> messages)
        {
            this.messages1993 = messages;

            this.messages.Clear();

            foreach (KeyValuePair<ISO_8583_1993, string> message in messages)
                this.messages.Add((uint)message.Key, message.Value);
        }

        public void SetMessages(List<ISO_8583_1993_FIELD> messages)
        {
            this.messages1993CustomEnum = messages;

            this.messages.Clear();

            foreach (ISO_8583_1993_FIELD field in messages)
                this.messages.Add(field.Position, field.Message);
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
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.messages.Clear();

                if (this.messages1987 != null)
                    this.messages1987.Clear();

                if (this.messages1987CustomEnum != null)
                    this.messages1987CustomEnum.Clear();

                if (this.messages1993 != null)
                    this.messages1993.Clear();

                if (this.messages1993CustomEnum != null)
                    this.messages1993CustomEnum.Clear();
            }
        }
    }
}