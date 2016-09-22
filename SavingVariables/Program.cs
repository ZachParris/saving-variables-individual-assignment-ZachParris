using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Your Program class and Main method should only be responsible for 
            receiving user input and printing output.
            If a user submits an incomplete command or expression, 
            the application should not attempt to evaluate it but print out a useful message.
            Put everything in a UserInterface.cs*/
            int counter = 0;
            bool calculatorOn = true;
            Stack getLast = new Stack();
            Expression newExp = new Expression();

            while (calculatorOn)
            {
                string prompt = "[" + counter + "]>";
                Console.Write(prompt);
                string userInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(userInput))
                {
                    switch (userInput)
                    {
                        case "lastq":
                            Console.WriteLine(getLast.lastInput);
                            break;
                        case "last":
                            Console.WriteLine(getLast.lastResult);
                            break;
                        case "quit":
                            calculatorOn = false;
                            break;
                        case "exit":
                            calculatorOn = false;
                            break;
                        default:
                            try
                            {
                                newExp.Parser(userInput);
                                getLast.lastInput = userInput;
                                Evaluation eval = new Evaluation();

                                if (newExp.storedConstant == true)
                                {
                                    Console.WriteLine("Stored Constant");
                                }
                                else
                                {
                                    eval.Evaluator(newExp.term_1, newExp.term_2, newExp._operator);
                                    Console.WriteLine("=" + eval.answer);
                                    getLast.lastResult = eval.answer;


                                }
                                newExp.storedConstant = false;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                    }
                    counter++;
                }
            }
    }
    }
}
 