using System;

namespace jenkinswithdotnet
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createMessage());
        }

        public static String createMessage()
        {
            return "Hello world";
        }
    }
}
