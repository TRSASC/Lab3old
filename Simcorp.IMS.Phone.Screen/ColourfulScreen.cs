﻿namespace Simcorp.IMS.Phone.Screen {
    public class ColourfulScreen : BaseScreen {
        int brightness;

        public virtual int Brightness {
            get { return brightness; }
            set { brightness = value; }
        }

        public override void Show(IScreenable screenImage) {
            //here logic that draws monochrome image can be added
        }
        public virtual void Show(IScreenable screenImage, int brightness) {
            //here logic that draws monochrome image can be added
        }

        public override string ToString() {
            return "Colorful Screen";
        }

    }
}