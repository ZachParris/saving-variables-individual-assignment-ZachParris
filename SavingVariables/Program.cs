using SavingVariables.DAL;
using SavingVariables.Models;
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
            Expression newExpression = new Expression();
            VariablesRepository repo = new VariablesRepository();
            EntryResponses response = new EntryResponses();
            bool runProgram = true;
            Console.WriteLine(response.initial_prompt);

            while (runProgram)
            {
                Console.Write(response.prompt);
                string userInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(userInput))
                {
                    switch (userInput)
                    {
                        case "clear all":
                        case "remove all":
                        case "delete all":
                            {
                                repo.RemoveAllVariables();
                                response.ClearEntireDatabase();
                                break;
                            }
                        case "show all":
                            {
                                var variablesToString = repo.GetVariables().VariableListToString();
                                var var_list = response.ShowAllExistingSavedVariables(variablesToString);
                                Console.WriteLine(var_list);
                                break;
                            }
                        case "lastq":
                            string last_input = stack.lastInput;
                            Console.WriteLine(" = " + last_input);
                            break;
                        case "quit":
                        case "exit":
                            runProgram = false;
                            break;
                        default:
                            {
                                newExpression.Parser(userInput);
                                stack.lastInput = userInput;
                                break;
                            }
                     }
                }
            }
            Console.ReadKey();
        }
    }
}
 