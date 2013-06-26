using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ochered
{
    class MyList
    {
        public static int[] list = {0,1,2,3,4,5,6,7,8,9};

        public static void Prev() //Выводим на консоль элементы очереди
        {
            Console.WriteLine("В очереди находятся данные элементы");
            foreach (int val in MyList.list)
            {
                Console.WriteLine(val);
            }
        }
    }
}
