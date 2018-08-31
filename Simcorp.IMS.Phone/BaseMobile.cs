using Simcorp.IMS.Phone.Battery;
using Simcorp.IMS.Phone.Dynamic;
using Simcorp.IMS.Phone.Keyboard;
using Simcorp.IMS.Phone.Microphone;
using Simcorp.IMS.Phone.Screen;
using Simcorp.IMS.Phone.SimCard;
using System.Text;

namespace Simcorp.IMS.Phone {
    public abstract class BaseMobile {
        public abstract string ModelName { get; }
        public abstract BaseBattery Battery { get; }
        public abstract BaseDynamic Dynamic { get; }
        public abstract BaseKeyboard KeyBoard { get; }
        public abstract BaseMicrophone Microphone { get; }
        public abstract BaseScreen Screen { get; }
        public abstract BaseSimCardSlot SimCard { get; }

        private void Show(IScreenable screenImage) {
            Screen.Show(screenImage);
        }

        private void FetchNetwork() {
            SimCard.FetchNetwork();
        }

        private void FetchSound(IFetchSound sound) {
            Microphone.FetchSound(sound);
        }

        private void ReproduceSound(IReproduceSound sound) {
            Dynamic.ReproduceSound(sound);
        }

        private void Charge(double energy) {
            Battery.Charge(energy);
        }

        private void GiveCharge(double energy) {
            Battery.GiveCharge(energy);
        }

        public virtual string GetDescription() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Model Name: {ModelName}");
            descriptionBuilder.AppendLine($"Battery : {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Dynamic : {Dynamic.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard type : {KeyBoard.ToString()}");
            descriptionBuilder.AppendLine($"Microphone : {Microphone.ToString()}");
            descriptionBuilder.AppendLine($"Sim card : {SimCard.ToString()}");
            descriptionBuilder.AppendLine($"Screen type : {Screen.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}