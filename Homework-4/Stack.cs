using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Stack : StackExtensions
    {
        //Свойство Size
        public string Size 
        {
            get
            {
               return Convert.ToString(SteckList.Count);
            } 
        }

        //Свойство Top
        public string Top
        {
            get
            {
                //Если стек пустой вернём null
                if (SteckList.Count == 0) return "null";

                return SteckList.First();
            }
        }

        //Лист для хранения данных стека
        internal List<string> SteckList = new List<string>();

        public Stack(params string[] strArr) 
        {
            foreach (var str in strArr)
            {
                //SteckList.Insert(0,str);
                SteckList = SteckList.Prepend(str).ToList();
            }
        }

        //Метод Add добавления данных в стек
        public void Add(string str)
        {
            //SteckList.Insert(0, str);
            SteckList = SteckList.Prepend(str).ToList();
        }
        //Метод Pop получения верхнего элемента стека
        public string Pop()
        {
            var str = string.Empty;
            try
            {
                //Если стек пустой выбрасить исключение
                if (SteckList.Count == 0)
                {
                    throw new Exception("Стек пустой!");
                }
                str = SteckList.First();
                SteckList.RemoveAt(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return str;
        }

        public static Stack Concat(params Stack[] el)
        {
            var newStack = new Stack(); 
            foreach (var item in el)
            {
                foreach (var elm in item.SteckList)
                {
                    newStack.SteckList.Add(elm);
                }
            }
            newStack.SteckList.Reverse();

            return newStack;
        }

    }
}
