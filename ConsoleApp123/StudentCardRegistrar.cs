using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    public class StudentCardRegistrar
    {
        public void OnStudentCreated(Student student)
        {
            CreateStudentCard(student);
        }
        private void CreateStudentCard(Student student)
        {
            Console.WriteLine($"Created Student Card with Name {student.Name}");
        }
    }
}
