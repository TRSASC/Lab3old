using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMSPhone;
using System;

namespace FormatTest {

    public class TestStringFormatter : StringFormatter {
        protected override string GetTime() {
            return "18-09-2018 15:44:59";
        }
    }

    [TestClass]
    public class FormatTest {
        private string testTime = "18-09-2018 15:44:59";
        private string testMessage = "Hello";
        private string expMessage;
        private string resMessage;
        private StringFormatter stringFormatter = new TestStringFormatter();


        [TestMethod]
        public void TestFormatNone() {
            expMessage = "Hello" + Environment.NewLine;
            resMessage = stringFormatter.FormatNone(testMessage);
            Assert.AreEqual(expMessage, resMessage);
        }

        [TestMethod]
        public void TestFormatStartDateTime() {
            expMessage = "[18-09-2018 15:44:59] Hello" + Environment.NewLine;
            resMessage = stringFormatter.FormatStartDateTime(testMessage);
            Assert.AreEqual(expMessage, resMessage);
        }

        [TestMethod]
        public void TestFormatEndDateTime() {
            expMessage = "Hello [18-09-2018 15:44:59]" + Environment.NewLine;
            resMessage = stringFormatter.FormatEndDateTime(testMessage);
            Assert.AreEqual(expMessage, resMessage);
        }

        [TestMethod]
        public void TestFormatLower() {
            expMessage = "[18-09-2018 15:44:59] hello" + Environment.NewLine;
            resMessage = stringFormatter.FormatLower(testMessage);
            Assert.AreEqual(expMessage, resMessage);
        }

        [TestMethod]
        public void TestFormatUpper() {
            expMessage = "[18-09-2018 15:44:59] HELLO" + Environment.NewLine;
            resMessage = stringFormatter.FormatUpper(testMessage);
            Assert.AreEqual(expMessage, resMessage);
        }
    }
}
