using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                myList.Add(rand.Next(0, 100));
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();
            myList.Sort();
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            //myList.Remove(myList.Max());
            Console.WriteLine();
            Console.WriteLine("Максимальный второй элемент: {0}", myList[myList.Count - 2]);
            int sum = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                if (i % 2 != 0)
                    sum += myList[i];
            }
            Console.WriteLine("Сумма на нечетных позициях: {0}", sum);

            for (int i = 0; i < myList.Count; i++)
                myList.RemoveAt(i);

            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            List<double> myList1 = new List<double>();
            Random rand1 = new Random();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                myList1.Add(rand.Next(1000, 9999)/10.0);
                Console.Write(myList1[i] + " ");
            }
            double average = myList1.Sum() / myList1.Count;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Элементы больше среднего {0} :", average);
            foreach (var item in myList1)
            {
                if (item > average)
                    Console.Write(item + "  ");
            }

        }
    }
}
