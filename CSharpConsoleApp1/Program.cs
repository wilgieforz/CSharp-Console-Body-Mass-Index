using System;
using System.Threading.Channels;

namespace CSharpConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления ИМТ");

            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в см");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес в кг");
            double weight = double.Parse(Console.ReadLine());

            double BodyMassIndex = weight / (height / 100 * height / 100);

            string Profile = $"Your profile: {Environment.NewLine}" +
                             $"Полное имя: {surname} {name} {Environment.NewLine}" +
                             $"Возраст: {age} {Environment.NewLine}" +
                             $"Вес: {weight} кг {Environment.NewLine}" +
                             $"Рост: {height} см {Environment.NewLine}" +
                             $"Ваш ИМТ: {BodyMassIndex}";

            Console.WriteLine(Profile);

            if (BodyMassIndex < 19)
            {
                Console.WriteLine("У Вас недостаточная масса тела");
            }
            else if ((BodyMassIndex > 19) && (BodyMassIndex <= 26))
            {
                Console.WriteLine("У Вас нормальная масса тела");
            }
            else if ((BodyMassIndex > 26) && (BodyMassIndex <= 30))
            {
                Console.WriteLine("У Вас избыточная масса тела");
            }
            else if (BodyMassIndex > 30)
            {
                Console.WriteLine("У Вас имеется ожирение");
            }

            //Console.ReadLine();
            
            return 0;
        }
    }
}