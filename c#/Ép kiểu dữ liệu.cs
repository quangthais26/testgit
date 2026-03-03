using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class Ép_kiểu_dữ_liệu
    {
        static void Main (string[]args)
        {
            int myInt = 9;
            double myDouble = myInt; // tự động ép kiểu sang double kiểu ép ngầm từ bé sang lớn
            Console.WriteLine(myInt); // in ra 9
            Console.WriteLine(myDouble);// in ra 9.0 vì đã được ép kiểu sang double

            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2; // ép kiểu thủ công từ double sang int kiểu ép rõ ràng từ lớn sang bé
            Console.WriteLine(myDouble2); // in ra 9.78
            Console.WriteLine(myInt2); // in ra 9

            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool2 = true;
            Console.WriteLine(Convert.ToString(myInt3)); // chuyển int sang string
            Console.WriteLine(Convert.ToDouble(myInt3)); // chuyển int sang double
            Console.WriteLine(Convert.ToInt32(myDouble3)); // chuyển double sang int // Int32 là 32 bit
            Console.WriteLine(Convert.ToString(myBool2)); // chuyển bool sang string

            //người dùng nhập dữ liệu

            Console.WriteLine("Enter your name: "); // tên
            string userName = Console.ReadLine(); //đọc dữ liệu người dùng nhập vào
            Console.WriteLine("Hello, " + userName); //nối chuỗi để in ra lời chào với tên người dùng

            Console.WriteLine("Enter your age: "); // tuổi
            int userAge = Convert.ToInt32(Console.ReadLine()); //đọc dữ liệu người dùng nhập vào và chuyển sang int
            Console.WriteLine("You are " + userAge + " years old."); //nối chuỗi để in ra tuổi người dùng
        }
    }
}
