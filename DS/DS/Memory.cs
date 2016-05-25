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
using System.Windows.Forms;
namespace DS
{
    public class Memory
    {
        static List<StreamReader> sR = new List<StreamReader>();
        static List<StreamWriter> sW = new List<StreamWriter>();
        static List<string> Text = new List<string>();
        public static string Save(int i,
                                string _QuestionNum,
                                string _Question,
                                string _Image,
                                string _Explain,
                                string[] _answers,
                                string[] _IsTrue)
        {
            // файл должен выглядеть следующим образом (как CSV таблица)
            // Вопрос;Ответ1#переход1;Ответ2#переход2;Ответ3#переход3...
            // Вопрос;Ответ1#переход1;Ответ2#переход2;Ответ3#переход3...

            //Вообще структура имеет вид конечного детерменированного автомата без циклов


            //QuestionNum
            Text[i] += _QuestionNum;
            Text[i] += ';';
            //Question
            Text[i] += _Question;
            Text[i] += ';';
            //HasAnswers
            Text[i] += "true";
            Text[i] += ';';
            //Answers@IsTrue#
            for (int z = 0; z < _answers.Length - 1; z++)
            {
                if (z != 0)
                    Text[i] += '#';//Переход
                string a;
                if (Convert.ToString(_IsTrue) == "Да")
                {
                    a = "true";
                }
                else
                    a = "false";

                if (_answers[z].Length != 0 && a.Length != 0)
                {
                    Text[i] += _answers[z] + '@'; //Ответ
                    Text[i] += a;
                }
            }
            Text[i] += ';';
            //HasExplain
            if (_Explain.Length == 0)
                Text[i] += "false";
            else
                Text[i] += "true";
            Text[i] += ';';
            //Explain
            Text[i] += _Explain;
            Text[i] += ';';
            //HasImage
            if (_Image.Length != 0)
                Text[i] += "true";
            else
                Text[i] += "false";
            Text[i] += ';';
            //Image
            Text[i] += _Image;
            Text[i] += ';';
            Text[i] += '\n';
            //sW[i].WriteLine(Text[i]);
            return Text[i];
        }
        public static string Save(int i,
                        string _QuestionNum,
                        string _Question,
                        string _Image,
                        string _Explain,
                        string _answer)
        {
            // файл должен выглядеть следующим образом (как CSV таблица)
            // Вопрос;Ответ1#переход1;Ответ2#переход2;Ответ3#переход3...
            // Вопрос;Ответ1#переход1;Ответ2#переход2;Ответ3#переход3...

            //Вообще структура имеет вид конечного детерменированного автомата без циклов

            //QuestionNum
            Text[i] += _QuestionNum;
            Text[i] += ';';
            //Question
            Text[i] += _Question;
            Text[i] += ';';
            //HasAnswers
            Text[i] += "false";
            Text[i] += ';';
            //Answer
            Text[i] += _answer;
            Text[i] += ';';
            //HasExplain
            if (_Explain.Length == 0)
                Text[i] += "false";
            else
                Text[i] += "true";
            Text[i] += ';';
            //Explain
            Text[i] += _Explain;
            Text[i] += ';';
            //HasImage
            if (_Image.Length != 0)
                Text[i] += "true";
            else
                Text[i] += "false";
            Text[i] += ';';
            //Image
            Text[i] += _Image;
            Text[i] += ';';
            Text[i] += '\n';
            //sW[i].WriteLine(Text[i]);
            return Text[i];
        }
        public static string Save(int i, string _Text)
        {

            //QuestionNum
            Text[i] += _Text[i];

            //sW[i].WriteLine(Text[i]);
            return Text[i];
        }
        public static void SaveFile(int i)
        {

            try
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.Filter = "KUR|*.kur";
                SaveFileDialog1.Title = "Select a kur File";

                if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    sW.Add(new StreamWriter(SaveFileDialog1.FileName));

                    sW[i].WriteLine(Text[i]);
                    sW[i].Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }


            //sR[i] = new StreamReader(@"C:\Users\iampi\Documents\test1.kur");
        }
        public static void LoadFile(out int i)
        {
            i = sR.Count();
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "KUR|*.kur";
                openFileDialog1.Title = "Select a kur File";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    sR.Add(new StreamReader(openFileDialog1.FileName, Encoding.UTF8));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }

            //sR[i] = new StreamReader(@"C:\Users\iampi\OneDrive\Polikashin2016\ResuEgeParser\test2.kur");
            //sR[i] = new StreamReader(@"C:\Users\iampi\Documents\test.kur");
        }

        public static Model.Message GetMessage(int FileNum, int skip)
        {
            string[] str = null;
            Model.Message m = null;
            for (int i = 0; i < skip + 1; i++)
            {
                str = sR[FileNum].ReadLine().Split(';');//??
            }

            //      Варианты вопросов
            //  1. с вариантами без картинки
            //  2. без вариантов без картинки
            //  3. с вариантами с картинкой
            //  4. без вариантов с картинкой

            //Х; Вопрос1; true; Ответ1 @false; true; Пояснение; false; ;

            string QuestionNum = str[0];
            string Question = str[1];
            if (Convert.ToBoolean(str[2]))
            {
                string[] ALL = str[3].Split('#');
                string[] answers = new string[ALL.Length];
                string[] IsTrue = new string[ALL.Length];

                int k = 0;
                for (int i = 0; i < ALL.Length; i++)
                {
                    string[] a = ALL[i].Split('@');
                    answers[k] = a[0];
                    IsTrue[k] = a[1];
                    k++;
                }

                Model.Message.Answer[] ans = new Model.Message.Answer[k];
                for (int i = 0; i < k; i++)
                {
                    ans[i] = new Model.Message.Answer(answers[i], Convert.ToBoolean(IsTrue[i]));
                }
                return new Model.Message(str[0], str[1], Convert.ToBoolean(str[4]), str[5], Convert.ToBoolean(str[6]), str[7], ans);
            }
            else
            {
                return new Model.Message(str[0], str[1], Convert.ToBoolean(str[4]), str[5], Convert.ToBoolean(str[6]), str[7], str[3]);
            }
        }
        public static bool EOF(int i)
        {
            return sR[i].EndOfStream;
        }
    }
}

