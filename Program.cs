// Контрольная работа №1.

/* Задача: Написать программу, которая из имеющегося массива 
строк формирует новый массив из строк, длина которых меньше,
либо равна 3 символам. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.*/

 
void Main()
{
    bool isWork = true;
    while (isWork)
    {
        Console.WriteLine("Введите команду:"); 
        Console.WriteLine("task1 - если хотите создать массив");
        Console.WriteLine("task2 - если выбираете заданный массив");
        Console.WriteLine(" out = закончить  ");
        string command = System.Console.ReadLine();
        switch (command)
        {
            case "task1":
                task1();
                break;
            case "task2":
                task2();
                break;
            case "out":
                isWork = false;
                break;
        }
    }
}
Main();

