﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    public class Employee
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public double Salary;


        public Employee(string name, string surname, byte age, string departmentName, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = departmentName;
            Salary = salary;
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nDepartmentName: {DepartmentName}\nSalary: {Salary}");
        }
    }
}
