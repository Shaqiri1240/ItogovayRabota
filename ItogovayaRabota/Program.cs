/*Задача: Написать программу, 
которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 
[“1234”, “1567”, “-2”, “computer science”] → [“-2”] 
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] arr1 = { "Hello", "2", "world", ":-)","1234","10","29" };
int size = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= 3)
    {
        size++;
    }
}

string[] NewArray(string[] array )
{   
    string[] arr2 = new string[size];
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    
        if (array[i].Length <= 3)
        {
         arr2[j] = array[i];
         j++;

        }
    return arr2;
}


void PrintArr2(string[] arrToPrint2)
{
    Console.Write("[");
    for (int i = 0; i < arrToPrint2.Length; i++)
    {
        Console.Write(arrToPrint2[i]);
        if (i != arrToPrint2.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

string[] Array = NewArray(arr1);

PrintArr2(Array);

