using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class BIến
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // câu in cơ bản ( xuống dòng)
            Console.Write("Hello, World!"); // câu in cơ bản ( không xuống dòng)

            string name = "John";       //string lưu trữ văn bản 
            Console.WriteLine(name);

            int myNum = 15;             //int lưu trữ số nguyên 4 bytes
            Console.WriteLine(myNum);

            int myNum2;                 //có thể khai báo trước rồi gán sau
            myNum2 = 15;
            Console.WriteLine(myNum2);

            int myNum3 = 15;          // có thể khai báo và đè lên giá trị sau
            myNum3 = 20;
            Console.WriteLine(myNum3);

            double myDoubleNum = 5.99D;   //double lưu trữ số thực 8 bytes 
            char myLetter = 'D';           //char lưu trữ 1 ký tự 2 bytes
            bool myBool = true;           //bool lưu trữ giá trị đúng hoặc sai 1 byte
            long myLongNum = 15000000000L;   //long lưu trữ số nguyên lớn 8bytes
            float myFloatNum = 5.75F;        //float lưu trữ số thực có độ chính xác thấp hơn double 4bytes
                                             // có các kí tự như D , L, F để chỉ định kiểu dữ liệu cho số thực và số nguyên lớn
        }
    }
}
