using System.Collections.Generic;

namespace Simcorp.IMS.Phone.SimCard {
    public class DualSimCardSlot : BaseSimCardSlot {
        private BaseSimCard vSimCard2;

        public BaseSimCard SimCard2  {
            get { return vSimCard2; }
            set { vSimCard2 = value; }
        }

        public DualSimCardSlot(BaseSimCard simCard, BaseSimCard simCard2) : base(simCard) {
            SimCard2 = simCard2;
        }

        public override void FetchNetwork() {
            SimCard1.GetSignal();
            SimCard2.GetSignal();
        }

        public override string ToString() {
            return "Dual SimCard with types: " + SimCard1.ToString() + " and " + SimCard2.ToString();
        }
    }
}
