using System;

namespace Simcorp.IMS.Phone.Battery {
    public abstract class BaseBattery {
        private double vVolume;
        private double vChargeLevel;

        public double Volume {
            get {
                return vVolume;
            }
            private set {
                if (value <= 0) {throw new ArgumentOutOfRangeException("Battery volume must be positive"); }
                vVolume = value;
            }
        }

        public double ChargeLevel {
            get {
                return (int)vChargeLevel;
            }
            private set {
                if (value < 0){
                    value = 0;
                }
                if (value > 100){
                    value = 100;
                }
                vChargeLevel = value;
            }
        }

        public BaseBattery(double vol){
            Volume = vol;
        }

        public void Charge(double energy) {
            if (this.ChargeLevel + energy < this.Volume) {
                this.ChargeLevel += energy;
            }
            else {
                Console.WriteLine("Battery is charged");
            }
        }

        public void GiveCharge(double energy) {
            if (this.ChargeLevel - energy < 0) {
                ChargeLevel -= energy;
            }
            else {
                Console.WriteLine("Battery discharged");
            }
        }
    }
}