using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Covariance_and_Contravariance
{
    class Program
    {
        public string GetString() {
            return "sample string";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("----------Implementing Covariance-----------");
            //declaring covariance
            object[] car = new string[10];  // object array hold the refernce of string array

            //car[0] = 12;         // car object array is of string type
            car[0] = "Mercedes";
            Console.WriteLine( car[0]);

            Console.WriteLine("----------Implementing delegate Covariance-----------");

        }
    }
}
