namespace Simcorp.IMS.Phone.Screen {
    public class OLEDScreen : ColourfulScreen {
        public override void Show(IScreenable screenImage) {
            //here logic that draws monochrome image can be added
        }
        public override void Show(IScreenable screenImage, int brightness) {
            //here logic that draws monochrome image can be added
        }

        public override string ToString() {
            return "OLED Screen";
        }
    }

}

