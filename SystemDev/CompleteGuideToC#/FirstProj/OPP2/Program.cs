using System;

namespace OPP2
{
    class Program : Program2
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            var text = p.DisplayText();
            Console.WriteLine(text);

        }
    }
    class Program2
    {
        protected string DisplayText()
        {
            return "Inner DisplayText funtion of class Program2";
        }
    }
}
