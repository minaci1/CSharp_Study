using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{

    internal class Program
    {
        static void Main(string[] args) {

            int K = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < K; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(number);
                }
            }

            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine(sum);
        }
    }
}
