
namespace Simcorp.IMS.Phone.Speaker
{
    public class RealSpeaker : BaseSpeaker
    {
        public RealSpeaker(double maxpower) : base(maxpower) { }

        public override void ReproduceSound(IReproduceSound sound) {
            ///Some code to reproduce sound
        }

        public override string ToString() {
            return Power.ToString();
        }
    }
}
