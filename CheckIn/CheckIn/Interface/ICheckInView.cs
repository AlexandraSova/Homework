using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn.Interface
{
    public interface ICheckInView : IView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Mail { get; set; }
        string Pass1 { get; set; }
        string Pass2 { get; set; }

        event Action CheckIn;      // событие "пользователь пытается зарегистрироваться"
        event Action WritePass2; //событие "пользователь вводит повторный пароль"
        event Action Login;//событие "пользователь пытается войти"
        void ShowError(string errorMessage);
        void ShowPassMessage(string errorMessage);
    }
}
