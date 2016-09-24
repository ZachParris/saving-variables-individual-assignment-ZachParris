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
        public char variable { get; set; }
        public int number { get; set; }
        public char _operator { get; set; }
        string regex_match = @"(?<Variable>[a-zA-Z])\s=\s(?<Number>-?\d*)$";
        public bool invalidEntry { get; set; }
        private Constants consts = new Constants();

        public void Parser(string input)
        {
            try
            {
                Match match = Regex.Match(input, regex_match);

                if (match.Success)
                {
                    variable = Convert.ToChar(match.Groups["Variable"].Value.ToLower());
                    number = int.Parse(match.Groups["Number"].Value);
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
