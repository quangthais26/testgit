using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class Boolearn
    {
        static void Main (string[] args)
        {
            // Boolearn //(giống bool cx chỉ là phân biệt đúng sai nhưng có thêm giá trị null)
            int myAge1 = 25;
            int votingAge = 18;
            Console.WriteLine(myAge1 >= votingAge); // trả về true vì 25 lớn hơn 18

            // 1 ví dụ về boolearn là kiểm tra xem người dùng có đủ điều kiện để bỏ phiếu hay không
            if (myAge1 >= votingAge)
            {
                Console.WriteLine("Old enough to vote.");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }
        }
    }
}
