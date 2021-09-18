using System;
using System.Linq;

namespace DesafioDIO {
    class Program {
        static void Main() {
            string [] arrTemp = {"9","10","9","10"};
            var s = JogoFactory.Create(arrTemp).GetTempoPartida();
            Console.WriteLine(s);
        }
    }
}
