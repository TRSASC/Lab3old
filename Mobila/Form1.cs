using System;
using System.Windows.Forms;
using Simcorp.IMS.Phone;
using Simcorp.IMS.Phone.Output;
using Simcorp.IMS.Phone.Speaker;

namespace Mobila {
    public partial class PhoneForm : Form {
        public SimCorpMobile simCorp;

        public PhoneForm() {
            InitializeComponent();
            simCorp = new SimCorpMobile(new TextBoxOutput(textBox1));
            simCorp.PlaybackDevice = simCorp.Speaker;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            simCorp.PlaybackDevice = simCorp.Speaker;
            simCorp.PlaybackDeviceName = simCorp.SpeakerName;
            textBox1.AppendText(SelectionMsg(simCorp));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            simCorp.PlaybackDevice = new UnofficialHeadset(new RealSpeaker(0.2), new RealSpeaker(0.2), 50, new TextBoxOutput(textBox1));
            simCorp.PlaybackDeviceName = $"{nameof(UnofficialHeadset)}";
            textBox1.AppendText(SelectionMsg(simCorp));
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            simCorp.PlaybackDevice = new SamsungHeadset(new RealSpeaker(0.5), new RealSpeaker(0.5), 20, new TextBoxOutput(textBox1));
            simCorp.PlaybackDeviceName = $"{nameof(SamsungHeadset)}";
            textBox1.AppendText(SelectionMsg(simCorp));
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            simCorp.PlaybackDevice = new ExternalSpeaker(new RealSpeaker(10), 20, new TextBoxOutput(textBox1));
            simCorp.PlaybackDeviceName = $"{nameof(ExternalSpeaker)}";
            textBox1.AppendText(SelectionMsg(simCorp));
        }

        private void buttonPlay_Click(object sender, EventArgs e) {
            textBox1.AppendText("Set playback to Mobile" + Environment.NewLine);
            simCorp.Play(new Track());
        }

        private static string SelectionMsg(SimCorpMobile mobile){
            return mobile.PlaybackDeviceName + " playback selected" + Environment.NewLine;
        } 
    }
}
