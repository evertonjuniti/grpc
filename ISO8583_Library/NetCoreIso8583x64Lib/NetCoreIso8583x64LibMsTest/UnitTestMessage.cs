using NetCoreIso8583x64Lib;
using System.Diagnostics.CodeAnalysis;

namespace NetCoreIso8583x64LibMsTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class UnitTestMessage
    {
        private readonly uint field1;
        private readonly uint field2;
        private readonly uint field3;
        private readonly uint field4;
        private readonly uint field5;
        private readonly uint field6;
        private readonly uint field7;
        private readonly uint field8;

        private readonly string alterntiveMessage = "BLEH BLEH";
        
        private readonly IDictionary<uint, string> fields = new Dictionary<uint, string>();

        public UnitTestMessage()
        {
            field1 = 0;
            field2 = 2;
            field3 = 4;
            field4 = 11;
            field5 = 39;
            field6 = 41;
            field7 = 42;
            field8 = 125;

            fields.Add(new KeyValuePair<uint, string>(field1, "1234"));
            fields.Add(new KeyValuePair<uint, string>(field2, "1234567890123456"));
            fields.Add(new KeyValuePair<uint, string>(field3, "5699"));
            fields.Add(new KeyValuePair<uint, string>(field4, "234"));
            fields.Add(new KeyValuePair<uint, string>(field5, "4"));
            fields.Add(new KeyValuePair<uint, string>(field6, "12345"));
            fields.Add(new KeyValuePair<uint, string>(field7, "678901234"));
            fields.Add(new KeyValuePair<uint, string>(field8, "BLAH BLAH"));
        }

        private ISO_8583_1987_FIELD? customEnum1987Field1;
        private ISO_8583_1987_FIELD? customEnum1987Field2;
        private ISO_8583_1987_FIELD? customEnum1987Field3;
        private ISO_8583_1987_FIELD? customEnum1987Field4;
        private ISO_8583_1987_FIELD? customEnum1987Field5;
        private ISO_8583_1987_FIELD? customEnum1987Field6;
        private ISO_8583_1987_FIELD? customEnum1987Field7;
        private ISO_8583_1987_FIELD? customEnum1987Field8;

        private ISO_8583_1993_FIELD? customEnum1993Field1;
        private ISO_8583_1993_FIELD? customEnum1993Field2;
        private ISO_8583_1993_FIELD? customEnum1993Field3;
        private ISO_8583_1993_FIELD? customEnum1993Field4;
        private ISO_8583_1993_FIELD? customEnum1993Field5;
        private ISO_8583_1993_FIELD? customEnum1993Field6;
        private ISO_8583_1993_FIELD? customEnum1993Field7;
        private ISO_8583_1993_FIELD? customEnum1993Field8;

        private void SetupCustomEnumField1987()
        {
            customEnum1987Field1 = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field1);
            customEnum1987Field1.Message = fields[field1];

            customEnum1987Field2 = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field2);
            customEnum1987Field2.Message = fields[field2];

            customEnum1987Field3 = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field3);
            customEnum1987Field3.Message = fields[field3];

            customEnum1987Field4 = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field4);
            customEnum1987Field4.Message = fields[field4];

            customEnum1987Field5 = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field5);
            customEnum1987Field5.Message = fields[field5];

            customEnum1987Field6 = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field6);
            customEnum1987Field6.Message = fields[field6];

            customEnum1987Field7 = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field7);
            customEnum1987Field7.Message = fields[field7];

            customEnum1987Field8 = Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field8);
            customEnum1987Field8.Message = fields[field8];
        }

        private void SetupCustomEnumField1993()
        {
            customEnum1993Field1 = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field1);
            customEnum1993Field1.Message = fields[field1];

            customEnum1993Field2 = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field2);
            customEnum1993Field2.Message = fields[field2];

            customEnum1993Field3 = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field3);
            customEnum1993Field3.Message = fields[field3];

            customEnum1993Field4 = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field4);
            customEnum1993Field4.Message = fields[field4];

            customEnum1993Field5 = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field5);
            customEnum1993Field5.Message = fields[field5];

            customEnum1993Field6 = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field6);
            customEnum1993Field6.Message = fields[field6];

            customEnum1993Field7 = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field7);
            customEnum1993Field7.Message = fields[field7];

            customEnum1993Field8 = Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field8);
            customEnum1993Field8.Message = fields[field8];
        }

        private void PackAndUnpack(IMessage message)
        {
            message.PackMessage();

            byte[] packedMessage = message.GetByteArray();
            uint packedSize = message.GetPackedSize();

            message.UnpackMessage(packedMessage, packedSize);
        }

        [TestMethod]
        public void TestMethodSimpleMessage()
        {
            using (IMessage message = new Message())
            {
                message.SetMessageField(field1, fields[field1]);
                message.SetMessageField(field2, fields[field2]);
                message.SetMessageField(field3, fields[field3]);
                message.SetMessageField(field4, fields[field4]);
                message.SetMessageField(field5, fields[field5]);
                message.SetMessageField(field6, fields[field6]);
                message.SetMessageField(field7, fields[field7]);
                message.SetMessageField(field8, fields[field8]);
                message.SetMessageField(field8, alterntiveMessage);

                PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessageFields();

                Assert.IsTrue(messages[field1].Contains(fields[field1]));
                Assert.IsTrue(messages[field2].Contains(fields[field2]));
                Assert.IsTrue(messages[field3].Contains(fields[field3]));
                Assert.IsTrue(messages[field4].Contains(fields[field4]));
                Assert.IsTrue(messages[field5].Contains(fields[field5]));
                Assert.IsTrue(messages[field6].Contains(fields[field6]));
                Assert.IsTrue(messages[field7].Contains(fields[field7]));
                Assert.IsTrue(messages[field8].Contains(alterntiveMessage));

                message.SetStandard(STANDARD.ISO_8583_1987);

                Assert.IsTrue(message.GetStandard().Equals(STANDARD.ISO_8583_1987));
            }
        }

        [TestMethod]
        public void TestMethodISO_8583_1987EnumMessage()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1987))
            {
                message.SetMessageField((ISO_8583_1987)field1, fields[field1]);
                message.SetMessageField((ISO_8583_1987)field2, fields[field2]);
                message.SetMessageField((ISO_8583_1987)field3, fields[field3]);
                message.SetMessageField((ISO_8583_1987)field4, fields[field4]);
                message.SetMessageField((ISO_8583_1987)field5, fields[field5]);
                message.SetMessageField((ISO_8583_1987)field6, fields[field6]);
                message.SetMessageField((ISO_8583_1987)field7, fields[field7]);
                message.SetMessageField((ISO_8583_1987)field8, fields[field8]);
                message.SetMessageField((ISO_8583_1987)field8, alterntiveMessage);

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessageFields();

                Assert.IsTrue(messages[field1].Contains(fields[field1]));
                Assert.IsTrue(messages[field2].Contains(fields[field2]));
                Assert.IsTrue(messages[field3].Contains(fields[field3]));
                Assert.IsTrue(messages[field4].Contains(fields[field4]));
                Assert.IsTrue(messages[field5].Contains(fields[field5]));
                Assert.IsTrue(messages[field6].Contains(fields[field6]));
                Assert.IsTrue(messages[field7].Contains(fields[field7]));
                Assert.IsTrue(messages[field8].Contains(alterntiveMessage));
            }
        }

        [TestMethod]
        public void TestMethodISO_8583_1987CustomEnumMessage()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1987))
            {
                SetupCustomEnumField1987();

                message.SetMessageField(customEnum1987Field1);
                message.SetMessageField(customEnum1987Field2);
                message.SetMessageField(customEnum1987Field3);
                message.SetMessageField(customEnum1987Field4);
                message.SetMessageField(customEnum1987Field5);
                message.SetMessageField(customEnum1987Field6);
                message.SetMessageField(customEnum1987Field7);
                message.SetMessageField(customEnum1987Field8);

                customEnum1987Field8.Message = alterntiveMessage;
                message.SetMessageField(customEnum1987Field8);

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessageFields();

                Assert.IsTrue(messages[field1].Contains(fields[field1]));
                Assert.IsTrue(messages[field2].Contains(fields[field2]));
                Assert.IsTrue(messages[field3].Contains(fields[field3]));
                Assert.IsTrue(messages[field4].Contains(fields[field4]));
                Assert.IsTrue(messages[field5].Contains(fields[field5]));
                Assert.IsTrue(messages[field6].Contains(fields[field6]));
                Assert.IsTrue(messages[field7].Contains(fields[field7]));
                Assert.IsTrue(messages[field8].Contains(alterntiveMessage));
            }
        }

        [TestMethod]
        public void TestMethodISO_8583_1993EnumMessage()
        {
            using (IMessage message = new Message())
            {
                message.SetMessageField((ISO_8583_1993)field1, fields[field1]);
                message.SetMessageField((ISO_8583_1993)field2, fields[field2]);
                message.SetMessageField((ISO_8583_1993)field3, fields[field3]);
                message.SetMessageField((ISO_8583_1993)field4, fields[field4]);
                message.SetMessageField((ISO_8583_1993)field5, fields[field5]);
                message.SetMessageField((ISO_8583_1993)field6, fields[field6]);
                message.SetMessageField((ISO_8583_1993)field7, fields[field7]);
                message.SetMessageField((ISO_8583_1993)field8, fields[field8]);
                message.SetMessageField((ISO_8583_1993)field8, alterntiveMessage);

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessageFields();

                Assert.IsTrue(messages[field1].Contains(fields[field1]));
                Assert.IsTrue(messages[field2].Contains(fields[field2]));
                Assert.IsTrue(messages[field3].Contains(fields[field3]));
                Assert.IsTrue(messages[field4].Contains(fields[field4]));
                Assert.IsTrue(messages[field5].Contains(fields[field5]));
                Assert.IsTrue(messages[field6].Contains(fields[field6]));
                Assert.IsTrue(messages[field7].Contains(fields[field7]));
                Assert.IsTrue(messages[field8].Contains(alterntiveMessage));
            }
        }

        [TestMethod]
        public void TestMethodISO_8583_1993CustomEnumMessage()
        {
            using (IMessage message = new Message())
            {
                SetupCustomEnumField1993();

                message.SetMessageField(customEnum1993Field1);
                message.SetMessageField(customEnum1993Field2);
                message.SetMessageField(customEnum1993Field3);
                message.SetMessageField(customEnum1993Field4);
                message.SetMessageField(customEnum1993Field5);
                message.SetMessageField(customEnum1993Field6);
                message.SetMessageField(customEnum1993Field7);
                message.SetMessageField(customEnum1993Field8);

                customEnum1993Field8.Message = alterntiveMessage;
                message.SetMessageField(customEnum1993Field8);

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessageFields();

                Assert.IsTrue(messages[field1].Contains(fields[field1]));
                Assert.IsTrue(messages[field2].Contains(fields[field2]));
                Assert.IsTrue(messages[field3].Contains(fields[field3]));
                Assert.IsTrue(messages[field4].Contains(fields[field4]));
                Assert.IsTrue(messages[field5].Contains(fields[field5]));
                Assert.IsTrue(messages[field6].Contains(fields[field6]));
                Assert.IsTrue(messages[field7].Contains(fields[field7]));
                Assert.IsTrue(messages[field8].Contains(alterntiveMessage));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryMessage()
        {
            using (IMessage message = new Message())
            {
                IDictionary<uint, string> inputMessages = new Dictionary<uint, string>();

                inputMessages.Add(field1, fields[field1]);
                inputMessages.Add(field2, fields[field2]);
                inputMessages.Add(field3, fields[field3]);
                inputMessages.Add(field4, fields[field4]);
                inputMessages.Add(field5, fields[field5]);
                inputMessages.Add(field6, fields[field6]);
                inputMessages.Add(field7, fields[field7]);
                inputMessages.Add(field8, fields[field8]);

                message.SetMessageFields(inputMessages);

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessageFields();

                Assert.IsTrue(messages[field1].Contains(fields[field1]));
                Assert.IsTrue(messages[field2].Contains(fields[field2]));
                Assert.IsTrue(messages[field3].Contains(fields[field3]));
                Assert.IsTrue(messages[field4].Contains(fields[field4]));
                Assert.IsTrue(messages[field5].Contains(fields[field5]));
                Assert.IsTrue(messages[field6].Contains(fields[field6]));
                Assert.IsTrue(messages[field7].Contains(fields[field7]));
                Assert.IsTrue(messages[field8].Contains(fields[field8]));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryISO_8583_1987EnumMessage()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1987))
            {
                IDictionary<ISO_8583_1987, string> inputMessages = new Dictionary<ISO_8583_1987, string>();

                inputMessages.Add((ISO_8583_1987)field1, fields[field1]);
                inputMessages.Add((ISO_8583_1987)field2, fields[field2]);
                inputMessages.Add((ISO_8583_1987)field3, fields[field3]);
                inputMessages.Add((ISO_8583_1987)field4, fields[field4]);
                inputMessages.Add((ISO_8583_1987)field5, fields[field5]);
                inputMessages.Add((ISO_8583_1987)field6, fields[field6]);
                inputMessages.Add((ISO_8583_1987)field7, fields[field7]);
                inputMessages.Add((ISO_8583_1987)field8, fields[field8]);

                message.SetMessageFields(inputMessages);

                this.PackAndUnpack(message);

                IDictionary<ISO_8583_1987, string>? messages = message.GetMessageFieldsEnum1987();

                Assert.IsTrue(messages[(ISO_8583_1987)field1].Contains(fields[field1]));
                Assert.IsTrue(messages[(ISO_8583_1987)field2].Contains(fields[field2]));
                Assert.IsTrue(messages[(ISO_8583_1987)field3].Contains(fields[field3]));
                Assert.IsTrue(messages[(ISO_8583_1987)field4].Contains(fields[field4]));
                Assert.IsTrue(messages[(ISO_8583_1987)field5].Contains(fields[field5]));
                Assert.IsTrue(messages[(ISO_8583_1987)field6].Contains(fields[field6]));
                Assert.IsTrue(messages[(ISO_8583_1987)field7].Contains(fields[field7]));
                Assert.IsTrue(messages[(ISO_8583_1987)field8].Contains(fields[field8]));

                message.Initialize();

                Assert.IsTrue(messages.Count.Equals(0));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryISO_8583_1987CustomEnumMessage()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1987))
            {
                SetupCustomEnumField1987();

                List<ISO_8583_1987_FIELD> inputMessages = new List<ISO_8583_1987_FIELD>();

                inputMessages.Add(customEnum1987Field1);
                inputMessages.Add(customEnum1987Field2);
                inputMessages.Add(customEnum1987Field3);
                inputMessages.Add(customEnum1987Field4);
                inputMessages.Add(customEnum1987Field5);
                inputMessages.Add(customEnum1987Field6);
                inputMessages.Add(customEnum1987Field7);
                inputMessages.Add(customEnum1987Field8);

                message.SetMessageFields(inputMessages);

                this.PackAndUnpack(message);

                List<ISO_8583_1987_FIELD>? messages = message.GetMessageFieldsCustomEnum1987();

                Assert.IsTrue(messages.First(item => item.Position == field1).Message.Contains(fields[field1]));
                Assert.IsTrue(messages.First(item => item.Position == field2).Message.Contains(fields[field2]));
                Assert.IsTrue(messages.First(item => item.Position == field3).Message.Contains(fields[field3]));
                Assert.IsTrue(messages.First(item => item.Position == field4).Message.Contains(fields[field4]));
                Assert.IsTrue(messages.First(item => item.Position == field5).Message.Contains(fields[field5]));
                Assert.IsTrue(messages.First(item => item.Position == field6).Message.Contains(fields[field6]));
                Assert.IsTrue(messages.First(item => item.Position == field7).Message.Contains(fields[field7]));
                Assert.IsTrue(messages.First(item => item.Position == field8).Message.Contains(fields[field8]));

                message.Initialize();

                Assert.IsTrue(messages.Count.Equals(0));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryISO_8583_1993EnumMessage()
        {
            using (IMessage message = new Message())
            {
                IDictionary<ISO_8583_1993, string> inputMessages = new Dictionary<ISO_8583_1993, string>();

                inputMessages.Add((ISO_8583_1993)field1, fields[field1]);
                inputMessages.Add((ISO_8583_1993)field2, fields[field2]);
                inputMessages.Add((ISO_8583_1993)field3, fields[field3]);
                inputMessages.Add((ISO_8583_1993)field4, fields[field4]);
                inputMessages.Add((ISO_8583_1993)field5, fields[field5]);
                inputMessages.Add((ISO_8583_1993)field6, fields[field6]);
                inputMessages.Add((ISO_8583_1993)field7, fields[field7]);
                inputMessages.Add((ISO_8583_1993)field8, fields[field8]);

                message.SetMessageFields(inputMessages);

                this.PackAndUnpack(message);

                IDictionary<ISO_8583_1993, string>? messages = message.GetMessageFieldsEnum1993();

                Assert.IsTrue(messages[(ISO_8583_1993)field1].Contains(fields[field1]));
                Assert.IsTrue(messages[(ISO_8583_1993)field2].Contains(fields[field2]));
                Assert.IsTrue(messages[(ISO_8583_1993)field3].Contains(fields[field3]));
                Assert.IsTrue(messages[(ISO_8583_1993)field4].Contains(fields[field4]));
                Assert.IsTrue(messages[(ISO_8583_1993)field5].Contains(fields[field5]));
                Assert.IsTrue(messages[(ISO_8583_1993)field6].Contains(fields[field6]));
                Assert.IsTrue(messages[(ISO_8583_1993)field7].Contains(fields[field7]));
                Assert.IsTrue(messages[(ISO_8583_1993)field8].Contains(fields[field8]));

                message.Initialize();

                Assert.IsTrue(messages.Count.Equals(0));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryISO_8583_1993CustomEnumMessage()
        {
            using (IMessage message = new Message())
            {
                SetupCustomEnumField1993();

                List<ISO_8583_1993_FIELD> inputMessages = new List<ISO_8583_1993_FIELD>();

                inputMessages.Add(customEnum1993Field1);
                inputMessages.Add(customEnum1993Field2);
                inputMessages.Add(customEnum1993Field3);
                inputMessages.Add(customEnum1993Field4);
                inputMessages.Add(customEnum1993Field5);
                inputMessages.Add(customEnum1993Field6);
                inputMessages.Add(customEnum1993Field7);
                inputMessages.Add(customEnum1993Field8);

                message.SetMessageFields(inputMessages);

                this.PackAndUnpack(message);

                List<ISO_8583_1993_FIELD>? messages = message.GetMessageFieldsCustomEnum1993();

                Assert.IsTrue(messages.First(item => item.Position == field1).Message.Contains(fields[field1]));
                Assert.IsTrue(messages.First(item => item.Position == field2).Message.Contains(fields[field2]));
                Assert.IsTrue(messages.First(item => item.Position == field3).Message.Contains(fields[field3]));
                Assert.IsTrue(messages.First(item => item.Position == field4).Message.Contains(fields[field4]));
                Assert.IsTrue(messages.First(item => item.Position == field5).Message.Contains(fields[field5]));
                Assert.IsTrue(messages.First(item => item.Position == field6).Message.Contains(fields[field6]));
                Assert.IsTrue(messages.First(item => item.Position == field7).Message.Contains(fields[field7]));
                Assert.IsTrue(messages.First(item => item.Position == field8).Message.Contains(fields[field8]));

                message.Initialize();
                messages = message.GetMessageFieldsCustomEnum1993();

                Assert.IsTrue(messages.Count.Equals(0));
            }
        }

        [TestMethod]
        public void TestMethodTypeClassISO_8583_1987()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1987))
            {
                ExampleModel1987Test exampleModel = new ExampleModel1987Test();

                exampleModel.Id = 1;
                exampleModel.MessageTypeIndicator = fields[field1];
                exampleModel.PrimaryAccountNumber = fields[field2];
                exampleModel.AmountTxn = fields[field3];
                exampleModel.SystemsTraceAuditNumber = fields[field4];
                exampleModel.Response_Code = fields[field5];
                exampleModel.CardAcceptorTerminalId = fields[field6];
                exampleModel.CardAcceptorIdCode = fields[field7];
                exampleModel.ReservedForPrivateUse = fields[field8];

                message.SetMessage<ExampleModel1987Test>(exampleModel);

                this.PackAndUnpack(message);

                ExampleModel1987Test? messages = message.GetMessage<ExampleModel1987Test>();

                Assert.IsTrue(messages.MessageTypeIndicator.Contains(fields[field1]));
                Assert.IsTrue(messages.PrimaryAccountNumber.Contains(fields[field2]));
                Assert.IsTrue(messages.AmountTxn.Contains(fields[field3]));
                Assert.IsTrue(messages.SystemsTraceAuditNumber.Contains(fields[field4]));
                Assert.IsTrue(messages.Response_Code.Contains(fields[field5]));
                Assert.IsTrue(messages.CardAcceptorTerminalId.Contains(fields[field6]));
                Assert.IsTrue(messages.CardAcceptorIdCode.Contains(fields[field7]));
                Assert.IsTrue(messages.ReservedForPrivateUse.Contains(fields[field8]));
            }
        }

        [TestMethod]
        public void TestMethodTypeClassISO_8583_1993()
        {
            using (IMessage message = new Message())
            {
                ExampleModel1993Test exampleModel = new ExampleModel1993Test();

                exampleModel.Id = 1;
                exampleModel.MessageTypeIndicator = fields[field1];
                exampleModel.PrimaryAccountNumber = fields[field2];
                exampleModel.AmountTxn = fields[field3];
                exampleModel.SystemsTraceAuditNumber = fields[field4];
                exampleModel.ActionCode = fields[field5];
                exampleModel.CardAcceptorTerminalId = fields[field6];
                exampleModel.CardAcceptorIdCode = fields[field7];
                exampleModel.ReservedForPrivateUse = fields[field8];

                message.SetMessage<ExampleModel1993Test>(exampleModel);

                this.PackAndUnpack(message);

                ExampleModel1993Test? messages = message.GetMessage<ExampleModel1993Test>();

                Assert.IsTrue(messages.MessageTypeIndicator.Contains(fields[field1]));
                Assert.IsTrue(messages.PrimaryAccountNumber.Contains(fields[field2]));
                Assert.IsTrue(messages.AmountTxn.Contains(fields[field3]));
                Assert.IsTrue(messages.SystemsTraceAuditNumber.Contains(fields[field4]));
                Assert.IsTrue(messages.ActionCode.Contains(fields[field5]));
                Assert.IsTrue(messages.CardAcceptorTerminalId.Contains(fields[field6]));
                Assert.IsTrue(messages.CardAcceptorIdCode.Contains(fields[field7]));
                Assert.IsTrue(messages.ReservedForPrivateUse.Contains(fields[field8]));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ISO_8583_Class_Attribute_Exception))]
        public void TestMethodTypeClassWithoutClassAttribute()
        {
            using (IMessage message = new Message())
            {
                ExampleModelWithoutClassAttribute exampleModel = new ExampleModelWithoutClassAttribute();
                exampleModel.Id = 1;

                message.SetMessage<ExampleModelWithoutClassAttribute>(exampleModel);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ISO_8583_Field_Attribute_Exception))]
        public void TestMethodTypeClassWithoutFieldAttribute()
        {
            using (IMessage message = new Message())
            {
                ExampleModelWithoutFieldAttribute exampleModel = new ExampleModelWithoutFieldAttribute();
                exampleModel.Id = 1;

                message.SetMessage<ExampleModelWithoutFieldAttribute>(exampleModel);
            }
        }
    }
}