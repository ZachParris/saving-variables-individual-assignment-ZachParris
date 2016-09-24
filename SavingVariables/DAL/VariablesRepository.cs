using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.DAL
{
    public class VariablesRepository
    {
        public VariablesContext Context { get; set; }

        public VariablesRepository()
        {
            Context = new VariablesContext();
        }

        public VariablesRepository(VariablesContext _context)
        {
            Context = _context;
        }

        public List<Variable> GetVariables()
        {
            return Context.Variables.ToList();
        }

        internal bool VariableExists(char id)
        {
            throw new NotImplementedException();
        }

        public void AddVariable(Variable variable)
        {
            Context.Variables.Add(variable);
            Context.SaveChanges();
        }
        public void AddVariableAndValue(char var, int val)
        {
            Variable variable = new Variable { VariableName = var, Value = val };
            Context.Variables.Add(variable);
            Context.SaveChanges();
        }
        public Variable FindVariableById(int varId)
        {
           /* Author found_author = Context.Authors.FirstOrDefault(a => a.PenName.ToLower() == pen_name.ToLower());
            +            return found_author;*/

            List<Variable> found_variable = Context.Variables.ToList();
            foreach (var variable in found_variable)
            {
                if(variable.VariableId == varId)
                {
                    return variable;
                }
            }
            return null;
        }

        internal void RemoveVariable()
        {
            RemoveVariable();
        }

        public Variable RemoveVariable(int varId)
        {
            Variable found_variable = FindVariableById(varId);
            if (found_variable != null)
            {
                Context.Variables.Remove(found_variable);
                Context.SaveChanges();
            }
            return found_variable;
        }
        public int GetVarValueByVarName(char Name)
        {
            throw new NotImplementedException();
        }
    }
}