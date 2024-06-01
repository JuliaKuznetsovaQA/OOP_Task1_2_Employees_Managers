using System.IO;
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
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBox_list_employee.ItemsSource = employees;
        }

        List<Employee> employees = new List<Employee>();

        
        private void button_add_employee_Click(object sender, RoutedEventArgs e)
        {
            TextBox[] textBoxes = {
                textBox_name, 
                textBox_salary,
                textBox_date,
                textBox_month,
                textBox_year};

            void clearTextBoxes()
            {
                foreach (var textBox in textBoxes)
                {
                    textBox.Text = "";
                }
            }
            

            if (textBox_name.Text == "")
            {
                MessageBox.Show("Введите ФИО");
            }
            else if (textBox_salary.Text == "")
            {
                employees.Add(new Employee(textBox_name.Text));
            }
            else if (textBox_date.Text == "" || textBox_month.Text == "" || textBox_year.Text == "")
            {
                employees.Add(new Employee(textBox_name.Text, Convert.ToInt32(textBox_salary.Text)));
            }
            else if (textBox_date.Text != "" && textBox_month.Text != "" && textBox_year.Text != "")
            {
                employees.Add(new Employee(textBox_name.Text, Convert.ToInt32(textBox_salary.Text), Convert.ToInt32(textBox_date.Text), Convert.ToInt32(textBox_month.Text), Convert.ToInt32(textBox_year.Text)));
                
            }
            listBox_list_employee.Items.Refresh();
            clearTextBoxes();
            
        }

        
        private void button_add_manager_Click(object sender, RoutedEventArgs e)
        {
            TextBox[] textBoxes = {
                textBox_name_m,
                textBox_salary_m,
                textBox_date_m,
                textBox_month_m,
                textBox_year_m,
                textBox_bonus_m};

            void clearTextBoxes_m()
            {
                foreach (var textBox in textBoxes)
                {
                    textBox.Text = "";
                }
            }

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
                employees.Add(new Manager(textBox_name_m.Text, Convert.ToInt32(textBox_bonus_m.Text)));
                
            }
            else if (textBox_date_m.Text == "" || textBox_month_m.Text == "" || textBox_year_m.Text == "")
            {
                employees.Add(new Manager(textBox_name_m.Text, Convert.ToInt32(textBox_salary_m.Text), Convert.ToInt32(textBox_bonus_m.Text)));
                
            }
            else if (textBox_date_m.Text != "" && textBox_month_m.Text != "" && textBox_year_m.Text != "")
            {
                employees.Add(new Manager(textBox_name_m.Text, Convert.ToInt32(textBox_salary_m.Text), Convert.ToInt32(textBox_date_m.Text), Convert.ToInt32(textBox_month_m.Text), Convert.ToInt32(textBox_year_m.Text), Convert.ToInt32(textBox_bonus_m.Text)));
                
            }
            listBox_list_employee.Items.Refresh();
            clearTextBoxes_m();

        }

        private void button_increase_salary_Click(object sender, RoutedEventArgs e)
        {
            int percent = 0;
            try
            {
                percent = Convert.ToInt32(textBox_percent.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите процент, на который нужно увеличить зарплату");
            }
            

            foreach (Employee emp in employees)
            {
                emp.IncreaseSalary(percent);
            }
            listBox_list_employee.Items.Refresh();
                        
        }

    }
}