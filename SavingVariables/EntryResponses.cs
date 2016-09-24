using SavingVariables.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables
{
    public class EntryResponses
    {
        VariablesRepository repo = new VariablesRepository();

        public string AddNewVariableToDB(string var, int val)
        {
            return string.Format(" ='{0}' saved as '{1}'", var, val);
        }

        public string ShowRequstedVariablesCurrentValue(int val)
        {
            return string.Format(" ='{0}'", val);
        }

        public string AlreadyStoredVarException(string var)
        {
            return string.Format(" = Error! '{0}' is already defined!", var);
        }

        public string ClearValueOfVariable(string var)
        {
            return string.Format(" = '{0}' is now free!", var);
        }

        public string ClearEntireDatabase()
        {
            return string.Format(" = deleted all items from database!");
        }

        public string ShowAllExistingSavedVariables()
        {
            return string.Format("Name -> Value");
            /*repo.Context.Variables.ToString();*/
        }

        public string DatabaseIsEmptyResponse()
        {
            return string.Format(" = Database empty! Nothing to show.");
        }
    }
}
