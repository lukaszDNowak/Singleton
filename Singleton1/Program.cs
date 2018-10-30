using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanEmployee.IsWorking());
            RomanEmployee.Start();
            Console.WriteLine(RomanEmployee.IsWorking());
            RomanEmployee.Stop();
            Console.WriteLine(RomanEmployee.IsWorking());
            Console.ReadKey();
        }
    }

    public class RomanEmployee
    {
        private static RomanEmployee instance;
        protected RomanEmployee() {}
        public static RomanEmployee Start() => instance == null ? instance = new RomanEmployee() : instance;
        public static bool IsWorking() => instance != null ? true : false;
        public static RomanEmployee Stop() =>  instance = null;
   
    }

}
