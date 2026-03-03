using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class Chuỗi_ký_tự
    {
        static void Main(string[] args)
        {
            // chuỗi ký tự 

            //Chuỗi
            string txt = "Hello, World!";
            Console.WriteLine(txt.Length); // trả về độ dài của chuỗi
            Console.WriteLine(txt.ToUpper()); // chuyển chuỗi thành chữ hoa
            Console.WriteLine(txt.ToLower()); // chuyển chuỗi thành chữ thường
                                              //Nối
            string firstName = "ĐINH";
            string lastName = "THÁI";
            string fullName = string.Concat(firstName, lastName); // nối chuỗi với khoảng trắng ở giữa
            Console.WriteLine(fullName);

            int u = 1;
            int i = 2;
            int p = u + i; // p sẽ bằng 3 cộng bth

            string u1 = "10";
            string i1 = "20";
            string p1 = u1 + i1; // p1 sẽ bằng "1020" vì là nối chuỗi
            //Nội suy chuỗi 
            string name1 = "John";
            string name2 = "Doe";
            string fullname1 = $"My name is :{name1} {name2}"; // sử dụng $ để nội suy chuỗi và {} để chèn biến vào chuỗi"
                                                               //Chuỗi truy cập
            string myString = "Hello World";
            Console.WriteLine(myString[0]); // truy cập ký tự đầu tiên của chuỗi // trả về H
            Console.WriteLine(myString[1]); // truy cập ký tự thứ 2 của chuỗi // trả về e
            Console.WriteLine(myString.IndexOf("W")); // trả về 1
            int charPos = myString.IndexOf("o");
            string lastName2 = myString.Substring(charPos); //trả về từ chữ cái o đến hết // trả về World
            Console.WriteLine(lastName2);
            //Ký tự đặc biệt 
            string lq = "Chào Mừng Đến Với Bình Nguyên Vô Tận";
            string lq1 = "Chào Mừng Đến Với \"Bình Nguyên\" Vô Tận"; //      \" = "
            Console.WriteLine(lq1);
            string lq2 = "Chào Mừng Đến Với \\Bình Nguyên\\ Vô Tận"; //     \\ = \
            Console.WriteLine(lq2);
            string lq3 = "Chào Mừng Đến Với \'Bình Nguyên\' Vô Tận";//     \' = '
            Console.WriteLine(lq3);
            string lq4 = "Chào Mừng Đến Với \nBình\tNguyên \bVô Tận";//    \n = xuống dòng mới, \t = tab, \b = xóa kí tự trước đó 
            Console.WriteLine(lq4);
        }
    }
}
