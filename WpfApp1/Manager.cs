using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Manager : Employee
    {
        private int bonus;
        public Manager(string name, int salary, int day, int month, int year, int bonus) : base(name, salary, day, month, year)
        {
            this.bonus = bonus;
        }
        public Manager(string name, int salary, int bonus) : base(name, salary)
        {
            this.bonus = bonus;
        }

        public Manager(string name, int bonus) : base(name)
        {
            this.bonus = bonus;
        }

        public int Bonus
        {
            set => this.bonus = value;
            get => this.bonus;
        }

        public override int getSalary()
        {
            return base.Salary + this.bonus;
        }

        public override string ToString()
        {
            return "manager " + base.ToString() + ", бонус: " + this.bonus;
        }

    }
}
