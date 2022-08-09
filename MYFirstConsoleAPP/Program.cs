using System;
using System.Collections;
using System.Collections.Generic;

namespace MYFirstConsoleAPP
{
    class Student
    {
        private int rollnumber, marks1, marks2, marks3, total;
        private double average;
        private string studentname;
        private static int count = 0;
        public Student(int rollnumber, string studentname, int marks1, int marks2, int marks3)
        {
            this.rollnumber = rollnumber;
            this.studentname = studentname;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;
            count++;
        }
        public int GetTotal()
        {
            return (marks1 + marks2 + marks3);
        }
        public double GetAverage()
        {
            return (marks1 + marks2 + marks3) / 3.0;
        }
        public static int GetCount()
        {
            return count;
        }
    }
    class MarksException : ApplicationException
    {
      public  override string Message
        {
            get
            {
               return "MArks should be in range of 0-100";
            }
        }
    }
    class Employee
    {
        public int EmpNumber { set; get; }  
        public string EmployeeName { set; get; }
        public int salary { set; get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        
            List<Employee> empList= new List<Employee>();
            empList.Add(new Employee { EmpNumber = 101, EmployeeName = "asd", salary = 10011 });
            empList.Add(new Employee { EmpNumber = 101, EmployeeName = "asd", salary = 10011 });
            empList.Add(new Employee { EmpNumber = 101, EmployeeName = "asd", salary = 10011 });
        foreach(Employee e in empList)
            {
                Console.WriteLine($"{e.EmpNumber},{e.EmployeeName},{e.salary}");
            }
        }
    }
}
