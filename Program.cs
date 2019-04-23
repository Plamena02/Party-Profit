using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var partysize = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var everydayEarn = 0;
            var sum = 0.0;
            
           for (int i =1; i<=days; i++)
			{
                if (i%10==0)
                {
                    partysize -= 2;  
                }
                if (i%15==0)
                {
                    partysize += 5;
                    sum -= partysize * 2;
                }
                if (i%3==0)
                {
                    sum -= 3 * partysize;
                }
                if (i%5==0)
                {
                    sum += 20 * partysize;
                    
                }
               
                
                everydayEarn = 50 - partysize * 2;
                sum += everydayEarn;
			}
             sum /= partysize;
             Console.WriteLine("{0} companions received {1} coins each.",partysize,(int)sum);

        }
    }
}
