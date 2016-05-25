using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class ProbabilityModel
    {

        List<int> NumbersForSelect;
        public ProbabilityModel(int n)
        {
            NumbersForSelect = new List<int>();
            for (int i = 0; i < n; i++)
            {
                NumbersForSelect.Add(i);
            }
        }

        public int Select()
        {
            int Output = 0;
            int i = 0;
            Random rnd = new Random();
            int x = NumbersForSelect.Count() - 1;
            if (x == 0)
            i = 0;
            else
            i = rnd.Next(0, x);

            Output = NumbersForSelect[i];
            if (NumbersForSelect.Count() > 1)
            {
                NumbersForSelect.RemoveAt(i);
            }
            else
            {
                NumbersForSelect = null;
            }
            return Output;
        }
    }
}
