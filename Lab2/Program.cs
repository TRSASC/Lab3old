using System;
using Simcorp.IMS.Phone.Output;
using Simcorp.IMS.Phone.Speaker;

namespace Simcorp.IMS.Phone {
    public class Program {
        static void Main(string[] args) {
            SimCorpMobile simCorp = new SimCorpMobile(new ConsoleOutput());
            ///Console.WriteLine(simCorp.GetDescription());
            simCorp.SetPlaybackDevice();
            Track sound = new Track();
            simCorp.Play(sound);
            Console.ReadKey();
        }
    }
}