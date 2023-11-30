//#define CLASS_CONSOLE
//#define CONVERTION
//#define PURCHASE_COST 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CLASS_CONSOLE
            Console.WriteLine("Привет .Net");
            Console.WriteLine();
            Console.Beep(); 
#endif
            /*Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());*/

#if CONVERTION
            Console.WriteLine("Преобразование числа в денежный формат: ");
            Console.Write("Введите число: ");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"{number} руб, - это {(int)number} руб. {(number - (int)number) * 100} коп. "); 
#endif

#if PURCHASE_COST // Стоимость покупки
            Console.WriteLine("Вычесление стоимости покупки.");
            Console.WriteLine("Введите исходные данные: ");
            Console.Write("Цена тетради (руб.): "); decimal copybook = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Количество тетраде: "); int copybook_count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цена карандаешй(руб.): "); decimal pencil = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Количество карандашей: "); int pencil_count = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Стоимость тетрадей:{copybook * copybook_count} руб.");
            Console.WriteLine($"Стоимость тетрадей:{pencil * pencil_count}руб."); 
#endif
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
