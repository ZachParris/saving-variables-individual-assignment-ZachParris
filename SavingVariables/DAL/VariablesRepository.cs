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
            return Context.VariablesDB.ToList();
        }

        internal bool VariableExists(string id)
        {
            throw new NotImplementedException();
        }

        public void AddVariable(Variable variable)
        {
            Context.VariablesDB.Add(variable);
            Context.SaveChanges();
        }
        public void AddVariableAndValue(string var, int val)
        {
            Variable variable = new Variable { VariableName = var.ToString(), Value = val };
            Context.VariablesDB.Add(variable);
            Context.SaveChanges();
        }

        public void RemoveAllVariables()
        {
            List<Variable> variables = GetVariables();
            Context.VariablesDB.RemoveRange(variables);
        }

        public Variable FindVariableById(int varId)
        {
            List<Variable> found_variable = Context.VariablesDB.ToList();
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
                Context.VariablesDB.Remove(found_variable);
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