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
            for(int i=0;i<n;i++)
            {
                NumbersForSelect.Add(i);
            }
        }

        public int Select()
        {
            int Output = 0;
            Random rnd = new Random();
            Output = rnd.Next(0, NumbersForSelect.Count() - 1);
            Output = NumbersForSelect[Output];
            if (NumbersForSelect.Count() > 1)
            {
                NumbersForSelect.RemoveAt(Output);
            }
            else
            {
                NumbersForSelect = null;
            }
            return Output;
        }
    }
}
