using System;
namespace Delegate24
{
    public class Program
    {
        public delegate bool MyDelegate(int x);
        public static void Main()
        {
            MyDelegate myDelegate = new MyDelegate(Helper.IsNatural);

            Console.WriteLine(myDelegate(0));
        }
    }
}
