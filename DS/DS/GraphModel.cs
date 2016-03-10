using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    class GraphModel
    {
        public string Select(int n, List<string> next_questions, string answer, FilesProvider Provider)
        {
            string next = "";
            int x;
            int rnd_next;
            int Count = next_questions.Count();
            Random rnd = new Random();
            while (true)
            {
                if (n == 3 || n == 1 || n == 2 || n == 5 || n == 6)
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
            }
            return next;
        }
    }
}
