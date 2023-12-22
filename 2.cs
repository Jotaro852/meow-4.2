using System;
using System.IO;
class work_4_2
{
    static void Main()
    {
        string file = "numsTask2.txt"; // читаем файл
        string[] fileNumbers = File.ReadAllText(file).Split(';'); // разделяем числа по символу
        float sum = 0; // сумма

        foreach (string i in fileNumbers)
        {
            if (float.TryParse(i, out float number)) // float.TryParse - попытка преобраз. в сторку. out float number - i сохраняеться в number
            {
                if (number > 0)
                {
                    sum += number; // складываем
                }
                else
                {
                    Console.WriteLine($"Сумма положительный чисел: {sum}"); // вывод
                    break;
                }
            }
        }
    }

} 