namespace Simcorp.IMS.Phone.Dynamic {
    public class MonauralDynamic : BaseDynamic {
        public MonauralDynamic(double maxpower, int vol) : base(maxpower, vol) { }

        public override void ReproduceSound(IReproduceSound sound) {
            ///Some code to reproduce monophonic sound
        }

        public override string ToString() {
            return "Nonaural dynamic: " + this.Power.ToString() + " Wt";
        }
    }
}
