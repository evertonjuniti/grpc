using NetCoreIso8583x64Lib;
using System;

namespace NetCoreIso8583x64LibMsTest
{
    [TestClass]
    public class UnitTestMessage
    {
        private readonly uint field1 = 0;
        private readonly uint field2 = 2;
        private readonly uint field3 = 4;
        private readonly uint field4 = 11;
        private readonly uint field5 = 39;
        private readonly uint field6 = 41;
        private readonly uint field7 = 42;
        private readonly uint field8 = 125;

        [TestMethod]
        public void TestMethodSimpleMessage()
        {
            using (IMessage message = new Message())
            {
                message.SetMessage(field1, "1234");
                message.SetMessage(field2, "1234567890123456");
                message.SetMessage(field3, "5699");
                message.SetMessage(field4, "234");
                message.SetMessage(field5, "4");
                message.SetMessage(field6, "12345");
                message.SetMessage(field7, "678901234");
                message.SetMessage(field8, "BLAH BLAH");

                byte[] packedMessage = message.PackMessage();

                message.UnpackMessage(packedMessage);

                IDictionary<uint, string> messages = message.GetMessages();

                Assert.IsTrue(messages[field1].Contains("1234"));
                Assert.IsTrue(messages[field2].Contains("1234567890123456"));
                Assert.IsTrue(messages[field3].Contains("5699"));
                Assert.IsTrue(messages[field4].Contains("234"));
                Assert.IsTrue(messages[field5].Contains("4"));
                Assert.IsTrue(messages[field6].Contains("12345"));
                Assert.IsTrue(messages[field7].Contains("678901234"));
                Assert.IsTrue(messages[field8].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodISO_8583_1987EnumMessage()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1987))
            {
                message.SetMessage((ISO_8583_1987)field1, "1234");
                message.SetMessage((ISO_8583_1987)field2, "1234567890123456");
                message.SetMessage((ISO_8583_1987)field3, "5699");
                message.SetMessage((ISO_8583_1987)field4, "234");
                message.SetMessage((ISO_8583_1987)field5, "4");
                message.SetMessage((ISO_8583_1987)field6, "12345");
                message.SetMessage((ISO_8583_1987)field7, "678901234");
                message.SetMessage((ISO_8583_1987)field8, "BLAH BLAH");

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessages();

                Assert.IsTrue(messages[field1].Contains("1234"));
                Assert.IsTrue(messages[field2].Contains("1234567890123456"));
                Assert.IsTrue(messages[field3].Contains("5699"));
                Assert.IsTrue(messages[field4].Contains("234"));
                Assert.IsTrue(messages[field5].Contains("4"));
                Assert.IsTrue(messages[field6].Contains("12345"));
                Assert.IsTrue(messages[field7].Contains("678901234"));
                Assert.IsTrue(messages[field8].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodISO_8583_1987CustomEnumMessage()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1987))
            {
                message.SetMessage(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field1), "1234");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field2), "1234567890123456");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field3), "5699");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field4), "234");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field5), "4");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field6), "12345");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field7), "678901234");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field8), "BLAH BLAH");

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessages();

                Assert.IsTrue(messages[field1].Contains("1234"));
                Assert.IsTrue(messages[field2].Contains("1234567890123456"));
                Assert.IsTrue(messages[field3].Contains("5699"));
                Assert.IsTrue(messages[field4].Contains("234"));
                Assert.IsTrue(messages[field5].Contains("4"));
                Assert.IsTrue(messages[field6].Contains("12345"));
                Assert.IsTrue(messages[field7].Contains("678901234"));
                Assert.IsTrue(messages[field8].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodISO_8583_1993EnumMessage()
        {
            using (IMessage message = new Message())
            {
                message.SetMessage((ISO_8583_1993)field1, "1234");
                message.SetMessage((ISO_8583_1993)field2, "1234567890123456");
                message.SetMessage((ISO_8583_1993)field3, "5699");
                message.SetMessage((ISO_8583_1993)field4, "234");
                message.SetMessage((ISO_8583_1993)field5, "4");
                message.SetMessage((ISO_8583_1993)field6, "12345");
                message.SetMessage((ISO_8583_1993)field7, "678901234");
                message.SetMessage((ISO_8583_1993)field8, "BLAH BLAH");

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessages();

                Assert.IsTrue(messages[field1].Contains("1234"));
                Assert.IsTrue(messages[field2].Contains("1234567890123456"));
                Assert.IsTrue(messages[field3].Contains("5699"));
                Assert.IsTrue(messages[field4].Contains("234"));
                Assert.IsTrue(messages[field5].Contains("4"));
                Assert.IsTrue(messages[field6].Contains("12345"));
                Assert.IsTrue(messages[field7].Contains("678901234"));
                Assert.IsTrue(messages[field8].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodISO_8583_1993CustomEnumMessage()
        {
            using (IMessage message = new Message())
            {
                message.SetMessage(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field1), "1234");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field2), "1234567890123456");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field3), "5699");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field4), "234");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field5), "4");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field6), "12345");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field7), "678901234");
                message.SetMessage(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field8), "BLAH BLAH");

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessages();

                Assert.IsTrue(messages[field1].Contains("1234"));
                Assert.IsTrue(messages[field2].Contains("1234567890123456"));
                Assert.IsTrue(messages[field3].Contains("5699"));
                Assert.IsTrue(messages[field4].Contains("234"));
                Assert.IsTrue(messages[field5].Contains("4"));
                Assert.IsTrue(messages[field6].Contains("12345"));
                Assert.IsTrue(messages[field7].Contains("678901234"));
                Assert.IsTrue(messages[field8].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryMessage()
        {
            using (IMessage message = new Message())
            {
                IDictionary<uint, string> inputMessages = new Dictionary<uint, string>();

                inputMessages.Add(field1, "1234");
                inputMessages.Add(field2, "1234567890123456");
                inputMessages.Add(field3, "5699");
                inputMessages.Add(field4, "234");
                inputMessages.Add(field5, "4");
                inputMessages.Add(field6, "12345");
                inputMessages.Add(field7, "678901234");
                inputMessages.Add(field8, "BLAH BLAH");

                message.SetMessages(inputMessages);

                this.PackAndUnpack(message);

                IDictionary<uint, string> messages = message.GetMessages();

                Assert.IsTrue(messages[field1].Contains("1234"));
                Assert.IsTrue(messages[field2].Contains("1234567890123456"));
                Assert.IsTrue(messages[field3].Contains("5699"));
                Assert.IsTrue(messages[field4].Contains("234"));
                Assert.IsTrue(messages[field5].Contains("4"));
                Assert.IsTrue(messages[field6].Contains("12345"));
                Assert.IsTrue(messages[field7].Contains("678901234"));
                Assert.IsTrue(messages[field8].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryISO_8583_1987EnumMessage()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1987))
            {
                IDictionary<ISO_8583_1987, string> inputMessages = new Dictionary<ISO_8583_1987, string>();

                inputMessages.Add((ISO_8583_1987)field1, "1234");
                inputMessages.Add((ISO_8583_1987)field2, "1234567890123456");
                inputMessages.Add((ISO_8583_1987)field3, "5699");
                inputMessages.Add((ISO_8583_1987)field4, "234");
                inputMessages.Add((ISO_8583_1987)field5, "4");
                inputMessages.Add((ISO_8583_1987)field6, "12345");
                inputMessages.Add((ISO_8583_1987)field7, "678901234");
                inputMessages.Add((ISO_8583_1987)field8, "BLAH BLAH");

                message.SetMessages(inputMessages);

                this.PackAndUnpack(message);

                IDictionary<ISO_8583_1987, string>? messages = message.GetMessages1987();

                Assert.IsTrue(messages[(ISO_8583_1987)field1].Contains("1234"));
                Assert.IsTrue(messages[(ISO_8583_1987)field2].Contains("1234567890123456"));
                Assert.IsTrue(messages[(ISO_8583_1987)field3].Contains("5699"));
                Assert.IsTrue(messages[(ISO_8583_1987)field4].Contains("234"));
                Assert.IsTrue(messages[(ISO_8583_1987)field5].Contains("4"));
                Assert.IsTrue(messages[(ISO_8583_1987)field6].Contains("12345"));
                Assert.IsTrue(messages[(ISO_8583_1987)field7].Contains("678901234"));
                Assert.IsTrue(messages[(ISO_8583_1987)field8].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryISO_8583_1987CustomEnumMessage()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1987))
            {
                IDictionary<ISO_8583_1987_FIELD, string> inputMessages = new Dictionary<ISO_8583_1987_FIELD, string>();

                inputMessages.Add(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field1), "1234");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field2), "1234567890123456");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field3), "5699");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field4), "234");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field5), "4");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field6), "12345");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field7), "678901234");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field8), "BLAH BLAH");

                message.SetMessages(inputMessages);

                this.PackAndUnpack(message);

                IDictionary<ISO_8583_1987_FIELD, string>? messages = message.GetMessages1987CustomEnum();

                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field1)].Contains("1234"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field2)].Contains("1234567890123456"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field3)].Contains("5699"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field4)].Contains("234"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field5)].Contains("4"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field6)].Contains("12345"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field7)].Contains("678901234"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1987_FIELD>().First(field => field.Position == field8)].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryISO_8583_1993EnumMessage()
        {
            using (IMessage message = new Message())
            {
                IDictionary<ISO_8583_1993, string> inputMessages = new Dictionary<ISO_8583_1993, string>();

                inputMessages.Add((ISO_8583_1993)field1, "1234");
                inputMessages.Add((ISO_8583_1993)field2, "1234567890123456");
                inputMessages.Add((ISO_8583_1993)field3, "5699");
                inputMessages.Add((ISO_8583_1993)field4, "234");
                inputMessages.Add((ISO_8583_1993)field5, "4");
                inputMessages.Add((ISO_8583_1993)field6, "12345");
                inputMessages.Add((ISO_8583_1993)field7, "678901234");
                inputMessages.Add((ISO_8583_1993)field8, "BLAH BLAH");

                message.SetMessages(inputMessages);

                this.PackAndUnpack(message);

                IDictionary<ISO_8583_1993, string>? messages = message.GetMessages1993();

                Assert.IsTrue(messages[(ISO_8583_1993)field1].Contains("1234"));
                Assert.IsTrue(messages[(ISO_8583_1993)field2].Contains("1234567890123456"));
                Assert.IsTrue(messages[(ISO_8583_1993)field3].Contains("5699"));
                Assert.IsTrue(messages[(ISO_8583_1993)field4].Contains("234"));
                Assert.IsTrue(messages[(ISO_8583_1993)field5].Contains("4"));
                Assert.IsTrue(messages[(ISO_8583_1993)field6].Contains("12345"));
                Assert.IsTrue(messages[(ISO_8583_1993)field7].Contains("678901234"));
                Assert.IsTrue(messages[(ISO_8583_1993)field8].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryISO_8583_1993CustomEnumMessage()
        {
            using (IMessage message = new Message())
            {
                IDictionary<ISO_8583_1993_FIELD, string> inputMessages = new Dictionary<ISO_8583_1993_FIELD, string>();

                inputMessages.Add(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field1), "1234");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field2), "1234567890123456");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field3), "5699");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field4), "234");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field5), "4");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field6), "12345");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field7), "678901234");
                inputMessages.Add(Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field8), "BLAH BLAH");

                message.SetMessages(inputMessages);

                this.PackAndUnpack(message);

                IDictionary<ISO_8583_1993_FIELD, string>? messages = message.GetMessages1993CustomEnum();

                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field1)].Contains("1234"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field2)].Contains("1234567890123456"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field3)].Contains("5699"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field4)].Contains("234"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field5)].Contains("4"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field6)].Contains("12345"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field7)].Contains("678901234"));
                Assert.IsTrue(messages[Enumeration.GetAll<ISO_8583_1993_FIELD>().First(field => field.Position == field8)].Contains("BLAH BLAH"));
            }
        }

        private void PackAndUnpack(IMessage message)
        {
            byte[] packedMessage = message.PackMessage();

            message.UnpackMessage(packedMessage);
        }
    }
}