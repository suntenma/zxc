using System.IO;
using System.Text;
namespace zxc
{
    class Program
    {
        public static double a;
        public static double b;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\tПрограмма реализует следующие пункты." +
                    "\n1. Ввод чисел a и b." +
                    "\n2. Сложить числа" +
                    "\n3. Вычесть числа" +
                    "\n4. Разделить чимло a на b" +
                    "\n5. Возвести число a в степень b" +
                    "\n6. Выход");
                int choise = 0;
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        EnterNum();
                        break;
                    case 2:
                        AddNum();
                        break;
                    case 3:
                        SubNum();
                        break;
                    case 4:
                        DivNum();
                        break;
                    case 5:
                        ExpNum();
                        break;
                    case 6:
                        Console.WriteLine("\tЗавершение программы ...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Такие цифры мы не знаем :(");
                        break;
                }
            }

        }
        public static void EnterNum()
        {
            Console.WriteLine("Ввод числа a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввод числа b:");
            b = Convert.ToDouble(Console.ReadLine());
        }
        public static void AddNum()
        {
            double c = a + b;
            Console.WriteLine($"a + b = {c}");
        }
        public static void SubNum()
        {
            double c = a - b;
            Console.WriteLine($"a - b = {c}");
            double c2 = b - a;
            Console.WriteLine($"b - a = {c2}");
        }
        public static void DivNum()
        {
            double c = a / b;
            Console.WriteLine($"a : b = {c}");
            double c2 = b / a;
            Console.WriteLine($"b : a = {c2}");
        }
        public static void ExpNum()
        {
            double c = Math.Pow(a, b);
            Console.WriteLine($"a^b = {c}");
            double c2 = Math.Pow(b, a);
            Console.WriteLine($"b^a = {c2}");
        }
    }
}
