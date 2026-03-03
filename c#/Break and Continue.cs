using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.c_
{
    internal class Break_and_Continue
    {
        static void Main(string[] args)
        {
            //Break và Continue
            int po = 0;
            while (po < 5)
            {
                Console.WriteLine(po);
                po++;
                if (po == 2)
                {
                    break; // dùng để dừng khi đáp ứng điều kiện
                }
            }

            for (po = 0; po < 5; po++)
            {

                if (po == 3)
                {
                    continue; //dùng để bỏ qua điều kiện  
                }
                Console.WriteLine(po);
            }
        }

    }
}
