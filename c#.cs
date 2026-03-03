using System; //có thể sử dụng các class từ system
              //VD: using Institute_Of_Fine_Art_BE.Models; là có thể sử dụng các class trong namespace Institute_Of_Fine_Art_BE.Models
using System.Linq; //có thể sử dụng các phương thức mở rộng LINQ để truy vấn và thao tác với dữ liệu trong các tập hợp như mảng, danh sách, v.v. VD: var result = myList.Where(x => x.Age > 18); sẽ trả về một tập hợp mới chứa các phần tử trong myList có thuộc tính Age lớn hơn 18
namespace Helloworld; //
internal class C // là 1 vùng chứa dữ liệu mang tên Progarm 
{
    static void Main(string[] args) //static void Main(string[] args) là điểm bắt đầu của chương trình,
                                    //nơi mà mã lệnh sẽ được thực thi khi chạy ứng dụng.
                                    //Đây là phương thức chính (entry point) của chương trình,
                                    //và nó phải có chữ ký chính xác như vậy để được công nhận bởi trình biên dịch C#.
                                    //Tham số string[] args cho phép chương trình nhận các đối số từ dòng lệnh khi chạy ứng dụng,
                                    //giúp cho việc truyền dữ liệu vào chương trình trở nên linh hoạt hơn.

                                    // static → để hệ thống gọi được mà không cần tạo object
                                    //void → không trả giá trị
                                    //Main → điểm bắt đầu chương trình
                                    //string[] args → nhận dữ liệu từ bên ngoài khi chạy
    
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






        // ép kiểu dữ liệu

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






        // toán tử 
        int x = 10 + 5;
        int y = x - 7;
        int z = x * y;
        int a = z / 5;
        int b = z % 5; // toán tử chia lấy dư
        int c = x++; // toán tử tăng 1 sau khi sử dụng giá trị x
        int d = y--; // toán tử giảm 1 sau khi sử dụng giá trị y
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
        }







        // While
        int v0 = 0;
        while (v0 > 5) ; // vòng lặp này sẽ thực thi 1 khối mã miễn là điều kiện được chỉ định được thỏa mãn 
        {
            Console.WriteLine(v0);
            v0++;
        } 
        

        //Do While
        int v1 = 0;
        do // vòng lặp này sẽ được thực thi ít nhất 1 lần trước khi tìm đến điều kiện nếu điều kiện đc thỏa mãn thì tiếp tục thực thi
        {
            Console.WriteLine(v1);
            v1++;
        } while (v1 < 5);








        // For
        for (int im = 0; im < 5; im++) // vòng lặp này sẽ được thực thi một số lần xác định trước dựa trên điều kiện được chỉ định
        {
            Console.WriteLine(i1);
        } // trả về 0 1 2 3 4 vì im bắt đầu từ 0 và tăng dần đến khi im bằng 5 thì dừng lại

        //vòng lặp lồng nhau 
        for (int im = 0; im < 5; im++)
        {
            Console.WriteLine("Outer loop iteration: " + im);
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("  Inner loop iteration: " + j);
            }
        }    // vòng lặp này sẽ có 2 vòng lặp vòng lặp bên ngoài sẽ có 5 lần thực thi, vòng lặp bên trong sẽ thực thi 3 lần thực thi, như vậy vòng lặp bên trong sẽ phải thực thi 3 lần như thế với 5 lần nữa 3x5 là 15 lần tổng cộng 

        




        //Break và Continue
        int po= 0;
        while (po < 5) 
        {
            Console.WriteLine(po);
            po++;
            if (po == 2)
            {
                break; // dùng để dừng khi đáp ứng điều kiện
            }
        }

        for (po=0 ; po < 5; po++)
        {
            
            if (po == 3)
            {
                continue; //dùng để bỏ qua điều kiện  
            }
            Console.WriteLine(po);
        }







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






    }
}

