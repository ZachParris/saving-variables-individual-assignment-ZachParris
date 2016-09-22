using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables
{
    public class Evaluation
    {
        public int answer { get; set; }
        public void Evaluator(int first, int second, char operand)
        {
            switch (operand)
            {
                case '+':
                    answer = first + second;
                    break;
                case '-':
                    answer = first - second;
                    break;
                case '*':
                    answer = first * second;
                    break;
                case '/':
                    answer = first / second;
                    break;
                case '%':
                    answer = first % second;
                    break;
                default:
                    Console.WriteLine("Try Again!");
                    break;

            }
        }

      
    }
}
