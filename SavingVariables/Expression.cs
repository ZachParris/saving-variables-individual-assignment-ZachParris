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
        public int term_1 { get; set; }
        public int term_2 { get; set; }
        public char _operator { get; set; }
        string regex_match = @"^([-]?\d+|[a-z]{1})\s*(\+|\-|\*|\%|\/|=)\s*([-]?\d+|[a-z]{1})$";
        public bool invalidEntry { get; set; }
        private Constants consts = new Constants();
        public bool storedConstant { get; set; }

        public void Parser(string input)
        {
            try
            {
                Match match = Regex.Match(input, regex_match);

                if (match.Success)
                {
                    // check to see if we are assigning a constant
                    if (char.Parse(match.Groups[2].Value) == '=')
                    {
                        char key = match.Groups[1].Value[0];
                        int val = int.Parse(match.Groups[3].Value);
                        consts.AddConstantsToDictionary(key, val);
                        storedConstant = true;
                    }
                    else
                    {
                        int _term1;
                        if (!int.TryParse(match.Groups[1].Value, out _term1))
                        {
                            string key = match.Groups[1].Value;
                            _term1 = consts.GetConstant(key[0]);
                        }
                        term_1 = _term1;

                        _operator = char.Parse(match.Groups[2].Value);

                        int _term2;
                        if (!int.TryParse(match.Groups[3].Value, out _term2))
                        {
                            string key = match.Groups[3].Value;
                            _term2 = consts.GetConstant(key[0]);
                        }
                        term_2 = _term2;
                    }
                }
                else
                {
                    throw new InvalidOperationException("Try a 2 term expression");
                }
            }
            catch (InvalidOperationException)
            {
                invalidEntry = true;
            }
        }

    }
}
