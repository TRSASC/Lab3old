namespace Simcorp.IMS.Phone.Speaker {
    public class ExternalSpeaker : BaseSpeakerSystem, IPlay{
        public ExternalSpeaker(BaseSpeaker speaker1, int curVolume) : base(speaker1, curVolume) {
        }

        public override void Play(ISoundable sound) {
            System.Console.WriteLine($"{nameof(ExternalSpeaker)} sound");
            Speaker1.Play(sound);
        }
    }
}
