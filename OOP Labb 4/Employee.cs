using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_4
{
    public class Employee
    {
        public int id;
        public string name;
        public string gender;
        public decimal salary;
        public Employee(int _id, string _name, string _gender, decimal _salary)
        {
            id = _id;
            name = _name;
            gender = _gender;
            salary = _salary;
        }
        public Employee():this(0, "Unknown", "Unknown", 0)
        {
                    
        }
    }
}
