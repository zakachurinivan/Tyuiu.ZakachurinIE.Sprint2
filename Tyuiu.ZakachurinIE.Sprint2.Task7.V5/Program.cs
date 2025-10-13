using Tyuiu.ZakachurinIE.Sprint2.Task7.V5.Lib;

namespace Tyuiu.ZakachurinIE.Sprint2.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт # 2 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Варинат #5                                                              *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* и вычисляет, находится ли точка в заштрихованной области.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("Введите значение X=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y=");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат");
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
        }
    }
}