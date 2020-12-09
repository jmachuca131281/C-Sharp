using System;

namespace Dinamic_Polimorphism_Adstract
{
    class Owl: Bird
    {
        static void Main(string[] args)
        {
            Owl owl = new Owl();
            var color = owl.color().ToString();
            var flay = owl.Fly().ToString();
            var sign = owl.Sign().ToString();

            Pigeon pigueon = new Pigeon();
            var color1 = pigueon.color().ToString();
            var flay1 = pigueon.Fly().ToString();
            var sing1 = pigueon.Sign().ToString();

            Console.WriteLine("Owl" + color + flay + sign);
            Console.WriteLine("Pigueon" + color1 + flay1 + sing1);
        }
        public override string color()
        {
            return "red";
        }
    }
    class Pigeon : Bird
    {
        public override string color()
        {
            return "white";
        }
    }
    abstract class Bird
    {
        public abstract string color();
        public string Fly()
        {
            return "Fly"; 
        }   
        public string Sign()
        {
            return "sing";            
        }
    }
}
