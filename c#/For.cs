using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class For
    {
        static void Main(string[] args)
        {
            // For
            for (int im = 0; im < 5; im++) // vòng lặp này sẽ được thực thi một số lần xác định trước dựa trên điều kiện được chỉ định
            {
                Console.WriteLine(im);
            } // trả về 0 1 2 3 4 vì im bắt đầu từ 0 và tăng dần đến khi im bằng 5 thì dừng lại

            //vòng lặp lồng nhau 
            for (int im = 0; im < 5; im++)
            {
                Console.WriteLine("Outer loop iteration: " + im);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("  Inner loop iteration: " + j);
                }
            }    // vòng lặp này sẽ có 2 vòng lặp vòng lặp bên ngoài sẽ có 5 lần thực thi,
                 // vòng lặp bên trong sẽ thực thi 3 lần thực thi,
                 // như vậy vòng lặp bên trong sẽ phải thực thi 3 lần như thế với 5 lần nữa 3x5 là 15 lần tổng cộng 

        }
    }
}
