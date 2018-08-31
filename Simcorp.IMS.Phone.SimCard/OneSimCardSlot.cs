using System.Collections.Generic;

namespace Simcorp.IMS.Phone.SimCard {
    public class OneSimCardSlot :BaseSimCardSlot {
        public OneSimCardSlot(BaseSimCard simCard) : base(simCard) {}

        public override void FetchNetwork() {
            SimCard1.GetSignal();
        }

        public override string ToString()
        {
            return "Single SimCard with type: " + SimCard1.ToString();
        }
    }
}
