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
        private LiIonBattery vBattery;
        private StereoSpeakerSystem vSpeaker;
        private TouchScreenKeyboard vKeyBoard;
        private MobileMicrophone vMicrophone;
        private OLEDScreen vScreen;
        private DualSimCardSlot vSimCard;
        private VideoCamera vMainCamera;
        private VideoCamera vFrontalCamera;

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
    }
}
