using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //1(тема 1). Создать класс Employee:



    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Employee[] emps = new Employee[10];
        
        int count = 0;

        private void button_add_employee_Click(object sender, RoutedEventArgs e)
        {

            if (textBox_name.Text == "")
            {
                textBox_name.Text = "Введите ФИО";
            }
            else if (textBox_salary.Text == "")
            {
                emps[count] = new Employee(textBox_name.Text);
                listBox_list_employee.Items.Add(emps[count]);
                textBox_name.Text = "";
                textBox_salary.Text = "";
                textBox_date.Text = "";
                textBox_month.Text = "";
                textBox_year.Text = "";
            }
            else if (textBox_date.Text == "" || textBox_month.Text == "" || textBox_year.Text == "")
            {
                emps[count] = new Employee(textBox_name.Text, Convert.ToInt32(textBox_salary.Text));
                listBox_list_employee.Items.Add(emps[count]);
                textBox_name.Text = "";
                textBox_salary.Text = "";
                textBox_date.Text = "";
                textBox_month.Text = "";
                textBox_year.Text = "";
            }
            else if (textBox_date.Text != "" && textBox_month.Text != "" && textBox_year.Text != "")
            {
                emps[count] = new Employee(textBox_name.Text, Convert.ToInt32(textBox_salary.Text), Convert.ToInt32(textBox_date.Text), Convert.ToInt32(textBox_month.Text), Convert.ToInt32(textBox_year.Text));
                listBox_list_employee.Items.Add(emps[count]);
                textBox_name.Text = "";
                textBox_salary.Text = "";
                textBox_date.Text = "";
                textBox_month.Text = "";
                textBox_year.Text = "";
            }
            count++;

        }

        private void button_increase_salary_Click(object sender, RoutedEventArgs e)
        {
            //foreach (var employee in emps)
            //{
            //    employee.IncreaseSalary(20);
            //    listBox_list_employee.Items.Clear();
            //    listBox_list_employee.Items.Add(employee);
            //}

            //for (int i = 0; i < emps.Length; i++)
            //{
            //    emps[i].IncreaseSalary(20);
            //    listBox_list_employee.Items.IndexOf(i).Equals(emps[i]);
            //    listBox_list_employee.Items.Add(emps[i]);
            //}

            emps[0].IncreaseSalary(20);
            listBox_list_employee.Items.Add(emps[0]);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee[] emps_m = new Employee[4];
            emps_m[0] = new Employee("Иван Иванов", 1000);
            emps_m[1] = new Employee("Петр Петров", 2000, 1, 3, 2020);
            emps_m[2] = new Manager("Ева Браун", 1000, 10000);
            emps_m[3] = new Manager("Ольга Кирова", 2000, 20000);

            listBox_list_employees_and_managers.ItemsSource = emps_m;
        }
    }
}