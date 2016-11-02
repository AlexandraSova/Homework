using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn.CheckIn
{
    public class LoginModel:CheckInAndLoginModel
    {
        public override string CheckPass(string pass1, string pass2)
        {
            string result = null;
            if (!provider.CorrectPass(pass1, ClientKey))
                result = "Неверный пароль или e-mail!";
            return result;
        }
        public override string CheckFirstName(string name)
        {
            string result = null;
            if (!provider.CorrectFirstName(name, ClientKey))
                result = "Неверное имя!";
            return result;
        }
        public override string CheckLastName(string name)
        {
            string result = null;
            if (!provider.CorrectLastName(name, ClientKey))
                result = "Неверная фамилия!";
            return result;
        }
    }
}
