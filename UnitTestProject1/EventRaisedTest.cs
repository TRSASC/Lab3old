using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.Phone;

namespace UnitTestProject1 {
    [TestClass]
    public class EventRaisedTest {
        private string result;

        [TestMethod]
        public void CheckEvent() {
            result = "";
            string expresult = "resultHello";
            SMSProvider smsProvider = new SMSProvider();
            smsProvider.SMSReceived += OnSMSReceived;
            smsProvider.SendSMS("Hello");
            Assert.AreEqual(result, expresult);

        }

        private void OnSMSReceived(string message) {
            result = "result" + message;
        }
    }
}
