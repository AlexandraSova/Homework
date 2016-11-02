using CheckIn.Interface;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn.Patient
{
    public class PatientPresenter : IPresenter
    {
        private readonly IPatientView _patient_view;
        private ChangeForm _change_view;

        private PatientModel model = new PatientModel();

        public PatientPresenter(IPatientView view)
        {
            _patient_view = view;
            _patient_view.ShowPatients += () => ShowPatients(_patient_view.selected_diagnosis);
            _patient_view.Add += () => ShowAdd();
            _patient_view.Change += () => ShowChange();
            _patient_view.Delete += () => Delete(_patient_view.passport);
        }
        public void Run()
        {
            _patient_view.table_info = model.GetPatientTable();
            _patient_view.diagnosis_info = model.GetDiagnosisInfo();
            _patient_view.Show();
        }
        private void ShowPatients(string diagnosis)
        {
            Table table = model.SelectedPatients(diagnosis);
            if (table != null)
            {
                _patient_view.ShowTable(table);
            }
            else _patient_view.ShowError("Пациентов с таким диагнозом нет!");
        }
        private void ShowAdd()
        {
                _change_view = new ChangeForm();
                _change_view.diagnosis_info = model.GetDiagnosisInfo();
                _change_view.Ok += () => AddPatient(_change_view.fio, _change_view.address, _change_view.tel, _change_view.policy, _change_view.passport, _change_view.diagnosis);
                _change_view.ShowDialog();
        }
        private void ShowChange()
        {
            if (_patient_view.selected_row)
            {
                _change_view = new ChangeForm();
                _change_view.diagnosis_info = model.GetDiagnosisInfo();
                _change_view.fio = _patient_view.fio;
                _change_view.address = _patient_view.address;
                _change_view.tel = _patient_view.tel;
                _change_view.policy = _patient_view.policy;
                _change_view.passport = _patient_view.passport;
                _change_view.diagnosis = _patient_view.diagnosis;
                _change_view.Ok += () => ChangePatient(_change_view.fio, _change_view.address, _change_view.tel, _change_view.policy, _change_view.passport, _change_view.diagnosis);
                _change_view.ShowDialog();
            }
            else
            {
                _patient_view.ShowError("Выберете строку!");
            }
        }

        private void AddPatient(string fio, string address, string tel, string policy, string passport, string diagnosis)
        {
            string error = model.AddPatient(fio, address, tel, policy, passport, diagnosis);     
            if (error == null)
            {
                _change_view.Close();
                Table table = model.GetPatientTable();
                _patient_view.ShowTable(table);
            }
            else
            {
                _patient_view.ShowError(error);
            }
        }
        private void ChangePatient(string fio, string address, string tel, string policy, string passport, string diagnosis)
        {
            string error = model.ChangePatient(fio, address, tel, policy, passport, diagnosis);
            if (error == null)
            {
                _change_view.Close();
                Table table = model.GetPatientTable();
                _patient_view.ShowTable(table);
            }
            else
            {
                _patient_view.ShowError(error);
            }
        }

        private void Delete(string key)
        {
            if (_patient_view.selected_row)
            {
                string error = model.DeletePatient(key);
                if (error == null)
                {
                    Table table = model.GetPatientTable();
                    _patient_view.ShowTable(table);
                }
                else
                {
                    _patient_view.ShowError(error);
                }
            }

            else
            {
                _patient_view.ShowError("Выберете строку!");
            }
        }
    }
}
