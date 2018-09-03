namespace Simcorp.IMS.Phone.Speaker
{
    public abstract class BaseSpeakerSystem
    {
        private int vCurvolume;
        private BaseSpeaker vSpeaker1;

        public int CurVolume {
            get { return vCurvolume; }
            protected set {
                if (value > 100) { value = 100; }
                if (value < 0) { value = 0; }
                vCurvolume = value;
            }
        }

        public BaseSpeaker Speaker1 {
            get { return vSpeaker1; }
            set { vSpeaker1 = value; }
        }

        public BaseSpeakerSystem(BaseSpeaker speaker1, int curVolume){
            Speaker1 = speaker1;
            CurVolume = curVolume;
        }

        public void SetVolume(bool volumeup) {
            int changevolume = volumeup ? 1 : -1;
            CurVolume += changevolume;
        }

        public abstract void ReproduceSound(IReproduceSound sound);
        public abstract void ReproduceSound(IReproduceSound sound1, IReproduceSound sound2); ///In case of stereo sound
    }
}
