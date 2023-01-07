using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public class Stack 
    {
        //Объект класса StackItem
        StackItem stackItem;

        //Свойство Size
        public string Size 
        {
            get
            {
               return Convert.ToString(stackItem.SteckList.Count);
            } 
        }

        //Свойство Top
        public string Top
        {
            get
            {
                //Если стек пустой вернём null
                if (stackItem.SteckList.Count == 0) return null;

                return stackItem.SteckList.First();
            }
        }

        //Лист для хранения данных стека
        //internal List<string> SteckList = new List<string>();

        public Stack(params string[] strArr) 
        {
            stackItem = new StackItem();

            foreach (var str in strArr)
            {
                stackItem.SteckList.Insert(0, str);
            }
        }

        //Метод Add добавления данных в стек
        public void Add(string str)
        {
            stackItem.SteckList.Insert(0, str);
        }
        //Метод Pop получения верхнего элемента стека
        public string Pop()
        {
            var str = string.Empty;
            try
            {
                //Если стек пустой выбрасить исключение
                if (stackItem.SteckList.Count == 0)
                {
                    throw new Exception("Стек пустой!");
                }
                str = stackItem.SteckList.First();
                stackItem.SteckList.RemoveAt(0);
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
                foreach (var elm in item.stackItem.SteckList)
                {
                    newStack.stackItem.SteckList.Add(elm);
                } 
            }
            
            return newStack;
        }
        //Преобразуем стек в масив
        public string[] StackToArray(Stack el)
        {
            var rez = el.stackItem.SteckList.Where(x => x != "").ToArray();

            return rez;
        }

        //Ссылка на предыдущий элеменит стека (Доп. задание 3)
        public string SteckLinkElement()
        {
            return stackItem.SteckLinkSecondElement;
        }

        //-------------------------------------------------------------------------
        // Доп. задание 3
        class StackItem
        {
            private string _steckLinkSecondElement;
            public string SteckLinkSecondElement
            {
                get
                {
                    return _steckLinkSecondElement = SteckList[1];
                }
             
            }

            public List<string> SteckList = new List<string>();
            
        }

    }
}
