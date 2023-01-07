using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack("a","b","c");

            // size = 3, Top = 'c'
            Console.WriteLine($"size = {stack.Size}, Top = {stack.Top}");
            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{stack.Pop()}' Size = {stack.Size}");
            stack.Add("d");

            // size = 3, Top = 'd'
            Console.WriteLine($"Добавил элемент d Size = {stack.Size}, Top = '{stack.Top}'");
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // size = 0, Top = null
            Console.WriteLine($"Вызвал 3 раза метод Pop  Size = {stack.Size}, Top = {stack.Top}");
            stack.Pop();

            //---------------------------------------------------------------------------------------------------------------
            var st1 = new Stack("a", "b", "c");
            var rez1 = StackExtensions.Merge(st1,new Stack("1", "2", "3"));
            //var rez = s.SteckList.Where(x => x != "").ToArray();
            
            Console.WriteLine($"\nДоп. задание 1");
            foreach (var item in rez1)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            //---------------------------------------------------------------------------------------------------------------
            var st2 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            var rez2 = st2.StackToArray(st2);

            Console.WriteLine($"\nДоп. задание 2");
            foreach (var item in rez2)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            //---------------------------------------------------------------------------------------------------------------
            var st3 = new Stack("А0", "Б1", "В2", "Г3", "Д4");
            Console.WriteLine($"\nДоп. задание 3");
            var rez3 = st3.SteckLinkElement();
            Console.WriteLine("ссылка на предыдущий элемент = " + rez3);

            Console.ReadKey();
        }
    }
}
