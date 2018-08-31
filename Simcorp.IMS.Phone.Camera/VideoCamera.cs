namespace Simcorp.IMS.Phone.Camera {
    public class VideoCamera : PhotoCamera {
        public VideoCamera(string desc, double quality, bool flash, bool autoFocus) : base(desc, quality, flash, autoFocus) {}

        public void MakeVideo(IView view) {
            ///Some code to fetch Video
        }

        public override string ToString() {
            return Desc + " video camera: " + this.Quality + " Mpx";
        }
    }
}
