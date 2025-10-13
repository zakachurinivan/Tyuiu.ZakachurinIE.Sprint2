using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZakachurinIE.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15

    {
        public string FindDayName(int k)
        {
            switch ((k-1)%7+1)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: throw new ArgumentException($"Аргумент неверен. Значение {k}");
            } 
        }
    }
}
