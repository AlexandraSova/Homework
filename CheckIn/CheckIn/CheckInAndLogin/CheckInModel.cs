
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn.CheckIn
{
    public class CheckInModel: CheckInAndLoginModel
    {
        public override string CheckPass(string pass1, string pass2)
        {
            if (pass1 != pass2)
            {
                return "Пароли не совпадают!";
            }
            else return null;
        }
        public override string CheckFirstName(string name)
        {
            string result = null;

            foreach (char c in name.ToArray())
                if (!Char.IsLetter(c))
                {
                    result = "Имя должно состоять только из букв!";
                }
            return result;
        }
        public override string CheckLastName(string name)
        {
            string result = null;

            foreach (char c in name.ToArray())
                if (!Char.IsLetter(c))
                {
                    result = "Фамилия должна состоять только из букв!";
                }
            return result;
        }
    }
}
