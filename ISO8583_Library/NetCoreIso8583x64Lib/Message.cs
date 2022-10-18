using System.Reflection;
using System.Runtime.InteropServices;

namespace NetCoreIso8583x64Lib
{
    public class Message : IMessage
    {
        #region ISO8583_C_Library_Definition
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
        #endregion

        #region Private_Variable_Definition
        private DL_ISO8583_HANDLER handler;
        private DL_ISO8583_MSG isoMessage;

        private STANDARD standard;

        private IDictionary<uint, string> fields;
        private IDictionary<ISO_8583_1987, string>? fieldsEnum1987;
        private List<ISO_8583_1987_FIELD>? fieldsCustomEnum1987;
        private IDictionary<ISO_8583_1993, string>? fieldsEnum1993;
        private List<ISO_8583_1993_FIELD>? fieldsCustomEnum1993;

        byte[] packedMessage;
        uint packedSize;
        #endregion

        #region Class_Constructor
        /// <summary>
        /// Default constructor, it assumes the default use of ISO-8583 message standard from 1993
        /// </summary>
        public Message()
        {
            Initialize();
            standard = STANDARD.ISO_8583_1993;
        }

        /// <summary>
        /// Constructor where you define which standard will be used for ISO-8583 messages
        /// </summary>
        /// <param name="standard">enum where you can choose the ISO-8583 standard, that can be the 1993 standard or 1987 standard</param>
        public Message(STANDARD standard)
        {
            Initialize();
            this.standard = standard;
        }
        #endregion

        #region Variable_Initialization
        private void InitializeIsoMessage()
        {
            handler = new DL_ISO8583_HANDLER();

            switch(standard)
            {
                case STANDARD.ISO_8583_1987:
                    GetHandler1987(ref this.handler);
                    break;
                default:
                    GetHandler1993(ref this.handler);
                    break;
            }

            uint bufferSize = 0;
            isoMessage = new DL_ISO8583_MSG();

            Init(IntPtr.Zero, bufferSize, ref isoMessage);
        }

        private void InitializeMessages1987()
        {
            if (fieldsEnum1987 == null)
                fieldsEnum1987 = new Dictionary<ISO_8583_1987, string>();
        }

        private void InitializeMessages1987CustomEnum()
        {
            if (fieldsCustomEnum1987 == null)
                fieldsCustomEnum1987 = new List<ISO_8583_1987_FIELD>();
        }

        private void InitializeMessages1993()
        {
            if (fieldsEnum1993 == null)
                fieldsEnum1993 = new Dictionary<ISO_8583_1993, string>();
        }

        private void InitializeMessages1993CustomEnum()
        {
            if (fieldsCustomEnum1993 == null)
                fieldsCustomEnum1993 = new List<ISO_8583_1993_FIELD>();
        }
        #endregion

        #region Private_Helper_Method
        /// <summary>
        /// Get a field total length (size) regarding the field type, using the field position to know the field
        /// </summary>
        /// <param name="fieldPosition">The field position relative to Enumerator</param>
        /// <returns>Total size of the field</returns>
        private uint GetMessageFieldSize(uint fieldPosition, bool fixedSize)
        {
            Enumeration field;

            switch (standard)
            {
                case STANDARD.ISO_8583_1987:
                    field = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == fieldPosition);
                    break;
                default:
                    field = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == fieldPosition);
                    break;
            }
            
            if (fixedSize)
                return field.MaxFieldSize;
            else
                return (field.FieldType.Equals(FIELD_TYPE.VARIABLE_99) ||
                                 field.FieldType.Equals(FIELD_TYPE.VARIABLE_999))
                                 ? isoMessage.field[fieldPosition].len
                                 : field.MaxFieldSize;
        }

        /// <summary>
        /// Gets all fields in IsoMessage and sum the field size, when variable fields it sums the length of that field
        /// </summary>
        /// <returns>The total sum of all fields, to use when packing the array of bytes</returns>
        private uint SumMessageFieldSize()
        {
            uint messagesSize = 0;

            for (uint index = 0; index < isoMessage.field.Length; index++)
                if (isoMessage.field[index].len > 0)
                    messagesSize += this.GetMessageFieldSize(index, false);

            return messagesSize - 1;
        }

        private void ValidateClassAttribute<T>(T typeClass) where T : class
        {
            ISO_8583Attribute attribute = (ISO_8583Attribute)typeClass.GetType().GetCustomAttribute(typeof(ISO_8583Attribute), false);

            if (attribute == null)
                throw new ISO_8583_Class_Attribute_Exception();
        }

        private void ProcessISO8583SetFieldAttributes<T>(T typeClass) where T : class
        {
            ISO_8583Attribute classAttribute = (ISO_8583Attribute)typeClass.GetType().GetCustomAttribute(typeof(ISO_8583Attribute), false);

            uint fieldsProcessed = 0;

            PropertyInfo[] properties = typeClass.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                switch (classAttribute.Standard)
                {
                    case STANDARD.ISO_8583_1987:
                        ISO_8583_1987Attribute? attribute1987 = (ISO_8583_1987Attribute)property.GetCustomAttribute(typeof(ISO_8583_1987Attribute), false);

                        if (attribute1987 != null && property.GetValue(obj: typeClass) != null)
                        {
                            SetMessageField((uint)attribute1987.Field, property.GetValue(obj: typeClass).ToString());
                            fieldsProcessed++;
                        }

                        break;
                    default:
                        ISO_8583_1993Attribute? attribute1993 = (ISO_8583_1993Attribute)property.GetCustomAttribute(typeof(ISO_8583_1993Attribute), false);

                        if (attribute1993 != null && property.GetValue(obj: typeClass) != null)
                        {
                            SetMessageField((uint)attribute1993.Field, property.GetValue(obj: typeClass).ToString());
                            fieldsProcessed++;
                        }

                        break;
                }
            }

            if (fieldsProcessed == 0)
                throw new ISO_8583_Field_Attribute_Exception();
        }
        #endregion

        #region Public_Initialization
        public void Initialize()
        {
            fields = new Dictionary<uint, string>();

            if (fieldsEnum1987 != null)
                fieldsEnum1987.Clear();

            if (fieldsCustomEnum1987 != null)
                fieldsCustomEnum1987.Clear();

            if (fieldsEnum1993 != null)
                fieldsEnum1993.Clear();

            if (fieldsCustomEnum1993 != null)
                fieldsCustomEnum1993.Clear();
        }
        #endregion

        #region Get_Implementation
        public byte[] GetByteArray()
        {
            return packedMessage;
        }

        public IDictionary<uint, string> GetMessageFields()
        {
            return fields;
        }

        public IDictionary<ISO_8583_1987, string> GetMessageFieldsEnum1987()
        {
            InitializeMessages1987();
            fieldsEnum1987.Clear();

            foreach(KeyValuePair<uint, string> field in fields)
                fieldsEnum1987.Add(new KeyValuePair<ISO_8583_1987, string>((ISO_8583_1987)field.Key, field.Value));

            return fieldsEnum1987;
        }

        public List<ISO_8583_1987_FIELD> GetMessageFieldsCustomEnum1987()
        {
            InitializeMessages1987CustomEnum();
            fieldsCustomEnum1987.Clear();

            foreach (KeyValuePair<uint, string> field in fields)
            {
                ISO_8583_1987_FIELD newField = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(fieldItem => fieldItem.Position == field.Key);
                fieldsCustomEnum1987.Add(newField);
            }

            return fieldsCustomEnum1987;
        }

        public IDictionary<ISO_8583_1993, string> GetMessageFieldsEnum1993()
        {
            InitializeMessages1993();
            fieldsEnum1993.Clear();

            foreach (KeyValuePair<uint, string> field in fields)
                fieldsEnum1993.Add(new KeyValuePair<ISO_8583_1993, string>((ISO_8583_1993)field.Key, field.Value));
            
            return fieldsEnum1993;
        }

        public List<ISO_8583_1993_FIELD> GetMessageFieldsCustomEnum1993()
        {
            InitializeMessages1993CustomEnum();
            fieldsCustomEnum1993.Clear();

            foreach (KeyValuePair<uint, string> field in fields)
            {
                ISO_8583_1993_FIELD newField = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(fieldItem => fieldItem.Position == field.Key);
                fieldsCustomEnum1993.Add(newField);
            }

            return fieldsCustomEnum1993;
        }

        public T GetMessage<T>() where T : class
        {
            T newT = (T)Activator.CreateInstance(typeof(T));
            ISO_8583Attribute classAttribute = (ISO_8583Attribute)newT.GetType().GetCustomAttribute(typeof(ISO_8583Attribute), false);

            PropertyInfo[] properties = newT.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                switch (classAttribute.Standard)
                {
                    case STANDARD.ISO_8583_1987:
                        ISO_8583_1987Attribute? attribute1987 = (ISO_8583_1987Attribute)property.GetCustomAttribute(typeof(ISO_8583_1987Attribute), false);
                        
                        if (attribute1987 != null)
                            property.SetValue(newT, fields[(uint)attribute1987.Field]);

                        break;
                    default:
                        ISO_8583_1993Attribute? attribute1993 = (ISO_8583_1993Attribute)property.GetCustomAttribute(typeof(ISO_8583_1993Attribute), false);
                        
                        if ( attribute1993 != null )
                            property.SetValue(newT, fields[(uint)attribute1993.Field]);

                        break;
                }
            }

            return newT;
        }

        public uint GetPackedSize()
        {
            return packedSize;
        }

        public STANDARD GetStandard()
        {
            return standard;
        }
        #endregion

        #region Set_Implementation
        public void SetMessageField(uint position, string message)
        {
            if (fields.ContainsKey(position))
                fields[position] = message;
            else
                fields.Add(new KeyValuePair<uint, string>(position, message));
        }

        public void SetMessageField(ISO_8583_1987 field, string message)
        {
            InitializeMessages1987();

            if (fieldsEnum1987.ContainsKey(field))
                fieldsEnum1987[field] = message;
            else
                fieldsEnum1987.Add(new KeyValuePair<ISO_8583_1987, string>(field, message));

            SetMessageField((uint)field, message);
        }

        public void SetMessageField(ISO_8583_1987_FIELD field)
        {
            InitializeMessages1987CustomEnum();

            ISO_8583_1987_FIELD? oldItem = fieldsCustomEnum1987.Find(item => item.Position == field.Position);

            if (fieldsCustomEnum1987.Contains(oldItem))
                fieldsCustomEnum1987.Remove(oldItem);

            fieldsCustomEnum1987.Add(field);

            SetMessageField(field.Position, field.Message);
        }

        public void SetMessageField(ISO_8583_1993 field, string message)
        {
            InitializeMessages1993();

            if (fieldsEnum1993.ContainsKey(field))
                fieldsEnum1993[field] = message;
            else
                fieldsEnum1993.Add(new KeyValuePair<ISO_8583_1993, string>(field, message));

            SetMessageField((uint)field, message);
        }

        public void SetMessageField(ISO_8583_1993_FIELD field)
        {
            InitializeMessages1993CustomEnum();

            ISO_8583_1993_FIELD? oldItem = fieldsCustomEnum1993.Find(item => item.Position == field.Position);

            if (fieldsCustomEnum1993.Contains(oldItem))
                fieldsCustomEnum1993.Remove(oldItem);

            fieldsCustomEnum1993.Add(field);

            SetMessageField(field.Position, field.Message);
        }

        public void SetMessage<T>(T message) where T : class
        {
            ValidateClassAttribute(message);

            Initialize();

            ProcessISO8583SetFieldAttributes(message);
        }

        public void SetMessageFields(IDictionary<uint, string> fields)
        {
            Initialize();
            this.fields = fields;
        }

        public void SetMessageFields(IDictionary<ISO_8583_1987, string> fields)
        {
            Initialize();
            fieldsEnum1987 = fields;

            foreach (KeyValuePair<ISO_8583_1987, string> field in fields)
                this.fields.Add((uint)field.Key, field.Value);
        }

        public void SetMessageFields(List<ISO_8583_1987_FIELD> fields)
        {
            Initialize();
            fieldsCustomEnum1987 = fields;

            foreach (ISO_8583_1987_FIELD field in fields)
                this.fields.Add(field.Position, field.Message);
        }

        public void SetMessageFields(IDictionary<ISO_8583_1993, string> fields)
        {
            Initialize();
            fieldsEnum1993 = fields;

            foreach (KeyValuePair<ISO_8583_1993, string> field in fields)
                this.fields.Add((uint)field.Key, field.Value);
        }

        public void SetMessageFields(List<ISO_8583_1993_FIELD> fields)
        {
            Initialize();
            fieldsCustomEnum1993 = fields;

            foreach (ISO_8583_1993_FIELD field in fields)
                this.fields.Add(field.Position, field.Message);
        }

        public void SetStandard(STANDARD standard)
        {
            this.standard = standard;
        }
        #endregion

        #region Pack_and_Unpack_Implementation
        public void PackMessage()
        {
            InitializeIsoMessage();

            foreach (KeyValuePair<uint, string> message in fields)
                MsgSetField(message.Key, message.Value, ref isoMessage);

            packedMessage = new byte[SumMessageFieldSize()];

            PackMessage(ref handler, ref isoMessage, packedMessage, ref packedSize);

            FreeMessage(ref isoMessage);
        }

        public void UnpackMessage(byte[] byteArray, uint size)
        {
            InitializeIsoMessage();
            UnpackMessage(ref handler, byteArray, size, ref isoMessage);

            fields = new Dictionary<uint, string>();

            for (uint index = 0; index < isoMessage.field.Length; index++)
                if (isoMessage.field[index].len > 0)
                {
                    byte[] byteFieldValue = new byte[GetMessageFieldSize(index, true)];
                    Marshal.Copy(isoMessage.field[index].ptr, byteFieldValue, 0, (int)isoMessage.field[index].len);
                    string fieldValue = System.Text.Encoding.Default.GetString(byteFieldValue);
                    fields.Add(new KeyValuePair<uint, string>(index, fieldValue));
                }
        }
        #endregion

        #region Dispose_Method
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                fields.Clear();

                if (fieldsEnum1987 != null)
                    fieldsEnum1987.Clear();

                if (fieldsCustomEnum1987 != null)
                    fieldsCustomEnum1987.Clear();

                if (fieldsEnum1993 != null)
                    fieldsEnum1993.Clear();

                if (fieldsCustomEnum1993 != null)
                    fieldsCustomEnum1993.Clear();
            }
        }
        #endregion
    }
}