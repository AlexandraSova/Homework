using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class ControllerForEditForm : ControllerForCreateForm
    {
        public Dialog GetDialog
        {
            get
            {
                return Dialog;
            }
        }
        public void ClearScenario()
        {
            Dialog.Questions.Clear();
            Dialog.CorrectAnswersForWrite.Clear();
            Dialog.Referense.Clear();
            Dialog.type_trans.Clear();
            Dialog.GraphForWrite.Clear();
        }
    }
}
