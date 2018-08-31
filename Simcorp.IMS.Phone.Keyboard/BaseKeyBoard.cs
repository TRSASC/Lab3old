using System.Collections.Generic;
using Simcorp.IMS.Phone.Button;

namespace Simcorp.IMS.Phone.Keyboard
{
    public abstract class BaseKeyboard
    {
        private List<BaseButton> keys;
        public List<BaseButton> Keys
        {
            get { return keys; }
            set { keys = value; }
        }
    }
}
