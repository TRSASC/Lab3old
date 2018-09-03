using System;

namespace Simcorp.IMS.Phone.Speaker {
    public class StereoSpeakerSystem : BaseSpeakerSystem {
        private BaseSpeaker vSpeaker2;

        public BaseSpeaker Speaker2 {
            get { return vSpeaker2; }
            set { vSpeaker2 = value; }
        }

        public StereoSpeakerSystem(BaseSpeaker speaker1, BaseSpeaker speaker2, int curVolume) : base(speaker1, curVolume) { Speaker2 = speaker2; }

        public override void ReproduceSound(IReproduceSound sound) {
            Speaker1.ReproduceSound(sound);
            Speaker2.ReproduceSound(sound);
        }

        public override void ReproduceSound(IReproduceSound sound1, IReproduceSound sound2) {
            Speaker1.ReproduceSound(sound1);
            Speaker2.ReproduceSound(sound2);
        }

        public override string ToString() {
            return "Stereo speakers: " + this.Speaker1.ToString() + " Wt + " + this.Speaker2.ToString() + " Wt";
        }
    }
}