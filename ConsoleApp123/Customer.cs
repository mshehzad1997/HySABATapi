using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public delegate void TeacherCreated(Teacher teacher);
    public class TeacherGenerator
    {
        public event TeacherCreated teacherEvent;
        public void CreateTeacher(string name, int age)
        {
            var teacher = new Teacher
            {
                Name = name,
                Age = age
            };
            Console.WriteLine($"Created teacher with Name{ teacher.Name}");
            teacherEvent?.Invoke(teacher);
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public  delegate void StudentCreated(Student student);    
    class StudentGenerator
    {
        public event StudentCreated StudentCreated;
        public void CreateStudent(string name,int age)
        {
            var student = new Student
            {
                Name = name,
                Age = age,
            };
            Console.WriteLine($"Created Student with Name {student.Name}");
            //Added to Database
            StudentCreated?.Invoke(student);
           // StudentCreated(student);
            
        }
        public delegate void del(int x, int y);
        public event del delevent;
        public void myfunc()
        {
            
        }
        public  int Add(int x, int y)
        {
            Console.WriteLine("Adding");
            int sum = x + y;
            return sum;
        }
        public int Sub(int x, int y)
        {
            Console.WriteLine("Subtracting");
            int sum = x - y;
            return sum;
        }
        public int Mul(int x, int y)
        {
            Console.WriteLine("Multiplication");
            int sum = x * y;
            return sum;
        }
        public int Div(int x, int y)
        {
            Console.WriteLine("Divison");
            int sum = x / y;
            return sum;
        }
    }
   public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key,TValue value)
        {
           
        }
    }
    class Stopwatchs
    {
       
    }
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary;
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
    class Customer
    {
        public DateTime _birthdate;
        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public  DateTime GetBirthDate()            
        {
            return _birthdate;
        }
       public int arrys(params int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
        public void func(ref int xyz)
        {
            xyz = xyz + 23; 
        }
    }
}
