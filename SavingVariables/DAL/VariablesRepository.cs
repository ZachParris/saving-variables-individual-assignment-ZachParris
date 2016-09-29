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

        internal bool VariableExists(string id)
        {
            Variable newVar = new Variable();
            if (FindVariableById(newVar.VariableId) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddVariable(Variable variable)
        {
            Context.Variables.Add(variable);
            Context.SaveChanges();
        }
        public virtual void AddVariableAndValue(string var, int val)
        {
            Variable variable = new Variable { VariableName = var.ToString(), Value = val };
            Context.Variables.Add(variable);
            Context.SaveChanges();
        }

        public void RemoveAllVariables()
        {
            List<Variable> variables = GetVariables();
            Context.Variables.RemoveRange(variables);
            Context.SaveChanges();
        }

        public Variable FindVariableById(int varId)
        {
            var context = Context.Variables;
            var list = context.ToList();
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

        public int GetVarValueByVarName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}