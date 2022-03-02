using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
  static   class StaticClass
    {
        public static int Ids { get; set; }
       
        public static int GetId(this Refer p)
        {
            return Ids;
        }
        
    }
    public class ExceptionHandling
    {
       
       
         
    }
}
