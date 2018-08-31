using System.Collections.Generic;

namespace Simcorp.IMS.Phone.SimCard {
    public abstract class BaseSimCardSlot {
        private BaseSimCard vSimCard1;

        public BaseSimCard SimCard1 {
            get { return vSimCard1; }
            set { vSimCard1=value; }
        }

        public abstract void FetchNetwork();

        public BaseSimCardSlot(BaseSimCard simCard) {
            SimCard1 = simCard;
        }
    }
}
