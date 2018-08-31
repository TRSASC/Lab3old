using System;

namespace Simcorp.IMS.Phone {
    public class Program {
        static void Main(string[] args) {
            SimCorpMobile simCorp = new SimCorpMobile();
            Console.WriteLine(simCorp.GetDescription());
            Console.ReadKey();
        }
    }
}

