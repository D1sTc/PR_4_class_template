using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_4
{

    public partial class Form1 : Form
    {
        // Использую список для хранения данных о каждом варианте в ComboBoxNumber
        private List<Group<string, int, string, int>> groups = new List<Group<string, int, string, int>>();

        class Group<T1, T2, T3, T4>
        {
            public T1 val1 {get; set;}
            public T2 val2 {get; set;}
            public T3 val3 {get; set;}
            public T4 val4 {get; set;}

            public Group(T1 val1, T2 val2, T3 val3, T4 val4)
            {
                this.val1 = val1;
                this.val2 = val2;
                this.val3 = val3;
                this.val4 = val4;
            }

            public string GetValueAsString(int index)
            {
                switch (index)
                {
                    case 1: return val1.ToString();
                    case 2: return val2.ToString();
                    case 3: return val3.ToString();
                    case 4: return val4.ToString();
                    default: return "";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Добавляем данные в ComboBox
            comboBoxNaumber.Items.AddRange(new string[] {"1", "2"});

            // Добавляем пару заявок
            groups.Add(new Group<string, int, string, int>("Апатиты", 23, "Миронов А.Б.", 2020));
            groups.Add(new Group<string, int, string, int>("Кировск", 24, "Кировский М.П.", 2021));
        }

        private void comboBoxNaumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранный индекс
            int selectedIndex = comboBoxNaumber.SelectedIndex;

            // Обновляем TextBox
            UpdateTextBoxes(selectedIndex);
        }

        private void UpdateTextBoxes(int selectedIndex)
        {
            if (selectedIndex >= 0 && selectedIndex < groups.Count)
            {
                // Получаем данные из выбранного варианта в списке
                Group<string, int, string, int> selectedGroup = groups[selectedIndex];

                // Устанавливаем значения в TextBox
                textDestination.Text = selectedGroup.val1;
                textFlightNumber.Text = selectedGroup.val2.ToString();
                textFIO.Text = selectedGroup.val3;
                textDepartureDate.Text = selectedGroup.val4.ToString();
            }
        }

        private void textDestination_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, содержит ли текст цифры
            bool error = false;
            foreach (char c in textDestination.Text)
            {
                if (char.IsDigit(c))
                {
                    error = true;
                    break;
                }
            }

            // Устанавливаем или скрываем ErrorProvider
            if (error) errorProvider.SetError(textDestination, "Ошибка: номер рейса не может содержать текст");
            else errorProvider.Clear();
        }

        private void textFlightNumber_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, содержит ли текст string
            bool hasText = false;
            foreach (char c in textFlightNumber.Text)
            {
                if (char.IsLetter(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c)) // Проверяем на буквы, пунктуацию и пробелы
                {
                    hasText = true;
                    break;
                }
            }

            // Устанавливаем или скрываем ErrorProvider
            if (hasText) errorProvider.SetError(textFlightNumber, "Ошибка: Текст не должен содержать текст.");
            else errorProvider.Clear();
        }

        private void textFIO_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, содержит ли текст цифры
            bool error = false;
            foreach (char c in textFIO.Text)
            {
                if (char.IsDigit(c))
                {
                    error = true;
                    break;
                }
            }

            // Устанавливаем или скрываем ErrorProvider
            if (error) errorProvider.SetError(textFIO, "Ошибка: ФИО не может содержать цифры");
            else errorProvider.Clear();
        }

        private void textDepartureDate_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, содержит ли текст string
            bool hasText = false;
            foreach (char c in textDepartureDate.Text)
            {
                if (char.IsLetter(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c)) // Проверяем на буквы, пунктуацию и пробелы
                {
                    hasText = true;
                    break;
                }
            }

            // Устанавливаем или скрываем ErrorProvider
            if (hasText) errorProvider.SetError(textDepartureDate, "Ошибка: Дата не должна содержать текст.");
            else errorProvider.Clear();
        }

        private void ButtonAddaRequestToList_Click(object sender, EventArgs e)
        {

            // Проверка на пустые TextBox
            if (string.IsNullOrEmpty(textDestination.Text) ||
                string.IsNullOrEmpty(textFlightNumber.Text) ||
                string.IsNullOrEmpty(textFIO.Text) ||
                string.IsNullOrEmpty(textDepartureDate.Text))
            {
                MessageBox.Show("Ошибка: Не все поля заполнены!");
                return; // Выход из метода, если есть пустые поля
            }
            // Получаем данные из TextBox
            string val1 = textDestination.Text;
            int val2 = int.Parse(textFlightNumber.Text);
            string val3 = textFIO.Text;
            int val4 = int.Parse(textDepartureDate.Text);

            // Создаем новый объект Group
            Group<string, int, string, int> newGroup = new Group<string, int, string, int>(val1, val2, val3, val4);

            // Добавляем новый объект в список
            groups.Add(newGroup);

            // Обновляем ComboBox
            comboBoxNaumber.Items.Add(groups.Count.ToString());

                // Устанавливаем текст по умолчанию в TextBox
                UpdateTextBoxes(groups.Count - 1);
        }

            private void ButtonDeleteaRequestFromList_Click(object sender, EventArgs e)
        {
            if (comboBoxNaumber.SelectedItem != null)
            {
                string name = comboBoxNaumber.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Вы не выбрали группу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDestination.Clear();
                textFlightNumber.Clear();
                textFIO.Clear();
                textDepartureDate.Clear();
            }
        }

        private void ButtonWithdrawRequest_Click(object sender, EventArgs e)
        {
            // Выводит
            if (groups.Count > 0)
            {
                Group<string, int, string, int> group = groups[Convert.ToInt32(NumberAct.Text) - 1]; // определение заявки от groups

                string message = $"Пункт назначения: {group.val1}\n" +
                               $"Номер рейса: {group.val2}\n" +
                               $"ФИО пассажира: {group.val3}\n" +
                               $"Дата вылета: {group.val4}";

                MessageBox.Show(message, "Заявка");
            }
            else
            {
                MessageBox.Show("Заявка не найдена", "Ошибка");
            }
        }

        private void ButtonWithdrawAllRequests_Click(object sender, EventArgs e)
        {
        
        }

        private void ButtonWithdrawList_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textDestination.Clear();
            textFlightNumber.Clear();
            textFIO.Clear();
            textDepartureDate.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NumberAct_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, содержит ли текст string
            bool hasText = false;
            foreach (char c in NumberAct.Text)
            {
                if (char.IsLetter(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c)) // Проверяем на буквы, пунктуацию и пробелы
                {
                    hasText = true;
                    break;
                }
            }

            // Устанавливаем или скрываем ErrorProvider
            if (hasText) errorProvider.SetError(NumberAct, "Ошибка: Номер не может содержать буквы");
            else errorProvider.Clear();
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {

        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplicationAddRequest_Click(object sender, EventArgs e)
        {
            ButtonAddaRequestToList_Click(sender, e);
        }

        private void ApplicationDeleteApplication_Click(object sender, EventArgs e)
        {
            ButtonDeleteaRequestFromList_Click(sender, e);
        }

        private void ApplicationWithdrawApplication_Click(object sender, EventArgs e)
        {
            ButtonWithdrawRequest_Click(sender, e);
        }

        private void ApplicationWithdrawAllApplication_Click(object sender, EventArgs e)
        {
            ButtonWithdrawAllRequests_Click(sender, e);
        }

        private void ApplicationDisplaysaList_Click(object sender, EventArgs e)
        {
            ButtonWithdrawList_Click(sender, e);
        }
    }
}
