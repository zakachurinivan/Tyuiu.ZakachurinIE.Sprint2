using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZakachurinIE.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            int dennedeli = (d - 1 + (k - 1)) % 7 + 1;
                string res;
                switch (dennedeli)
                {
                    case 1:
                        res = "Понедельник";
                        break;
                    case 2:
                        res = "Вторник";
                        break;
                    case 3:
                        res = "Среда";
                        break;
                    case 4:
                        res = "Четверг";
                        break;
                    case 5:
                        res = "Пятница";
                        break;
                    case 6:
                        res = "Суббота";
                        break;
                    case 7:
                        res = "Воскресенье";
                        break;
                default:
                    throw new ArgumentException($"Укажите день от 1 до 365. Значение {k}. Укажите день недели 1 января от 1 до 7. {d}");
                }
                return res; 
            
        }
        
    }
}
