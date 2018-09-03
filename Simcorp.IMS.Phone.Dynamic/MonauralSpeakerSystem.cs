namespace Simcorp.IMS.Phone.Speaker {
    public class MonauralSpeakerSystem : BaseSpeakerSystem {
        public MonauralSpeakerSystem(BaseSpeaker speaker1, int curVolume) : base(speaker1, curVolume) { }

        public override void ReproduceSound(IReproduceSound sound) {
            Speaker1.ReproduceSound(sound);
        }
        public override void ReproduceSound(IReproduceSound sound1, IReproduceSound sound2) {
            Speaker1.ReproduceSound(sound1);
            Speaker1.ReproduceSound(sound2);
        }

        public override string ToString() {
            return "Monaural speaker: " + this.Speaker1.ToString() + " Wt";
        }

    }
}
