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
        
        public static int count = 0;

        private void button_add_employee_Click(object sender, RoutedEventArgs e)
        {

            if (textBox_name.Text == "")
            {
                MessageBox.Show("Введите ФИО");
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

        Employee[] managers = new Employee[10];

        public static int count_m = 0;
        private void button_add_manager_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_name_m.Text == "")
            {
                MessageBox.Show("Введите ФИО");
            }
            else if (textBox_bonus_m.Text == "")
            {
                MessageBox.Show("Введите бонус");
            }
            else if (textBox_salary_m.Text == "")
            {
                managers[count_m] = new Manager(textBox_name_m.Text, Convert.ToInt32(textBox_bonus_m.Text));
                listBox_list_managers.Items.Add(managers[count_m]);
                textBox_name_m.Text = "";
                textBox_salary_m.Text = "";
                textBox_date_m.Text = "";
                textBox_month_m.Text = "";
                textBox_year_m.Text = "";
                textBox_bonus_m.Text = "";
            }
            else if (textBox_date_m.Text == "" || textBox_month_m.Text == "" || textBox_year_m.Text == "")
            {
                managers[count_m] = new Manager(textBox_name_m.Text, Convert.ToInt32(textBox_salary_m.Text), Convert.ToInt32(textBox_bonus_m.Text));
                listBox_list_managers.Items.Add(managers[count_m]);
                textBox_name_m.Text = "";
                textBox_salary_m.Text = "";
                textBox_date_m.Text = "";
                textBox_month_m.Text = "";
                textBox_year_m.Text = "";
                textBox_bonus_m.Text = "";
            }
            else if (textBox_date_m.Text != "" && textBox_month_m.Text != "" && textBox_year_m.Text != "")
            {
                managers[count_m] = new Manager(textBox_name_m.Text, Convert.ToInt32(textBox_salary_m.Text), Convert.ToInt32(textBox_date_m.Text), Convert.ToInt32(textBox_month_m.Text), Convert.ToInt32(textBox_year_m.Text), Convert.ToInt32(textBox_bonus_m.Text));
                listBox_list_managers.Items.Add(managers[count_m]);
                textBox_name_m.Text = "";
                textBox_salary_m.Text = "";
                textBox_date_m.Text = "";
                textBox_month_m.Text = "";
                textBox_year_m.Text = "";
                textBox_bonus_m.Text = "";
            }
            count++;
        }

        private void button_increase_salary_Click(object sender, RoutedEventArgs e)
        {
            foreach (var employee in emps)
            {
                employee.IncreaseSalary(20);
                listBox_list_employee.Items.Clear();
                listBox_list_employee.Items.Add(employee);
            }

            //for (int i = 0; i < emps.Length; i++)
            //{
            //    emps[i].IncreaseSalary(20);
            //    listBox_list_employee.Items.IndexOf(i).Equals(emps[i]);
            //    listBox_list_employee.Items.Add(emps[i]);
            //}

            //emps[0].IncreaseSalary(20);
            //listBox_list_employee.Items.Add(emps[0]);

        }

    }
}