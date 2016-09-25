using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.Models
{
    public class Variable
    {
        [Key]
        public int VariableId { get; set; }

        [Required]
        public string VariableName { get; set; }

        [Required]
        public int Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0} = {1}", VariableName, Value);
        }
    }

    public static class VariableExtentions
    {
        public static string VariableListToString(this List<Variable> variable)
        {
            var my_variables = variable.Select(v => v.ToString());
            return String.Join(System.Environment.NewLine, my_variables);
        }
    }
}
