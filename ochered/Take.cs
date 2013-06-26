using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ochered
{
    class Take
    {
        public static int TakeFirstElement()
        {
            //Получаем первый элемент массива
            int FirstElement;

            if (MyList.list.Length > 0)
            {
                FirstElement = MyList.list[0];
            }
            else
            {
                Console.WriteLine("Пустой массив");
                FirstElement = 0;
                
            }
          
            //Удаляем первый элемент очереди
            for (int i = 0; i < MyList.list.Length - 1; i++)
            {
                MyList.list[i] = MyList.list[i + 1]; 
            }    
            
            Array.Resize(ref MyList.list, MyList.list.Length - 1);
            
            //Возвращаем первый элемент очереди
            return FirstElement;
        }
    }
}
