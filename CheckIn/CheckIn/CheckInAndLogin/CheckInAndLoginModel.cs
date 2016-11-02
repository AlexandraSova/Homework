using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn.CheckIn
{
   public class CheckInAndLoginModel
    {
        protected Provider provider = new Provider();
        protected string ClientKey = "";//id
        public void Write(string firstname, string last_name, string pass, string mail)
        {
            provider.WriteClient(firstname, last_name, pass, mail);
        }
        public string CorrectMailFormat(string mail)
        {
            if (mail.ToArray().Contains('@'))
            {
                return null;
            }
            else return "Почта указана неверно!";
        }
        public string CorrectMail(string mail)
        {
            string result = null;
            if (!provider.HaveMail(mail))
            {
                result = "Пользователь с таким e-mail не зарегистрирован!";
            }
            else
            {
                ClientKey = mail;
            }
            return result;
        }

        public virtual string CheckPass(string pass1, string pass2)
        {
            return null;
        }
        public virtual string CheckFirstName(string name)
        {
            return null;
        }
        public virtual string CheckLastName(string name)
        {
            return null;
        }
    }
}
