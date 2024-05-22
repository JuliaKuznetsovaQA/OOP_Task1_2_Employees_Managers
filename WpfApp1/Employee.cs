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
    public class Employee
    {
        private String name;
        private int salary;
        private DateTime hireDate;
        public int id;
        public static int nextId = 0;

        // Конструкторы
        public Employee(String name, int salary, int day, int month, int year) { 
            this.name = name;
            this.salary = salary;
            this.hireDate = new DateTime(year, month, day);
            this.id = getNextId();
        }

        public Employee(String name, int salary)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            this.id = getNextId();
        }

        public Employee(String name) 
        {
            this.name = name;
            this.salary = 0;
            this.hireDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            this.id = getNextId();
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
                    this.salary = value;
                }
            }
            get => this.salary;
        }

        public virtual int getSalary()
        {
            return this.salary;
        }

        public override string ToString()
        {
            return "id: " + id + " сотрудник ФИО: " + this.name + ", зарплата = " + this.salary + ", дата приема на работу: " + this.hireDate;
        }

        public void IncreaseSalary(int percent)
        {
            this.Salary += this.Salary / 100 * percent;
        }

        public int getNextId()
        {
            nextId += 1;
            return nextId;
        }
        public int getId()
        {
            return this.id;
        }
        public void setId()
        {
            this.id = getNextId();
        }
    }
}
