using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class Switch_case
    {
        static void Main(string[] args)
        {
            //Switch case
        int day = 4;
                switch (day) // sẽ chọn ra 1 trong nhiều khối được 
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default: // default sẽ được thực thi nếu không có case nào khớp với giá trị của day
                        Console.WriteLine("Invalid day.");
                        break;
                        // trả về "Thursday" vì day bằng 4

                    // còn có kiểu goto nếu case 4 có goto thay vì bằng break thì sẽ in tiếp case 5
                }
            }
    }
}
