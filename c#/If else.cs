using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class If_else
    {
        static void Main(string[] args)
        {
            //If else 
            //if
            int time = 20; //đủ điều kiện thì mới thực thi được 
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            //else
            else
            {
                Console.WriteLine("Good evening.");
            }   // trả về "Good evening." vì 20 lớn hơn 18

            //else if // chỉ đơn giản là thêm 1 điều kiện vào if else
            int time1 = 22;
            if (time1 < 10)
            {
                Console.WriteLine("Good day.");
            }
            else if (time1 == 22)
            {
                Console.WriteLine("Good night.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }   // trả về "Good night." vì 22 bằng 22

            //viết tắt của if else
            int time2 = 20;
            string result = (time2 < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result); // trả về "Good evening." vì 20 lớn hơn 18 //cứ hiểu như ? là if còn : là else

            //ALSKJHd kjASoaIS JiosADhsoxc ihjuoi uhos asihu huisaiu hd iuhsiuh asds iuh uihsa iusa uih súi iuhs iuhs aiuh

        }
    }
}
