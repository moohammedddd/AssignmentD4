using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Id == y.Id && x.Name == y.Name;

        }
        public int GetHashCode(Employee? emp)
        {
            return HashCode.Combine(emp.Id, emp.Name);
        }
    }
    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }


        public Employee(int _id, string _name, decimal _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
        }
        public override string ToString()
        {
            return $"Id : {Id} name : {Name} Salary : {Salary}";
        }

        #region Methoods
        // To Sort Based On Salary
        public int CompareTo(Employee? other)
        {
            if (other is null) return 1;
            return Salary.CompareTo(other.Salary);

        }


        public override bool Equals(object? obj)
        {
            if (obj == null || (obj.GetType() != typeof(Employee)))
                return false;
            Employee other = (Employee)obj;
            return this.Id == other.Id && this.Name == other.Name && this.Salary == other.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }



        #endregion


    }
}

