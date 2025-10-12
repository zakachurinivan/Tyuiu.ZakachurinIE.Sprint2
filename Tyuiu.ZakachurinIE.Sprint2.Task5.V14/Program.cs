using Tyuiu.ZakachurinIE.Sprint2.Task5.V14.Lib;

namespace Tyuiu.ZakachurinIE.Sprint2.Task5.V14
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
            Console.WriteLine("к-ый день = ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d-ый день недели 1 января=");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат");
            Console.WriteLine(ds.FindDayName(k, d));
        }
    }
}