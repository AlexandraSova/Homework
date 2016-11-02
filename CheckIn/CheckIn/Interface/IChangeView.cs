using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn.Interface
{
    public interface IChangeView:IView
    {
        string fio { get; }
        string address { get; }
        string tel { get; }
        string policy { get; }
        string passport { get; }
        string diagnosis { get; }
        List<string> diagnosis_info { set; }
        event Action Ok;
    }
}
