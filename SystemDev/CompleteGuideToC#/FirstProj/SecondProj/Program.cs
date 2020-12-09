using System;

namespace SecondProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "7";
            double c = 0;
            float f = 0;
            int b = 23;
            string s = "";

            Console.WriteLine("Type is: " + a.GetType());
            c = Convert.ToDouble(a);
            Console.WriteLine(c);
            Console.WriteLine("Type is: " + c.GetType());
            f = float.Parse(a);
            Console.WriteLine("Type is: "+ f.GetType());
            Console.WriteLine("Original type is: " + b.GetType());
            Console.WriteLine("Convert to string: " + b.ToString());
            s = b.ToString();
            Console.WriteLine("Type is: " + s.GetType());
        }
    }
}
