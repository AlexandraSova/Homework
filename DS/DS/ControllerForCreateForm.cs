using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class ControllerForCreateForm:Controller
    {
         public bool CreateNewScenario(string Name)
        {
            bool b = Provider.CreateNewScenarioFiles(Name);
            return b;
        }

        public void WriteScenario(string Name, List<string> Questions, List<string> Referense, List<string> CorrectAnswersForWrite, List<string> GraphForWrite, List<int> type_trans)
        {
            Provider.WriteDialog(Name, Questions, Referense, CorrectAnswersForWrite, GraphForWrite, type_trans);
        }
    }
}
