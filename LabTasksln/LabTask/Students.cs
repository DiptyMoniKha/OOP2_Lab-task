using System;

namespace LabTask
{
    class Students
    {
 
        private
        String name;
        String id;
        String department;
        float cgpa;
        private Students()
        { }
        public Students(String nm, String idd, String dep, float cg)
        {
            name = nm;
            id = idd;
            department = dep;
            cgpa = cg;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name of this Student is: " + name);
            Console.WriteLine("ID of this Student is: " + id);
            Console.WriteLine("Department of this Student is: " + department);
            Console.WriteLine("CGPA of this Student is: " + cgpa);
        }
    }
}
