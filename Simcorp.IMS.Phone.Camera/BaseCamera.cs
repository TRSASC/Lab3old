using System;

namespace Simcorp.IMS.Phone.Camera {
    public abstract class BaseCamera {
        private double vQuality;
        private bool vFlash;
        private bool vAutoFocus;
        private string vDesc;

        public double Quality {
            get { return vQuality; }
            private set {
                if (value <= 0) { throw new ArgumentOutOfRangeException("Quality must be positive"); }
                vQuality = value;
            }
        }
        public bool Flash { get; private set; }
        public bool AutoFocus { get; private set; }
        public string Desc { get; set; }

        public BaseCamera(string desc, double quality, bool flash, bool autoFocus) {
            Desc = desc;
            Quality = quality;
            Flash = flash;
            AutoFocus = autoFocus;
        }

        public void MakePhoto(IView view) {
            ///Some code that makes photo
        }
    }
}
