using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace DS
{
    public class Model
    {
        public class Message
        {

            public int AnswersNUM = 0;
            public string QuestionNum;
            public string Question;
            public bool HasAnswers;
            public Answer[] answers;
            public string answer;
            public bool HasImage;
            public string Image;
            public bool HasExplain;
            public string Explain;


            public class Answer
            {
                public String Text;
                public bool IsTrue;
                public Answer(string _Text, bool _IsTrue)
                {
                    this.Text = _Text;
                    this.IsTrue = _IsTrue;
                }
            }

            public string[] GetAllAnswers()
            {
                string[] str = new string[answers.Length];
                for (int i = 0; i < answers.Length; i++)
                    str[i] = answers[i].Text;

                return str;
            }
            public Message(string _QuestionNum,
                            string _Question,
                            bool _HasExplain,
                            string _Explain,
                            bool _HasImage,
                            string _Image,
                            Answer[] _answers)
            {
                this.QuestionNum = _QuestionNum;
                this.Question = _Question;
                this.HasImage = _HasImage;
                this.Image = _Image;
                this.HasExplain = _HasExplain;
                this.Explain = _Explain;
                this.HasAnswers = true;
                this.answers = _answers;
            }
            public Message(string _QuestionNum,
                            string _Question,

                            bool _HasExplain,
                            string _Explain,
                            bool _HasImage,
                            string _Image,
                            string _answer)
            {
                this.QuestionNum = _QuestionNum;
                this.Question = _Question;
                this.HasImage = _HasImage;
                this.Image = _Image;
                this.HasExplain = _HasExplain;
                this.Explain = _Explain;
                this.HasAnswers = false;
                this.answer = _answer;
            }


            public static Message GetFirst(out int i)
            {
                i = 0;
                Memory.LoadFile(out i);

                return GetNext(i, 0);

            }

            public static Message GetNext(int FileNum, int skip)
            {
                    Message m = Memory.GetMessage(FileNum, skip);
                    //а что если первого нет?
                    return m;
            }

            public bool EOF(int i)
            {
                return Memory.EOF(i);
            }

        }

    }
}