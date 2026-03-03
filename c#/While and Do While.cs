using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class While_and_Do_While
    {
        static void Main(string[] args)
        {
            // While
            int v0 = 0;
            while (v0 < 5) ; // vòng lặp này sẽ thực thi 1 khối mã miễn là điều kiện được chỉ định được thỏa mãn 
            {
                Console.WriteLine(v0);
                v0++;

            }


            //Do While
            int v1 = 0;
            do // vòng lặp này sẽ được thực thi ít nhất 1 lần trước khi tìm đến điều kiện
               // nếu điều kiện đc thỏa mãn thì tiếp tục thực thi
            {
                Console.WriteLine(v1);
                v1++;
            } 
            while (v1 < 5);

        }
    }
}
