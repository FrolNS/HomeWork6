/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
void printArray(int[] arrayFromUser)
{
    Console.Write("[");
    for (int i = 0; i < arrayFromUser.Length; i++)
    {
        Console.Write(arrayFromUser[i]);
        if (i < arrayFromUser.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int countPositiveNumbers(int[] finalArray)
{
    int count = 0;
    for (int i = 0; i < finalArray.Length; i++)
    {
        if (finalArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива M");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массив");
int[] userArray = new int[length];
for (int i = 0; i < length; i++)
{
    userArray[i] = Convert.ToInt32(Console.ReadLine());
}
printArray(userArray);
int result = countPositiveNumbers(userArray);
Console.WriteLine($"Пользователь ввел {result} чисел больше 0.");