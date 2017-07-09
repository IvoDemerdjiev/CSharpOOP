using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAddMessage
{
    class RandomAddMessage
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]{"Продуктът е отличен.", "Това е страхотен продукт.", "Постоянно ползвам този продукт."
                ,"Това е най-добрият продукт от тази категория."};
            string[] events = new string[] { "Вече се чувствам добре.", "Успях да се променя.", "Той направи чудо."
                , "Не мога да повярвам, но вече се чувствам страхотно.", "Опитайте и вие. Аз съм много доволна."};
            string[] authorFIrstName = new string[] { "Диана ", "Петя ", "Стела ", "Елена ", "Катя " };
            string[] authorSecondName = new string[] { "Иванова ", "Петрова ", "Кирова " };
            string[] cities = new string[] { "София", "Пловдив", "Варна", "Русе", "Бургас" };
            Random random = new Random();
            int phrase = random.Next(0, phrases.Length);
            int eventt = random.Next(0, events.Length);
            int FirstName = random.Next(0, authorFIrstName.Length);
            int SecondName = random.Next(0, authorSecondName.Length);
            int city = random.Next(0, cities.Length);
            Console.Write(phrases[phrase]);
            Console.WriteLine(events[eventt]);
            Console.Write(authorFIrstName[FirstName]);
            Console.Write(authorSecondName[SecondName]);
            Console.WriteLine( "от "+cities[city]);
        }
    }
}
