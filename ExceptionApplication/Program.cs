using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = null;
            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        private static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("student object is null");

            Console.WriteLine(std.StudentName);

        }

    }
    public class Student
    {

        public string StudentName { get; set; }
    }
}