using System;

namespace Simcorp.IMS.Phone.Speaker {
    public class SamsungHeadset : BaseTwoSpeakersSystem, IPlay {
        public new int CurVolume {
            get { return CurVolume; }
            protected set {
                if (value > 100) { value = 100; }
                if (value < 0) { value = 0; }
                CurVolume = value;
            }
        }
        public SamsungHeadset(BaseSpeaker speaker1, BaseSpeaker speaker2, int curVolume) : base(speaker1, speaker2, curVolume) {
        }

        public override void Play(ISoundable sound) {
            ///Sound should be splitted into 2 parts to make stereo effect.
            ///In reality spliited sound will be different, so just imagine that they diifers:)
            ISoundable[] sounds = SplitSound(sound);
            System.Console.WriteLine($"{nameof(SamsungHeadset)} sound");
            Speaker1.Play(sounds[0]);
            Speaker2.Play(sounds[1]);
        }
    }
}
