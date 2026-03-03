using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class Mảng
    {
        static void Main (string[] args)
        {
            //Mảng //đc sử dụng để lưu trữ nhiều nhiều giá trị trong 1 biến duy nhất,
            //vì khai báo các biến riêng biệt cho mỗi giá trị

            string[] cars = { "đinh", "quang", "thais" }; // mảng các chuỗi 
            int[] myNum12 = { 1, 2, 3, 4, 5, 9, 7 }; // mảng các số nguyên

            Console.WriteLine(cars[0]); // trả về "đinh"
                                        //có thể đè giá trị lên như sau 
            cars[0] = "nguyễn";
            Console.WriteLine(cars[0]); // trả về "nguyễn" thì vì "đinh"
                                        // ta có thể đếm được có bao nhiêu giá trị trong 1 biến hay còn gọi là độ dài mảng
            Console.WriteLine(cars.Length); // trả về 3 

            //lặp qua mảng=====
            for (int ie = 0; ie < cars.Length; ie++)
            {
                Console.WriteLine(cars[ie]);
            } // trả về "nguyễn" "quang" "thais"    
              //foreach là 1 cách khác để lặp qua mảng
            foreach (string ie in cars) // foreach sẽ lặp qua từng phần tử trong mảng và gán giá trị của phần tử đó cho biến i trong mỗi lần lặp
            {
                Console.WriteLine(ie);
            } // trả về "nguyễn" "quang" "thais" như for nhưng cách viết ngắn gọn hơn 

            //sắp xếp mảng====
            Array.Sort(cars); // sắp xếp mảng theo thứ tự bảng chữ cái
            foreach (string ie in cars)
            {
                Console.WriteLine(ie);
            } // trả về "nguyễn" "quang" "thais" sau khi sắp xếp sẽ là "nguyễn" "quang" "thais" vì đã được sắp xếp theo thứ tự bảng chữ cái

            Array.Sort(myNum12); // sắp xếp mảng theo thứ tự tăng dần
            foreach (int ie in myNum12)
            {
                Console.WriteLine(ie);
            }   // trả về 1 2 3 4 5 7 9 sau khi sắp xếp sẽ là 1 2 3 4 5 7 9 vì đã đư���c sắp xếp theo thứ tự tăng dần   

            //Min Max Sum với Stystem.Linq
            Console.WriteLine(myNum12.Min()); // trả về giá trị nhỏ nhất trong mảng
            Console.WriteLine(myNum12.Max()); // trả về giá trị lớn nhất trong mảng
            Console.WriteLine(myNum12.Sum()); // trả về tổng giá trị trong mảng


            //Mảng đa chiều
            int[,] myNumbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // mảng da chiều có 3 hàng và 3 cột
            Console.WriteLine(myNumbers[0, 0]); // trả về 1 vì là phần tử ở hàng 0 cột 0
                                                //thay đổi các phần từ của mảng đa chiều
            myNumbers[0, 0] = 10; // thay đổi phần tử ở hàng 0 cột 0 thành 10
            Console.WriteLine(myNumbers[0, 0]); // trả về 10 vì đã được thay thế từ 1 thành 10
                                                //lặp qua mảng đa chiều // cx chỉ là in ra tất cả các phần tử trong mảng đa chiều
            foreach (int ie in myNumbers)
            {
                Console.WriteLine(ie);
            } // trả về 10 2 3 4 5 6 7 8 9 vì đã được thay thế từ 1 thành 10 và lặp qua tất cả phần tử trong mảng đa chiều
              // 
              //iuA HdioJASHdok jkasbjn chjk shj hkdsAhkj asdhjk sadjkhs ad jhsa dhjks adjbkhs jakhd shjkda asdhjk ashjkd jhk
        }
    }
}
