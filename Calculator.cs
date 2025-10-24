using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("Введите два числа:");

        // Ввод первого числа
        Console.Write("Первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Ввод второго числа
        Console.Write("Второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nВыберите операцию:");
        Console.WriteLine("1. Сложение (+)");
        Console.WriteLine("2. Вычитание (-)");
        Console.WriteLine("3. Умножение (*)");
        Console.WriteLine("4. Деление (/)");
        Console.WriteLine("5. Остаток от деления (%)");
        Console.WriteLine("6. Инкремент первого числа (++)");
        Console.WriteLine("7. Декремент первого числа (--)");

        Console.Write("\nВведите номер операции (1-7): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Результат: {num1} + {num2} = {num1 + num2}");
                break;
            case "2":
                Console.WriteLine("Результат: {num1} - {num2} = {num1 - num2}");
                break;
            case "3":
                Console.WriteLine("Результат: {num1} * {num2} = {num1 * num2}");
                break;
            case "4":
                if (num2 != 0)
                {
                    Console.WriteLine("Результат: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                }
                break;
            case "5":
                Console.WriteLine("Результат: {num1} % {num2} = {num1 % num2}");
                break;
            case "6":
                Console.WriteLine("Результат: {num1} ++ = {num1 + 1}");
                break;
            case "7":
                Console.WriteLine("Результат: {num1} -- = {num1 - 1}");
                break;
            default:
                Console.WriteLine("Ошибка: Неверный выбор операции.");
                break;
        }        
    }         
}