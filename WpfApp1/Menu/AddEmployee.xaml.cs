using System;
using System.Linq;
using System.Windows;

namespace WpfApp1.Crud
{
 
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            this.DialogResult = true;
            // Close the window
            this.Close();

        }

        private void PhoneNumberTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string phoneNumber = txtPhone.Text;

            // Удалите все символы, кроме цифр
            string digitsOnly = new string(phoneNumber.Where(c => char.IsDigit(c)).ToArray());

            // Проверяем длину номера телефона
            if (digitsOnly.Length >= 10)
            {
                // Применяем маску: (000) 000-00-00
                txtPhone.Text = string.Format("({0}) {1}-{2}-{3}",
                    digitsOnly.Substring(0, 3),
                    digitsOnly.Substring(3, 3),
                    digitsOnly.Substring(6, 2),
                    digitsOnly.Substring(8));
            }
            else if (digitsOnly.Length >= 7)
            {
                // Применяем маску: (000) 000-00
                txtPhone.Text = string.Format("({0}) {1}-{2}",
                    digitsOnly.Substring(0, 3),
                    digitsOnly.Substring(3, 3),
                    digitsOnly.Substring(6));
            }
            else if (digitsOnly.Length >= 3)
            {
                // Применяем маску: (000) 000
                txtPhone.Text = string.Format("({0}) {1}",
                    digitsOnly.Substring(0, 3),
                    digitsOnly.Substring(3));
            }
            else
            {
                // Возвращаем введенные цифры без маски
                txtPhone.Text = digitsOnly;
            }

            // Перемещаем курсор в конец текста
            txtPhone.SelectionStart = txtPhone.Text.Length;
        }
    }
}
