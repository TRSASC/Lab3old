using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.Phone.Speaker;
using Simcorp.IMS.Phone.Output;

namespace IPlayTest {
    [TestClass]
    public class IPlayTest {
        [TestMethod]
        public void PlayStereoSpeakerSystemTest() {
            //-- Arrange
            FakeOutput output = new FakeOutput();

            StereoSpeakerSystem device = new StereoSpeakerSystem(new RealSpeaker(2), new RealSpeaker(2), 20, output);
            string ExpectedString = $"{nameof(StereoSpeakerSystem)} sound";

            //-- Act

            device.Play(new Track());

            //-- Assert
            Assert.AreEqual(output.Result, ExpectedString);
        }

        [TestMethod]
        public void PlayMonauralSpeakerSystemTest() {
            //-- Arrange
            FakeOutput output = new FakeOutput();

            MonauralSpeakerSystem device = new MonauralSpeakerSystem(new RealSpeaker(2), 20, output);
            string ExpectedString = $"{nameof(MonauralSpeakerSystem)} sound";

            //-- Act

            device.Play(new Track());

            //-- Assert
            Assert.AreEqual(output.Result, ExpectedString);
        }

        [TestMethod]
        public void PlayUnofficialHeadsetTest() {
            //-- Arrange
            FakeOutput output = new FakeOutput();

            UnofficialHeadset device = new UnofficialHeadset(new RealSpeaker(2), new RealSpeaker(2), 20, output);
            string ExpectedString = $"{nameof(UnofficialHeadset)} sound";

            //-- Act

            device.Play(new Track());

            //-- Assert
            Assert.AreEqual(output.Result, ExpectedString);
        }

        [TestMethod]
        public void PlaySamsungHeadsetTest() {
            //-- Arrange
            FakeOutput output = new FakeOutput();

            SamsungHeadset device = new SamsungHeadset(new RealSpeaker(2), new RealSpeaker(2), 20, output);
            string ExpectedString = $"{nameof(SamsungHeadset)} sound";

            //-- Act

            device.Play(new Track());

            //-- Assert
            Assert.AreEqual(output.Result, ExpectedString);
        }

        [TestMethod]
        public void PlayExternalSpeakerTest() {
            //-- Arrange
            FakeOutput output = new FakeOutput();

            ExternalSpeaker device = new ExternalSpeaker(new RealSpeaker(2), 20, output);
            string ExpectedString = $"{nameof(ExternalSpeaker)} sound";

            //-- Act

            device.Play(new Track());

            //-- Assert
            Assert.AreEqual(output.Result, ExpectedString);
        }
    }
}
