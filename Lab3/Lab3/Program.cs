using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Dipty";
            s.Id = "19-35698-1";
            s.Department = "CSE";
            s.Cgpa = 3.65f;
            s.ShowInfo();
            Triangle t = new Triangle();
            t.X = 8;
            t.X = 10;
            t.Z = 12;
            t.ShowInfo();
            t.TestTriangle();
            Account a = new Account();
            a.AccName = "My Account";
            a.AcId = "1";
            a.Balance = 3000;
            a.Deposit(2000);
            a.Withdraw(2000);
            Course c = new Course();
            c.CourseName = "OOP2";
            c.CourseId = "1011";
            c.CourseCredit = 3;
            c.ShowCourseInfo();
        }
    }

}
