// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. (Можно изучить метод Split. 
// Пример: stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);, где первый аргумент это разделитель чисел, второе обработчик введеной последовательности)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите через пробел все элементы: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int count = arr.Count(x => x > 0);
        Console.WriteLine($"Кол-во элементов больше ноля: {count}");
    }
}