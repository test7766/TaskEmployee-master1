using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Navigation;
using WpfApp1.Crud;
using WpfApp1.Data;
using Formatting = Newtonsoft.Json.Formatting;
using MessageBox = System.Windows.Forms.MessageBox;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        MessageBoxResult resultMessageBox;
        private static int NextId = 3;
        ObservableCollection<Employee> employees = EmployeeSeed.LoadEmployees();
        public MainWindow()
        {
            InitializeComponent();
            EmployeesGrid.ItemsSource = employees;
        }

        private void MainAddButton_Click(object sender, RoutedEventArgs e)
        {

            AddEmployee addEmployeedialog = new AddEmployee();
            addEmployeedialog.ShowDialog();

            if (addEmployeedialog.DialogResult == true)
            {
                var data = addEmployeedialog.txtDate_of_birth.SelectedDate ?? DateTime.MinValue;
                Employee employeeee = new Employee
                {

                    Id = NextId++,
                    Name = addEmployeedialog.txtName.Text,
                    Adress = addEmployeedialog.txtAdres.Text,
                    DateOfBirth = addEmployeedialog.txtDate_of_birth.SelectedDate ?? DateTime.MinValue,
                    Phone = addEmployeedialog.txtPhone.Text,
                    Position = addEmployeedialog.txtPosition.Text,
                    Status = (addEmployeedialog.txtdate_of_dismissal.SelectedDate == DateTime.MinValue
                    || addEmployeedialog.txtdate_of_dismissal.SelectedDate == null) ? "Работает" : "Уволен",
                    Salary = (decimal)(string.IsNullOrEmpty(addEmployeedialog.txtSalary.Text) ? (decimal?)0 : Convert.ToDecimal(addEmployeedialog.txtSalary.Text)),
                    Date_of_employment = addEmployeedialog.txtdate_of_employment.SelectedDate ?? DateTime.MinValue,
                    Date_of_dismissal = addEmployeedialog.txtdate_of_dismissal.SelectedDate ?? DateTime.MinValue
                };
                resultMessageBox = (MessageBoxResult)MessageBox.Show("Вы уверены, что хотите Добавить нового сотрудника?", "Подтверждение",
                (MessageBoxButtons)MessageBoxButton.OKCancel);
                if (resultMessageBox == MessageBoxResult.OK)
                {
                    employees.Add(employeeee);
                    EmployeesGrid.ItemsSource = employees;
                    ClearInputFields();
                    MessageBox.Show("Новый сотрудник успешно добавлен!");
                }
                else if (resultMessageBox == MessageBoxResult.Cancel)
                {
                    MessageBox.Show("Вы нажали Cancel!");
                }

            }
            else
            {
                MessageBox.Show("Добавление сотрудника отменено.");
            }

            // Method to clear input fields
            void ClearInputFields()
            {
                // Clear the text in all input fields
                addEmployeedialog.txtName.Text = string.Empty;
                addEmployeedialog.txtAdres.Text = string.Empty;
                addEmployeedialog.txtDate_of_birth.SelectedDate = null;
                addEmployeedialog.txtPhone.Text = string.Empty;
                addEmployeedialog.txtPosition.Text = string.Empty;
                addEmployeedialog.txtSalary.Text = string.Empty;
                addEmployeedialog.txtdate_of_employment.SelectedDate = null;
                addEmployeedialog.txtdate_of_dismissal.SelectedDate = null;
            }

        }



        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee updateEmployeedialog = new AddEmployee();
            Employee employee = (Employee)EmployeesGrid.SelectedItem;
            if (EmployeesGrid.SelectedItem is Employee selectedEmployee)
            {

                updateEmployeedialog.txtName.Text = employee.Name.ToString();
                updateEmployeedialog.txtAdres.Text = employee.Adress.ToString();
                updateEmployeedialog.txtDate_of_birth.SelectedDate = employee.DateOfBirth;
                updateEmployeedialog.txtPhone.Text = employee.Phone.ToString();
                updateEmployeedialog.txtPosition.Text = employee.Position.ToString();
                updateEmployeedialog.txtSalary.Text = employee.Salary.ToString();
                updateEmployeedialog.txtdate_of_employment.SelectedDate = employee.Date_of_employment;
                updateEmployeedialog.txtdate_of_dismissal.SelectedDate = employee.Date_of_dismissal;
                updateEmployeedialog.ShowDialog();
            }

            if (updateEmployeedialog.DialogResult == true)
            {

                Employee findEmployee = employees.Where(x => x.Id == employee.Id).First();
                if (findEmployee != null)
                {
                    employees.Remove(findEmployee);
                }

                employee.Id = employee.Id;
                employee.Name = updateEmployeedialog.txtName.Text;
                employee.DateOfBirth = updateEmployeedialog.txtDate_of_birth.SelectedDate ?? DateTime.MinValue;
                employee.Phone = updateEmployeedialog.txtPhone.Text;
                employee.Position = updateEmployeedialog.txtPosition.Text;
                employee.Status = (updateEmployeedialog.txtdate_of_dismissal.SelectedDate == DateTime.MinValue
                     || updateEmployeedialog.txtdate_of_dismissal.SelectedDate == null) ? "Работает" : "Уволен";

                employee.Salary = (decimal)(string.IsNullOrEmpty(updateEmployeedialog.txtSalary.Text) ? (decimal?)0 : Convert.ToDecimal(updateEmployeedialog.txtSalary.Text));
                employee.Date_of_employment = updateEmployeedialog.txtdate_of_employment.SelectedDate ?? DateTime.MinValue;
                employee.Date_of_dismissal = updateEmployeedialog.txtdate_of_dismissal.SelectedDate ?? DateTime.MinValue;
                employees.Add(employee);
                EmployeesGrid.ItemsSource = employees;

            }
            else
            {
                MessageBox.Show("Обновления сотрудника отменено.");
            }

        }

        private void AllDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            employees.Clear();
            EmployeesGrid.ItemsSource = employees;
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            Search searchdiag = new Search();
            searchdiag.ShowDialog();

            if (searchdiag.DialogResult == true)
            {

                if (int.TryParse(searchdiag.txtSearchId.Text, out int searchId))
                {

                    Employee foundEmployee = employees.FirstOrDefault(emp => emp.Id == searchId);
                    var foundResultEmployee = new ObservableCollection<Employee> { foundEmployee };

                    if (foundEmployee != null)
                    {
                        EmployeesGrid.ItemsSource = null;
                        EmployeesGrid.ItemsSource = foundResultEmployee;
                    }
                    else
                    {
                        MessageBox.Show($"Employee with ID {searchId} not found.", "Not Found",
                            (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid ID format. Please enter a valid number.", "Invalid ID",
                        (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                }
            }
            else
            {
                EmployeesGrid.ItemsSource = employees.ToList();
                MessageBox.Show("Поиск сотрудника отменен.");
            }

        }

        private void FireButton_Click(object sender, RoutedEventArgs e)
        {

            FireDialog fireEmployeedialog = new FireDialog();
            Employee employee = (Employee)EmployeesGrid.SelectedItem;

            if (EmployeesGrid.SelectedItem is Employee selectedEmployee)
            {
                fireEmployeedialog.txtName.Text = selectedEmployee.Name;
                fireEmployeedialog.ShowDialog();
            }

            if (fireEmployeedialog.DialogResult == true)
            {

                employee.Date_of_dismissal = fireEmployeedialog.txtdate_of_dismissal.SelectedDate ?? DateTime.MinValue;
                employee.Status = (fireEmployeedialog.txtdate_of_dismissal.SelectedDate == DateTime.MinValue
                    || fireEmployeedialog.txtdate_of_dismissal.SelectedDate == null) ? "Работает" : "Уволен";

                EmployeesGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Увольнение сотрудника отмененно!!!");
            }

        }
        public NavigationService Navigation { get; set; }
        private void StatisticButton_Click(object sender, RoutedEventArgs e)
        {
            //   mainFrame.Source = new Uri("Page1.xaml", UriKind.Relative);

            StatisticDialog statisticDialog = new StatisticDialog();

            statisticDialog.txtCount.Content = employees.Count().ToString();
            statisticDialog.txtAvergeSalary.Content = employees.Where(x => x.Salary != null).Average(x => x.Salary);
            statisticDialog.txtMinSalary.Content = employees.Where(x => x.Salary != null).Min(x => x.Salary);
            statisticDialog.txtMaxSalary.Content = employees.Where(x => x.Salary != null).Max(x => x.Salary);
            statisticDialog.txtFire.Content = employees.Where(x => x.Status == "Уволен").Count();


            var employeeCountByNames = employees.OrderByDescending(x => x.Date_of_employment).FirstOrDefault();
            var employeeCountByNames2 = employees.Where(x => x.Status == "Уволен").Count();

            statisticDialog.ShowDialog();

        }
        /////////////////////Import to Json//////////////////////////
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultMessageBox = (MessageBoxResult)MessageBox.Show("Вы уверены, что хотите импортировать в файл?", "Подтверждение",
                (MessageBoxButtons)MessageBoxButton.OKCancel);
            if (resultMessageBox == MessageBoxResult.OK)
            {
                string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
                File.WriteAllText("employees.json", json);
                MessageBox.Show(@"Файл WpfApp1\WpfApp1\bin\Debug\employees.json  успешно импортирован и сохранен.");

            }
            else if (resultMessageBox == MessageBoxResult.Cancel)
            {
                MessageBox.Show("Импорт файла отменен");
            }



        }


        /////////////////////Export from Json//////////////////////////
        private void ExportButton_Click_(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json";
            openFileDialog.Title = "Выберите файл для экспорта";
            openFileDialog.ShowDialog();
            string jsonContentPath = openFileDialog.FileName;

            try
            {
                resultMessageBox = (MessageBoxResult)MessageBox.Show("Вы уверены, что хотите експортировать из файла?",
                    "Подтверждение",(MessageBoxButtons)MessageBoxButton.OKCancel);
                if (resultMessageBox == MessageBoxResult.OK)
                {
                    string jsonContent = File.ReadAllText(jsonContentPath);
                    List<Employee> employeesExportJson = JsonConvert.DeserializeObject<List<Employee>>(jsonContent);
                    EmployeesGrid.ItemsSource = employeesExportJson;
                    MessageBox.Show("Данные успешно экспортированы из JSON файла.");

                }
                else if (resultMessageBox == MessageBoxResult.Cancel)
                {
                    MessageBox.Show("Операция отменена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте данных: " + ex.Message);
            }

        }
    }







}
