namespace Simcorp.IMS.Phone.Dynamic {
    public abstract class BaseDynamic {
        private double vPower;
        private int vCurvolume;

        public double Power { get; protected set; }
        public int Curvolume {
            get { return vCurvolume; }
            protected set {
                if (value > 100) { value = 100; }
                if (value < 0) { value = 0; }
                vCurvolume = value;
            }
        }

        public BaseDynamic(double maxpower, int vol) {
            Power = maxpower;
            Curvolume = vol;
        }

        public void SetVolume(bool volumeup) {
            int changevolume = volumeup ? 1 : -1;
            Curvolume += changevolume;
        }

        public abstract void ReproduceSound(IReproduceSound sound);
    }
}