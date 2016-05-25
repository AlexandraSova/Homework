using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class Dialog
    {
        public List<string> QuestionNum = new List<string>();
        public List<string> Question = new List<string>();
        public List<bool> HasImage = new List<bool>();
        public List<string> Image = new List<string>();
        public List<bool> HasExplain = new List<bool>();
        public List<string> Explain = new List<string>();
        public List<bool> HasAnswers = new List<bool>();
        public List<Model.Message.Answer[]> answers = new List<Model.Message.Answer[]>();
        public List<string> answer = new List<string>();

        public Model.Message ReturnOneQuestion(int i)
        {
            Model.Message Output = new Model.Message("", "", true, "", true, "", "");
            Output.QuestionNum = this.QuestionNum[i];
            Output.Question = this.Question[i];
            Output.HasImage = this.HasImage[i];
            Output.Image = this.Image[i];
            Output.HasExplain = this.HasExplain[i];
            Output.Explain = this.Explain[i];
            Output.HasAnswers = this.HasAnswers[i];
            Output.answers = this.answers[i];
            Output.answer = this.answer[i];

            return Output;
        }
    }
}
