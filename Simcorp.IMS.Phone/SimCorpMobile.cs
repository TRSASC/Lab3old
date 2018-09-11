using System;
using System.Text;
using Simcorp.IMS.Phone.Battery;
using Simcorp.IMS.Phone.Speaker;
using Simcorp.IMS.Phone.Keyboard;
using Simcorp.IMS.Phone.Microphone;
using Simcorp.IMS.Phone.Screen;
using Simcorp.IMS.Phone.SimCard;
using Simcorp.IMS.Phone.Camera;

namespace Simcorp.IMS.Phone {
    public class SimCorpMobile : BaseMobile {
        private string vModelName;
        private BaseBattery vBattery;
        private StereoSpeakerSystem vSpeaker;
        private TouchScreenKeyboard vKeyBoard;
        private MobileMicrophone vMicrophone;
        private OLEDScreen vScreen;
        private DualSimCardSlot vSimCard;
        private VideoCamera vMainCamera;
        private VideoCamera vFrontalCamera;
        private string speakerSystemName;

        public override BaseBattery Battery { get { return vBattery; } }
        public override BaseSpeakerSystem Speaker { get { return vSpeaker; } }
        public override BaseKeyboard KeyBoard { get { return vKeyBoard; } }
        public override BaseMicrophone Microphone { get { return vMicrophone; } }
        public override string ModelName { get { return vModelName; } }
        public override BaseScreen Screen { get { return vScreen; } }
        public override BaseSimCardSlot SimCard { get { return vSimCard; } }
        public VideoCamera MainCamera { get { return vMainCamera; } }
        public VideoCamera FrontalCamera { get { return vFrontalCamera; } }

        private void MakePhoto(IView view) {
            MainCamera.MakePhoto(view);
            FrontalCamera.MakePhoto(view);
        }

        private void MakeVideo(IView view) {
            MainCamera.MakeVideo(view);
            FrontalCamera.MakeVideo(view);
        }

        public SimCorpMobile() {
            vModelName = "SimCorp Mobile";
            vBattery = new LiIonBattery(3000);
            vSpeaker = new StereoSpeakerSystem(new RealSpeaker(2), new RealSpeaker(2), 40);
            speakerSystemName = nameof(StereoSpeakerSystem);
            vKeyBoard = new TouchScreenKeyboard();
            vMicrophone = new MobileMicrophone();
            vSimCard = new DualSimCardSlot(SimCardTypes.MicroSimCard, SimCardTypes.NanoSimCard);
            vScreen = new OLEDScreen(1280, 720, 280);
            vMainCamera = new VideoCamera("Main", 13, true, true);
            vFrontalCamera = new VideoCamera("Frontal", 5, true, true);
        }

        public override string GetDescription() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.Append(base.GetDescription());
            descriptionBuilder.AppendLine($"{MainCamera.ToString()}");
            descriptionBuilder.AppendLine($"{FrontalCamera.ToString()}");
            return descriptionBuilder.ToString();
        }

        private IPlay PlaybackDevice { get; set; }
        public void SetPlaybackDevice() {
            string playbackDeviceName;
            Console.Write("Select playback device:\n1 - Phone speakers\n2 - Unofficial headphones\n3 - Samsung headphones\n4 - External speaker\n");
            int selected = Int32.Parse(Console.ReadLine());

            switch (selected) {
                case 1:
                    PlaybackDevice = Speaker;
                    playbackDeviceName = speakerSystemName;
                    break;
                case 2:
                    PlaybackDevice = new UnofficialHeadset(new RealSpeaker(0.2), new RealSpeaker(0.2), 50);
                    playbackDeviceName = nameof(UnofficialHeadset);
                    break;
                case 3:
                    PlaybackDevice = new SamsungHeadset(new RealSpeaker(0.5), new RealSpeaker(0.5), 20);
                    playbackDeviceName = nameof(SamsungHeadset);
                break;
                case 4:
                    PlaybackDevice = new ExternalSpeaker(new RealSpeaker(10), 20);
                    playbackDeviceName = nameof(ExternalSpeaker);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();           
            }
            Console.Write($"{playbackDeviceName} playback selected\n Set playback to Mobile...\n");
        }

        public void Play(ISoundable sound) {
            Console.WriteLine(" Play sound in Mobile:");
            PlaybackDevice.Play(sound);
        }
    }
}
