using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn.Patient
{
    class PatientModel
    {
        Provider provider = new Provider();
        Table patient = new Table();
        Table diagnosis = new Table();

        public PatientModel()
        {
            patient = provider.GetPatient();
            diagnosis = provider.GetDiagnosis();
        }
        public Table GetPatientTable()
        {
            Table table = new Table();
            List<string> column_name = new List<string>() { "ФИО", "Адрес", "Телефон", "Полис", "Паспорт", "Диагноз" };

            for (int i = 0; i < patient.ColumnCount()-1;i++ )
            {
                Table.Column column = patient.GetColumn(i);
                column.Name = column_name[i];
                table.AddColumn(column);
            }
            Table.Column diagnosis_column = patient.GetColumn(patient.ColumnCount() - 1);
            List<string> diagnosis_value = new List<string>();
            for (int i = 0; i < diagnosis_column.Count();i++ )
            {
                string number = diagnosis_column.Value[i];
                diagnosis_value.Add(GetDiagnosis(diagnosis, number));
            }
            diagnosis_column = new Table.Column(column_name.Last(), diagnosis_value);
            table.AddColumn(diagnosis_column);
                return table;
        }
        public List<string> GetDiagnosisInfo()
        {
            List<string> result = new List<string>();
            Table.Column column = diagnosis.GetColumn(0);
            for (int i = 0; i < column.Count();i++ )
            {
                result.Add(column.Value[i]);
            }
                return result;
        }
        private string GetDiagnosis(Table diagnosis, string number)
        {
            Table.Column diagnosis_number = diagnosis.GetColumn(1);
            Table.Column diagnosis_name = diagnosis.GetColumn(0);
            string result = "";

            for (int i=0;i<diagnosis_number.Count();i++)
            {
                if (diagnosis_number.Value[i] == number)
                {
                    result = diagnosis_name.Value[i];
                }
            }
            return result;
        }
        public Table SelectedPatients(string diagnosis)
        {
            Table table = new Table();
            Table.Column diagnosis_column = patient.GetColumn(patient.ColumnCount() - 1);
            for (int i = 0; i < diagnosis_column.Count();i++)
            {
                Table.Row row = patient.GetRow(i);
                if (GetDiagnosisName(row.value[patient.ColumnCount()-1]) == diagnosis)
                {
                    table.AddRow(row);
                }
            }
            if(table.RowCount()!=0)
            {
            patient = table;
            table = GetPatientTable();
            patient = provider.GetPatient();
            }
            else
            {
                table=null;
            }
            return table;
        }
        private string GetDiagnosisName(string id)
        {
            string result="";
            Table.Column column = diagnosis.GetColumn(0);
            for (int i=0;i< column.Count();i++)
            {
                Table.Row row = diagnosis.GetRow(i);
                if (id==row.value[1])
                {
                    result = row.value[0];
                }
            }
            return result;
        }
        private string  GetDiagnosisId(string name)
        {
            string result = "";
            Table.Column column = diagnosis.GetColumn(0);
            for (int i = 0; i < column.Count(); i++)
            {
                Table.Row row = diagnosis.GetRow(i);
                if (name == row.value[0])
                {
                    result = row.value[1];
                }
            }
            return result;
        }

        public string AddPatient(string fio, string address, string tel, string policy, string passport, string diagnosis)
        {
            if (policy.Count()!=16)
            {
                return "Номер полиса должен содержать 16 цифр!";
            }
            else
            {
                provider.AddPatient(fio, address, tel, policy, passport, GetDiagnosisId(diagnosis));
                patient = provider.GetPatient();
                return null;
            }
        }
        public string ChangePatient(string fio, string address, string tel, string policy, string passport, string diagnosis)
        {
            if (policy.Count() != 16)
            {
                return "Номер полиса должен содержать 16 цифр!";
            }
            else
            {
                provider.ChangePatient(fio, address, tel, policy, passport, GetDiagnosisId(diagnosis));
                patient = provider.GetPatient();
                return null;
            }
        }
        public string DeletePatient(string key)
        {
           if(provider.DeletePatient(key))
           {
               patient = provider.GetPatient();
               return null;
           }
           else
           {
               return "Не удалось удалить пациента!";
           }
        }
    }
}
