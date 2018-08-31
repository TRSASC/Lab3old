namespace Simcorp.IMS.Phone.Battery {
    public class LiIonBattery : BaseBattery {
        public LiIonBattery(double vol) : base(vol){}

        public override string ToString() {
            return "Lithium-ion battery: " + this.Volume + " mAh";
        }
    }
}