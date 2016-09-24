using SavingVariables.DAL;
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
            Stack stack = new Stack();
            Expression newVariable = new Expression();
            VariablesRepository repo = new VariablesRepository();
            EntryResponses response = new EntryResponses();
            bool runProgram = true;


            while (runProgram)
            {
                string prompt = ">>";
                Console.Write(prompt);
                string userInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(userInput))
                {
                    switch (userInput)
                    {
                        case "clear all":
                        case "remove all":
                        case "delete all":
                            {
                                repo.RemoveVariable();
                                response.ClearEntireDatabase();
                                break;
                            }
                        case "show all":
                            {
                                repo.Context.Variables.ToString();
                                response.ShowAllExistingSavedVariables();
                                break;
                            }
                        case "lastq":
                            Console.WriteLine(stack.lastInput);
                            break;
                        case "quit":
                        case "exit":
                            runProgram = false;
                            break;
                        default:
                            try
                            {
                                newVariable.Parser(userInput);
                                stack.lastInput = userInput;
                                Evaluation evaluation = new Evaluation();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                     }
                }
            }
         }
    }
}
 