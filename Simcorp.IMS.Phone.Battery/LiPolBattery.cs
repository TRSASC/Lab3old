namespace Simcorp.IMS.Phone.Battery {
    public class LiPolBattery : BaseBattery {
        public LiPolBattery(double vol) : base(vol) {}

        public override string ToString() {
            return "Lithium polymer battery: " + this.Volume + " mAh";
        }
    }
}
