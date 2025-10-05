using Tyuiu.ZakachurinIE.Sprint2.Task1.V16.Lib;

namespace Tyuiu.ZakachurinIE.Sprint2.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт # 2 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Варинат #16                                                             *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: a = 145 b = 716 c = 144 d = 137                        *");
            Console.WriteLine("***************************************************************************");
            int a = 145;
            int b = 716;
            int c = 144;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("a = " + a );
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++ )
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}