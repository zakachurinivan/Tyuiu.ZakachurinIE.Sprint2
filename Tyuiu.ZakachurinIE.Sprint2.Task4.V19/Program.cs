using Tyuiu.ZakachurinIE.Sprint2.Task4.V19.Lib;

namespace Tyuiu.ZakachurinIE.Sprint2.Task4.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт # 2 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Варинат #19                                                             *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение тернарным опера*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("Введите X =");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y =");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат=");
            Console.WriteLine(ds.Calculate(x, y));
        }
    }
}