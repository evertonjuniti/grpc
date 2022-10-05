using NetCoreIso8583x64Lib;

namespace NetCoreIso8583x64LibMsTest
{
    [TestClass]
    public class UnitTestMessage
    {
        [TestMethod]
        public void TestMethodSimpleMessage()
        {
            using (IMessage message = new Message())
            {
                message.SetMessage(0, "1234");
                message.SetMessage(2, "1234567890123456");
                message.SetMessage(4, "5699");
                message.SetMessage(11, "234");
                message.SetMessage(39, "4");
                message.SetMessage(41, "12345");
                message.SetMessage(42, "678901234");
                message.SetMessage(125, "BLAH BLAH");

                byte[] packedMessage = message.PackMessage();

                message.UnpackMessage(packedMessage);

                IDictionary<uint, string> messages = message.GetMessages();

                Assert.IsTrue(messages[0].Contains("1234"));
                Assert.IsTrue(messages[2].Contains("1234567890123456"));
                Assert.IsTrue(messages[4].Contains("5699"));
                Assert.IsTrue(messages[11].Contains("234"));
                Assert.IsTrue(messages[39].Contains("4"));
                Assert.IsTrue(messages[41].Contains("12345"));
                Assert.IsTrue(messages[42].Contains("678901234"));
                Assert.IsTrue(messages[125].Contains("BLAH BLAH"));
            }
        }

        [TestMethod]
        public void TestMethodDictionaryMessage()
        {
            using (IMessage message = new Message(STANDARD.ISO_8583_1993))
            {
                IDictionary<uint, string> inputMessages = new Dictionary<uint, string>();

                inputMessages.Add(0, "1234");
                inputMessages.Add(2, "1234567890123456");
                inputMessages.Add(4, "5699");
                inputMessages.Add(11, "234");
                inputMessages.Add(39, "4");
                inputMessages.Add(41, "12345");
                inputMessages.Add(42, "678901234");
                inputMessages.Add(125, "BLAH BLAH");

                message.SetMessages(inputMessages);

                byte[] packedMessage = message.PackMessage();

                message.UnpackMessage(packedMessage);

                IDictionary<uint, string> messages = message.GetMessages();

                Assert.IsTrue(messages[0].Contains("1234"));
                Assert.IsTrue(messages[2].Contains("1234567890123456"));
                Assert.IsTrue(messages[4].Contains("5699"));
                Assert.IsTrue(messages[11].Contains("234"));
                Assert.IsTrue(messages[39].Contains("4"));
                Assert.IsTrue(messages[41].Contains("12345"));
                Assert.IsTrue(messages[42].Contains("678901234"));
                Assert.IsTrue(messages[125].Contains("BLAH BLAH"));
            }
        }
    }
}