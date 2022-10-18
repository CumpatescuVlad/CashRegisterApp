using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TestingOOP
{
    internal  class Program
    {
        public static void Main()
        {

            int[] nums = {0,1,2,3,4,5,6,7,8,9,10 };

            IEnumerable<int> numbers = 
                from num in nums 
                where num<9 
                select num;

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            

        }
       
       
        
       
        
            
           

       
        

    }
}
