using System;

namespace ExtensionMethod
{
    public static class extensionclass
    {
        public static void Combine(this DateTime extensionparameter, DateTime datepart, DateTime timepart)
        { 
     
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime item = new DateTime();
            item.Combine(new DateTime(), new DateTime());
            Console.WriteLine("Hello World!");
        }
    }
}
