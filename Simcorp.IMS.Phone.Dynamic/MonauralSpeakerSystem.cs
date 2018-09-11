namespace Simcorp.IMS.Phone.Speaker {
    public class MonauralSpeakerSystem : BaseSpeakerSystem, IPlay {
        public MonauralSpeakerSystem(BaseSpeaker speaker1, int curVolume) : base(speaker1, curVolume) { }

        public override void Play(ISoundable sound) {
            System.Console.WriteLine($"{nameof(MonauralSpeakerSystem)} sound");
            Speaker1.Play(sound);
        }
        
        public override string ToString() {
            return "Monaural speaker: " + this.Speaker1.ToString() + " Wt";
        }

    }
}
