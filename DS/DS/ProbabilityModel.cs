using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class ProbabilityModel
    {
        public string Select(int n, List<string> next_questions, string answer, List<List<string>> Graph)
        {
            string next = "";
            int x;
            int rnd_next;
            int Count = next_questions.Count();
            Random rnd = new Random();
            while (true)
            {
                if (n == 1)
                {
                    if (answer == "да" | answer == "Да" | answer == "ДА")
                    {
                        if (Count == 3)
                        {
                            rnd_next = rnd.Next(2);
                            if (rnd_next == 0)
                            {
                                next = next_questions[0];
                            }
                            else
                            {
                                next = next_questions[1];
                            }
                        }
                        else
                        {
                            x = Count - 2;
                            rnd_next = rnd.Next(0, x);
                            next = next_questions[rnd_next];
                        }
                    }
                    else
                    {
                        next = next_questions[Count - 1];
                    }
                    Graph = DeleteNumbers(next, Graph);
                    break;
                }
                if (n == 2)
                {
                    if (Count > 1)
                    {
                        x = Count - 2;
                        rnd_next = rnd.Next(0, x);
                        next = next_questions[rnd_next];
                    }
                    else
                    {
                        next = next_questions[Count - 1];
                    }
                    Graph = DeleteNumbers(next, Graph);
                    break;
                }

                if (n == 3)
                {
                    if (answer == "да" | answer == "Да" | answer == "ДА")
                    {
                        next = next_questions[0];
                    }
                    else
                    {
                        next = next_questions[1];
                    }
                    break;
                }
                if (n == 4)
                {
                    next = next_questions[0];
                    break;
                }
                if (n == 5)
                {
                    x = Count - 1;
                    rnd_next = rnd.Next(0, x);
                    next = next_questions[rnd_next];
                    Graph = DeleteNumbers(next, Graph);
                    break;
                }
                if (n == 6)
                {
                    if (answer == "да" | answer == "Да" | answer == "ДА")
                    {
                        next = next_questions[0];
                        break;
                    }
                    else
                    {
                        if (Count > 2)
                        {
                            x = Count - 2;
                            rnd_next = rnd.Next(1, x);
                            next = next_questions[rnd_next];
                        }
                        else
                        {
                            next = next_questions[Count - 1];
                        }
                        Graph = DeleteNumbers(next, Graph);
                    }
                    break;
                }

            }
            return next;
        }
        private List<List<string>> DeleteNumbers(string number, List<List<string>> Graph)
        {
            List<List<string>> gr = new List<List<string>>();
            for (int i = 0; i < Graph.Count(); i++)
            {
                Graph[i].Remove(number);
            }
            gr = Graph;
            return gr;
        }
    }
}
