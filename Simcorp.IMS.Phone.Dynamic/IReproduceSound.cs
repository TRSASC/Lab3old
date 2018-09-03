namespace Simcorp.IMS.Phone.Speaker {
    public interface IReproduceSound {
        double Bitrate { get; set; }
        void GiveSound();
    }
}
