using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class ProgrammingLoops
    {
        public string BreakAndContinue()
        {
            var sb = new StringBuilder();
            var words = new List<string>() { "Bread", "Milk", "Cheese", "Apples" };

            foreach(var wor in words)
            {
                // will ignore words beginning with M and continue loop
                if (wor.StartsWith("M")) continue;

                // if word starts with C, loop will be exited
                if (wor.StartsWith("C")) break;

                sb.AppendLine(wor);
            }
            return sb.ToString();
        }

        public int DoWhileLoop()
        {
            var sum = 0;
            var counter = 0;

            do
            {
                sum += counter;
                counter++;
            }
            while (counter < 100);
            return sum;
        }

        public int WhileLoop()
        {
            var sum = 0;
            var counter = 0;

            while(counter < 100)
            {
                sum += counter;
                counter++;
            }
            return sum;
        }

        public int ForEachLoop()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 9 };
            var sum = 0;

            foreach(var num in numbers)
            {
                sum = sum + num;
                // or sum += num
            }
            return sum;
        }

        public int ForLoop()
        {
            int i;
            var sum = 0;
            for(i = 0; i < 100; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
