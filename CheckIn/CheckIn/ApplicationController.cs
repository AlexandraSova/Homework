using CheckIn.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckIn
{
    public class ApplicationController
    {
        public void Run<TPresenter>(TPresenter presenter)
        where TPresenter : class, IPresenter
        {
            presenter.Run();
        }

    }
}
