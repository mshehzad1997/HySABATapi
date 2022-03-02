using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp123
{
    class Person
    {

        public void Digits()
        {
            List<int> list1 = new List<int>();
            Console.WriteLine("Enter a number");
            int nu = int.Parse(Console.ReadLine());

            for (int i = 1; i < 5; i++)
            {
                int x = nu % 10;
                list1.Add(x);
                nu = nu / 10;

            }

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }

        public void LeftRotate(int k)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i <= k; i++)
            {
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public void RotateArray()
        {
            int[] myarray = { 1, 2, 3, 4, 5, 6 };

            int k = 2;
            for (int i = 0; i <= k; i++)
            {
                for (int j = 0; j < myarray.Length - 1; j++)
                {
                    int temp = myarray[j];
                    myarray[j] = myarray[j + 1];
                    myarray[j + 1] = temp;
                }


            }
            foreach (var item in myarray)
            {
                Console.WriteLine(item);
            }

        }
        public void MergeSort()
        {
            List<int> list1 = new List<int>() { -1, -4, -6 };
            List<int> list2 = new List<int>() { -2, -3, 5 };
            List<int> list3 = new List<int>();
            for (int i = 0; i < list1.Count; i++)
            {
                list3.Add(list1[i]);
                list3.Add(list2[i]);
            }
            for (int i = 0; i < list3.Count - 1; i++)
            {
                for (int j = 0; j < list3.Count - 1; j++)
                {
                    if (list3[j] < list3[j + 1])
                    {

                        int temp = list3[j];
                        list3[j] = list3[j + 1];
                        list3[j + 1] = temp;
                    }
                }


            }
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

        }
        public void AlternateElement()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4 };
            List<string> list2 = new List<string>() { "a", "b", "c", "d" };
            List<string> list3 = new List<string>();
            for (int i = 0; i < list1.Count; i++)
            {

                list3.Add(Convert.ToString(list1[i]));
                list3.Add(list2[i]);


            }
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

        }
        public void ConcateString()
        {
            List<int> IntList = new List<int>() { 1, 2, 3, 4 };
            List<string> StringList = new List<string>() { "a", "b", "c" };
            List<string> Combine = new List<string>();


            for (int i = 0; i < StringList.Count; i++)
            {

                Combine.Add(StringList[i]);
            }
            for (int i = 0; i < IntList.Count; i++)
            {
                Combine.Add(Convert.ToString(IntList[i]));
            }
            foreach (var item in Combine)
            {
                Console.WriteLine(item);
            }
        }
        public int RunningTotal(List<int> SumList)
        {
            int sum = 0;
            for (int i = 0; i < SumList.Count; i++)
            {
                sum += SumList[i];

            }
            return sum;
        }
        public List<int> OddPosition()
        {


            List<int> OddNumber = new List<int>() { 56, 78, 43, 12, 99 };
            List<int> list1 = new List<int>();
            for (int i = 0; i < OddNumber.Count; i++)
            {
                if (i % 2 != 0)
                {

                    list1.Add(OddNumber[i]);

                }
            }
            return list1;
        }
        public void ContainNumber(int Number)
        {

            int no = 0;
            List<int> NumberList = new List<int>() { 11, 22, 33, 44 };
            for (int i = 0; i < NumberList.Count; i++)
            {
                no = NumberList[i];


                if (Number == no)
                {
                    Console.WriteLine("number exists");

                }


            }



        }
        public void ReverseList()
        {
            List<int> list1 = new List<int>() { 100, 98, 99, 66, 55, 44 };
            for (int i = list1.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list1[i]);

            }

        }
        public void sortedlist()
        {
            var list1 = new List<int>() { 1, 4, 6 };
            var list2 = new List<int>() { 2, 3, 5 };
            list1.AddRange(list2);

        }
        public void Twolist()
        {
            var list1 = new List<char>() { 'a', 'b', 'c' };
            var list2 = new List<int>() { 1, 2, 3, };
            Console.WriteLine(list1[0] + "," + list1[1] + "," + list1[2] + "," + list2[0] + "," + list2[1] + "," + list2[2]);
            Console.WriteLine(list1[0] + "," + list2[0] + "," + list1[1] + "," + list2[1] + "," + list1[2] + "," + list2[2]);
        }
        public void SquareRoot()
        {
            double number = 0;
            var mylist = new List<int>() { 1, 2, 3, 4, 12, 16 };
            for (int i = 1; i < mylist.Count; i++)
            {

                if (number % 1 == 0)
                {
                    Console.WriteLine("perfect square is " + mylist[i]);
                }
            }
        }
        public int recursivefunc(List<int> funclist)
        {

            int sum = funclist[0];
            if (funclist.Count > 1)
            {
                funclist.RemoveAt(0);
                return sum += recursivefunc(funclist);
            }
            return sum;

        }
        public int sum2(List<int> listname)
        {
            int sum = 0;

            int i = 0;
            while (i < listname.Count)
            {
                sum += listname[i];
                i++;
            }
            return sum;
        }
        public int sum1(List<int> list1)
        {
            int sum = 0;
            for (int i = 0; i < list1.Count; i++)
            {
                sum += list1[i];
            }
            return sum;
        }
        public int mylists()
        {

            List<int> firstlist = new List<int>() { 112, 56, 78, 89, -334 };
            int largest = 0;

            for (int i = 0; i < firstlist.Count; i++)
            {
                if (largest < firstlist[i])
                {
                    largest = firstlist[i];

                }
            }

            return largest;
        }
        public int clist(List<int> myarray)
        {
            int mex;
            mex = myarray.Max();
            Console.WriteLine(myarray.Contains(56));
            return mex;
        }
        public int oddnumber()
        {
            List<int> li = new List<int>() { 123, 34, 67, 3, 7, 9, };

            int nu = 0;
            foreach (var item in li)
            {


                if (item % 2 != 0)
                {

                    Console.WriteLine(item);
                }
                else if (item % 2 == 0)
                {


                }


            }
            return nu;

        }
        public int arrays(int[] xyz)
        {
            foreach (var item in xyz)
            {
                Console.WriteLine(item);
            }
            int ze = xyz.Length;
            return ze;
        }
        public int counter()
        {
            List<int> numberlist = new List<int>() { 12, 34, 56, 78, 99 };
            int count = 0;
            foreach (var item in numberlist)
            {
                count++;
            }

            return count++;
        }
        public void palindrome()
        {

            Console.WriteLine("enter string");
            string name = Console.ReadLine();
            char[] myname = name.ToCharArray();
            string ReverseName = string.Empty;
            for (int i = myname.Length - 1; i >= 0; i--)
            {
                ReverseName += myname[i];
            }
            Console.WriteLine(ReverseName);
            if (ReverseName == name)
            {
                Console.WriteLine("string is correct");
            }
            else
            {
                Console.WriteLine("string is false");
            }



        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           


            //var demo = new Demo<string,string>();

            //demo.funcdic("Ali","Hamid is the");
            //demo.funcdic(12, 345);
            //demo.ExceptionHnd();



            //var studentGenerator = new StudentGenerator();
            //var studentCardRegistratr = new StudentCardRegistrar();


            // studentGenerator.StudentCreated += studentCardRegistratr.OnStudentCreated;


            //studentGenerator.CreateStudent("shahzad", 22);

            //nudel mydel = x => x * x;


            //Console.WriteLine(mydel(20));
            //int[] number = { 12, 22, 20, 33, 45, 66, 78, 29 };
            //var a = from i in number where i > 20 orderby i descending  select i;
            //List<string> Names = new List<string>() { "Ali", "Adeel", "Osama", "Haris" };
            //var name = from j in Names where j.Contains("a") select j;
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}




        }
    }
}
