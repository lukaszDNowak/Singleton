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
            Console.WriteLine("Roman rozpoczyna pracê");
            var roman = RomanEmployee.Start();
            Console.WriteLine($"Pracownik jest w pracy: {RomanEmployee.IsWorking()}");
            Console.WriteLine("Roman koñczy pracê");
            RomanEmployee.Stop();
            Console.WriteLine($"Pracownik jest w pracy: {RomanEmployee.IsWorking()}");

            Console.WriteLine("Roman nie pracuje");
            Console.WriteLine($"Pracownik pracuje ju¿ { RomanEmployee.WorkingTime()} ");
            Console.WriteLine("Roman pracuje");
            roman = RomanEmployee.Start();
            Thread.Sleep(3000); // Czeka 3 sekundy.
            Console.WriteLine($"Pracownik pracuje ju¿ { RomanEmployee.WorkingTime()}");
            Console.ReadKey();
        }
    }

    public class RomanEmployee
    {
        private static DateTime timeStart = DateTime.Now;
        private static RomanEmployee instance;
        protected RomanEmployee() {}
        public static RomanEmployee Start() => instance == null ? instance = new RomanEmployee() : instance;
        public static bool IsWorking() => instance != null ? true : false;
        public static RomanEmployee Stop() =>  instance = null;

        internal static string WorkingTime()
        {
            string result = "-1";
            return result = instance == null ? result : (DateTime.Now - timeStart).ToString("mmss");
        }
    }

}
