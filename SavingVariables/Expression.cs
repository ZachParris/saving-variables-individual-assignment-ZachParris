using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SavingVariables
{
    public class Expression
    {
        public string variable { get; set; }
        public int number { get; set; }
        string regex_match = @"(\s*(?<Variable>[A-Za-z])\s*=\s*(?<Value>[-]?\d*)\s*)$";
        string regex_clearAll = @" ^ (?<Command> clear | remove | delete | show)\s*(?<target>all|[a-zA-Z])$";
        string regex_clearOne = @"(\s*(?<Command>(show))\s*(?<Variable>[A-Za-z])\s*)$";
        public bool invalidEntry { get; set; }
        private Constants consts = new Constants();

        public void Parser(string input)
        {
            try
            {
                Match match = Regex.Match(input, regex_match);

                if (match.Success)
                {
                    variable = match.Groups["Variable"].Value.ToLower();
                    number = Convert.ToInt32(match.Groups["Number"].Value);
                    consts.AddVariableToRepository(variable, number);
                }
                else
                {
                    throw new InvalidOperationException("Invalid Entry");
                }
            }
            catch (InvalidOperationException)
            {
                invalidEntry = true;
            }
        }

    }
}
