﻿namespace Simcorp.IMS.Phone.Button {
    public class TypeButton : BaseButton {
        string typechar;

        public TypeButton(char a) {
            typechar = a.ToString().ToLower();
            desc = a.ToString().ToLower();
        }

        public override void Action() {
            ///Typing implementation
        }
    }
}
