using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LinQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEMO01();
            //DEMO02();
            //DEMO03();
            //DEMO04();
            //DEMO05();
            //DEMO05B();
            DEMO06();
        }
       
        private static void DEMO01()
        {
            int[] items = new int[] { 1, 44, 58, 66, 12, 10, 55, 22, 33, 42, 6 ,55555};

            int firstValue = items.First(x => x > 5000);
            int firstValue2 = items.FirstOrDefault(x => x > 5000);

            Console.WriteLine(firstValue);
        
        }
        private static void DEMO02()
        {
            int[] items = new int[] { 1, 44, 58, 66, 12, 10, 55, 22, 33, 42, 6 };

            bool result = items.All(x => x > 0);
            Console.WriteLine("是否全部大於零?"+result);
          
        }
        private static void DEMO03()
        {
            int[] items = new int[] { 1, -44, 58, 66, 12, 10, 55, 22, 33, 42, 6 };

            bool result =items.Any(x => x > 0);
            Console.WriteLine("是否至少有一筆小於零?"+ result);
        }
        private static void DEMO04()
        {
            int[] items = new int[] { 1, -44, 58, 66, 12, 10, 55, 22, 33, 42, 6 };

            Console.WriteLine("總和:"+items.Sum());
            Console.WriteLine("小於十的總和:" + items.Where(x=>x<10).Sum());

            Console.WriteLine("小於十的總比數:" + items.Count(x => x < 10));
            Console.WriteLine("小於十的總比數#" + items.Where(x => x < 10).Count());

            Console.WriteLine("前三筆的平均數:"+items.Take(3).Average());
            Console.WriteLine("前三筆的平均數,顯示到小數以下兩位:" + items.Take(3).Average().ToString("f"));
            Console.WriteLine("前三筆的平均數,顯示到小數以下一位:" + items.Take(3).Average().ToString("f1"));
            Console.WriteLine("前三筆的平均數,顯示到小數以下三位:" + items.Take(3).Average().ToString("f3"));
            Console.WriteLine("前三筆的平均數,顯示到整數:" + items.Take(3).Average().ToString("f0"));

            Console.WriteLine("最大的數值:" + items.Max());
            Console.WriteLine("最小的數值:" + items.Min());

        }
        private static void DEMO05B()
        {
            int[] items = new int[] { 1, 2, 5 };

            
            string result = items.Select(x=>x.ToString()).Aggregate((acc, next) => acc + "," + next);
            Console.WriteLine(result);
        }
        private static void DEMO05()
        {
            string[] items = new string[] { "A", "B", "C", "ccccc" };
            string result = items.Aggregate((acc, next) => acc + "," + next);
            Console.WriteLine(result);
        }
        private static void DEMO06()
        {
            int[] items = new int[] { 1, 2, 5,44,88,45,66,67 };
            var secondPage = items.Skip(3).Take(3);

            foreach(var item in secondPage)
            {
                Console.WriteLine(item);
            }
            
        }

    }


}
