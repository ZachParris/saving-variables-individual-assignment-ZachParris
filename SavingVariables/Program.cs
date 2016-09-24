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
            */
            bool programRun = true;
            Stack getLast = new Stack();
            Expression newExp = new Expression();

            while (programRun)
            {
                string prompt = ">>";
                Console.Write(prompt);
                string userInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(userInput))
                {
                    switch (userInput)
                    {
                        case "lastq":
                            Console.WriteLine(getLast.lastInput);
                            break;
                        case "quit":
                        case "exit":
                            programRun = false;
                            break;
                        default:
                            try
                            {
                                newExp.Parser(userInput);
                                getLast.lastInput = userInput;
                                Evaluation eval = new Evaluation();
                            }
                            catch
                            {

                            }
                           
                            break;
                    }
                }
            }
    } 
    }
}
 