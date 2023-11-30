using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            string expression = Console.ReadLine();
            string[]numbers = expression.Split('+','-','*','/');
            double operand_1 = Convert.ToDouble(numbers[0]);
            double operand_2 = Convert.ToDouble(numbers[1]);
            if (expression.Contains('+')) Console.WriteLine($"{operand_1} + {operand_2} = {operand_1 + operand_2}");    
            else if (expression.Contains('-')) Console.WriteLine($"{operand_1} - {operand_2} = {operand_1 - operand_2}");    
            else if (expression.Contains('*')) Console.WriteLine($"{operand_1} * {operand_2} = {operand_1 * operand_2}");    
            else if (expression.Contains('/')) Console.WriteLine($"{operand_1} / {operand_2} = {operand_1 / operand_2}");
        }
    }
}
