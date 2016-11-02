using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn.Interface
{
    public interface IPatientView:IView
    {
        Table table_info { set; }//таблица для отображения
        List<string> diagnosis_info { set; }// список диагнозов для комбобокс

        string fio { get; }
        string address { get; }
        string tel { get; }
        string policy { get; }
        string passport { get; }
        string diagnosis { get; }
        string selected_diagnosis { get; }
        bool selected_row { get; }
        void ShowTable(Table table);
        void ShowError(string error);

        event Action ShowPatients;
        event Action Add;
        event Action Change;
        event Action Delete;
    }
}
