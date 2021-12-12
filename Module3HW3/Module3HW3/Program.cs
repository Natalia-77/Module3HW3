using System;

namespace Module3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var class1 = new Class1();
            var class2 = new Class2();
            var program = new Program();
            class1.Action += program.Show;
            Func<int, int, int> func = (a, b) => class1.Pow(a, b);
            var res = class2.Calc(func, 10, 2);
            var flag = res.Invoke(3);
            class1.Action.Invoke(flag);
        }

        public void Show(bool result)
        {
            if (!result)
            {
                Console.WriteLine("Result false");
            }
            else
            {
                Console.WriteLine("Result true");
            }
        }
    }
}
