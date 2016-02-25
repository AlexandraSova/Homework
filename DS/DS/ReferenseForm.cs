using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS
{
    public partial class ReferenseForm : Form
    {
        public ReferenseForm()
        {
            InitializeComponent();
        }

        private void ReferenseForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Введите вопрос";
            label6.Text = "0) Close \n1) Да- выбор, нет- последний вопрос\n2) Выбор, пока Count>1, иначе выбор последнего вопроса\n3)	Да-1 вопрос, нет- 2 вопрос\n4) Переход на следующий вопрос\n5) Выбор\n6) Да- 1 вопрос, нет- выбор.\nВыбор- выбор вопроса согласно вероятности.";
            label8.Text = "Введите следующие вопросы через точку с запятой.";
            label9.Text = "Введите допустимые ответы через точку с запятой.\n%-любой ответ.";
            label11.Text = "Введите справку к вопросу (пояснение)";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
