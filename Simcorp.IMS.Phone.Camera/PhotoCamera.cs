namespace Simcorp.IMS.Phone.Camera {
    public class PhotoCamera : BaseCamera {
        public PhotoCamera(string desc, double quality, bool flash, bool autoFocus) : base(desc, quality, flash, autoFocus) {}

        public override string ToString() {
            return Desc + " photo camera: " + this.Quality + " Mpx";
        }
    }
}
