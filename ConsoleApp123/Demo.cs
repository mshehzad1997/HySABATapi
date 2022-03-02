using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp123
{
    public delegate int DemoDel(int x);
    public class Refer
    {
       public void Encode()
        {
            Console.WriteLine("encoding video");
        }
       
    }
   
    public abstract class Practice
    {
        public abstract int Available();
        public abstract int Price();
    }
    public class Pesinger:Practice
    {
        public override int Available()
        {
            int totatseat = 34;
            Console.WriteLine("how many seats you book");
            int no = int.Parse(Console.ReadLine());
            if(no <= 6)
            {
                Console.WriteLine("you have booked seats");
            }
            else
            {
                Console.WriteLine("you can only book 6 seat not alot");
            }
            int number = totatseat - no;
            return number;
        }
        public override int Price()
        {
            Console.WriteLine("per seat is 2000");
            int amount = int.Parse(Console.ReadLine());
            if(amount>= 2000&& amount%2 == 0)
            {
                Console.WriteLine("your payment has been received");
            }
            return amount;
        }
    }
    class Demo<TKey, TValue>
    {
        Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

        public void funcdic<T, V>(T a, V b)
        {
            Dictionary<T, V> mydict = new Dictionary<T, V>();
            mydict.Add(a, b);
            foreach (KeyValuePair<T, V> item in mydict)
            {
                Console.WriteLine(item.Key + "  " + item.Value + "  ");
            }

        }
        public void ExceptionHnd()
        {

            try
            {

            
                Console.WriteLine("EnterNumber1");
                int age = int.Parse(Console.ReadLine());
            if(age > 15)
            {
                Console.WriteLine("ELIGIBLE");
            }
            else
            {
                throw new Exception("you are not eliglible");
            }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
