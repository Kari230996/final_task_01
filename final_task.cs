/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. 
*/

string[] array_1 = { "hello", "2", "world", ":-)" };
string[] array_2 = { "1234", "1567", "-2", "computer science" };
string[] array_3 = { "Russia", "Denmark", "Kazan" };


void PrintArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]}  ");

    }
    Console.WriteLine();

}

void FinalArray(string[] array)
{
    foreach (var i in array)
    {
        if (i.Length <= 3)
        {
            //Console.Write($"{i} ");
            Console.Write($"{i} ");
        }

    }
    Console.WriteLine();

}

PrintArray(array_1);
FinalArray(array_1);
Console.WriteLine();
PrintArray(array_2);
FinalArray(array_2);
Console.WriteLine();
PrintArray(array_3);
FinalArray(array_3);



