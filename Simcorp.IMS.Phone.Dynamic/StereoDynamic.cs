namespace Simcorp.IMS.Phone.Dynamic {
    public class StereoDynamic : BaseDynamic {
        public StereoDynamic(double maxpower, int vol) : base(maxpower, vol) { }

        public override void ReproduceSound(IReproduceSound sound) {
            ///Some code to reproduce monophonic sound
        }

        public override string ToString() {
            return "Stereo dynamic: " + this.Power.ToString() + " Wt";
        }
    }
}