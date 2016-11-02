using CheckIn.Interface;
using CheckIn.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckIn.CheckIn
{
    public class CheckInPresenter : IPresenter
    {
        private readonly ICheckInView _view;
        private CheckInAndLoginModel model;
        public CheckInPresenter(ICheckInView view)
        {
            _view = view;
            _view.CheckIn += () => CheckIn(_view.FirstName, _view.LastName, _view.Mail, _view.Pass1, _view.Pass2);
            _view.Login += () => Login(_view.FirstName, _view.LastName, _view.Mail, _view.Pass1, _view.Pass2);
            _view.WritePass2 += () => CheckPass(_view.Pass1, _view.Pass2);
        }

        public void Run()
        {
            _view.Show();
        }

        private void CheckIn(string firstname, string lastname, string mail, string pass1, string pass2)
        {
            model = new CheckInModel();
            string error;
            bool write = true;
            if (firstname != "" && lastname != "" && pass1 != "" && pass2 != "" && mail != "")
            {
                error = model.CheckFirstName(firstname);
                if (error!=null)
                {
                    write = false;
                    _view.ShowError(error);
                    _view.FirstName = "";
                }
                error = model.CheckLastName(lastname);
                if (error != null)
                {
                    write = false;
                    _view.ShowError(error);
                    _view.LastName = "";
                }
                error = model.CorrectMailFormat(mail);
                if (error != null)
                {
                    write = false;
                    _view.ShowError(error);
                    _view.Mail = "";
                }
                error = model.CheckPass(pass1, pass2);
                if (error != null)
                {
                    write = false;
                    _view.ShowError(error);
                    _view.Pass2 = "";
                }
                
                if (write)
                {
                    model.Write(firstname, lastname, pass1, mail);
                    ApplicationController controller = new ApplicationController();
                    controller.Run<PatientPresenter>(new PatientPresenter(new PatientForm()));
                    _view.Close();
                }
            }
            else
            {
                _view.ShowError("Пожалуйста, заполните все поля!");
            }
        }

        private void Login(string firstname, string lastname, string mail, string pass1, string pass2)
    {
        model = new LoginModel();
       
        string error;
        bool b = true;
        if (firstname != "" && lastname != "" && pass1 != "" && pass2 != "" && mail != "")
        {
            error = model.CorrectMail(mail);
            if (error != null)
            {
                b = false;
                _view.ShowError(error);
                _view.FirstName = "";
                _view.LastName = "";
                _view.Mail = "";
                _view.Pass1 = "";
                _view.Pass2 = "";
            }
            else
            {
                error = model.CheckFirstName(firstname);
                if (error != null)
                {
                    b = false;
                    _view.ShowError(error);
                    _view.FirstName = "";
                }
                error = model.CheckLastName(lastname);
                if (error != null)
                {
                    b = false;
                    _view.ShowError(error);
                    _view.LastName = "";
                }

                error = model.CheckPass(pass1, pass2);
                if (error != null)
                {
                    b = false;
                    _view.ShowError(error);
                    _view.Pass2 = "";
                }
            }
            if (b)
            {
                ApplicationController controller = new ApplicationController();
                controller.Run<PatientPresenter>(new PatientPresenter(new PatientForm()));
                _view.Close();
            }
        }
        else
        {
            _view.ShowError("Пожалуйста, заполните все поля!");
        }
    }

        private void CheckPass(string pass1, string pass2)
        {
            model = new CheckInAndLoginModel();
            string error = model.CheckPass(pass1, pass2);
            if (error != null)
            {
                _view.ShowPassMessage(error);
            }
            else
            {
                _view.ShowPassMessage("");
            }
        }
    }
}
