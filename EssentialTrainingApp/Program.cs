using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;
        static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProb();
        }

     

        //Debug practice
        private static int CrazyMathProb()
        {
            var income = 1000;

            for (var i = 10; i > 0; i--)
            {
                income = income = (income / i);
            }
            return income;
        }
    }
}
