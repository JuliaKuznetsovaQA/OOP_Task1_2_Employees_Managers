using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    // поля:
    // имя, зарплата, дата приема на работу

    // конструкторы:
    // 5 параметров: имя, зарплата, дд, мм,гггг  - трудоустройства.
    // 2 параметра: имя, зарплата (дата трудоустройства - время создания объекта).

    // методы:
    // методы доступа к полям класса (свойства)
    // увеличение зарплаты на заданный процент (зарплата * процент/100);
    // вычисление стажа
    class Employee
    {
        private String name;
        private int salary;
        private DateTime dateTime;
        // TODO дата приема на работу
        public Employee(String name, int salary, int day, int month, int year) { 
            this.name = name;
            this.salary = salary;
            this.dateTime = new DateTime(year, month, day);
        }
        public Employee(String name, int salary)
        {
            this.name = name;
            this.salary = salary;
            this.dateTime = DateTime.Now;
        }

        public String getName()
        {
            return name;
        }

        public string Name{
            set => this.name = value; 
            get => this.name; 
        }
        public int Salary
        {
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("значение должно быть положительным");
                }
                else
                {
                    this.Salary = value;
                }
            }
            get => this.salary;
        }

    }
}
