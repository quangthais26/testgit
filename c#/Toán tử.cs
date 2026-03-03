using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class Toán_tử
    {
        static void Main(string[] args)
        {
            // toán tử 
            int x = 10 + 5;
            int y = x - 7;
            int z = x * y;
            int a = z / 5;
            int b = z % 5; // toán tử chia lấy dư
            int c = x++; // toán tử tăng 1 sau khi sử dụng giá trị x
            int d = y--; // toán tử giảm 1 sau khi sử dụng giá trị y
            int e = ++x; // tăng trước khi sử dụng giá trị x
            int f = ++y; // tăng trước khi sử dụng giá trị y
            //toán tử gán
            int sum = 5;
            sum += 5; // sum = sum + 5
            sum -= 5;
            sum /= 5;
            sum %= 5;
            sum &= 3; // & thực hiện AND bit VD: 5 với số bit là 0101 3 là 0011 thì lấy 0101 nhân cho 0011 là ra kết quả 0001
            sum |= 3; // | thực hiện OR bit VD: 0101 và 0011 0 với 0 là 0 còn nếu có số 1 thì là 1 kết quả là 0111
            sum ^= 3; // ^= thực hiện XOR khác 1 giống 0 VD: 0101 và 0011 có kết quá là 0110 có 2 số 1 là ra 0 
            sum >>= 3; // sum nhân với "2" mũ 3 
            sum <<= 3; // sum chia với "2" mũ 3
                       //so sánh
            int ss = 5;
            int tt = 9;
            Console.WriteLine(ss > tt);
            Console.WriteLine(ss < tt);
            Console.WriteLine(ss != tt);
            Console.WriteLine(ss >= tt);
            Console.WriteLine(ss <= tt);
            Console.WriteLine(ss == tt);
            // logic đúng sai 
            Console.WriteLine(ss < tt && ss > 2); // && là và cả 2 điều kiện phải chính xác mới đúng
            Console.WriteLine(ss < tt || tt > 10);// || chỉ cần chính xác 1 điều kiện là đúng 
            Console.WriteLine(!(ss < tt && ss > 2));// !() phủ định nó là sai luôn  
                                                    // toán học 
            Math.Max(5, 10); // trả về số lớn hơn trong 2 số
            Math.Min(5, 10); // trả về số nhỏ hơn trong 2 số
            Math.Sqrt(16); // trả về căn bậc 2 của số 
            Math.Abs(-5.5); // trả về giá trị tuyệt đối dương của số
            Math.Round(5.75); // trả về số nguyên gần nhất của số thực
        }
    }
}
