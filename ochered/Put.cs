using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ochered
{
    class Put
    {
        public static void PutNewElement ()
        {
            Console.WriteLine("Введите значение нового элемента очереди");
            string valstr = Console.ReadLine();
            int val = Convert.ToInt32(valstr);

            Array.Resize(ref MyList.list, MyList.list.Length + 1);
            MyList.list[MyList.list.Length - 1] = val;
        }
        
    }
}
