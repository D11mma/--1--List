class Program 
{  
    static void Main()
    {
        List<int> list = new List<int>();
        Console.Write("Скільки чисел додати в список:");
        int n = int.Parse(Console.ReadLine());

        int k;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Введіть число:");
            k = int.Parse(Console.ReadLine());
            list.Add(k);
        }
        Console.Write("Список створено:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i] + " ");
        }

        Console.Write("Введіть індекс числа, яке бажаєте видалити:");
        k = int.Parse(Console.ReadLine());

        if (k >= 0 && k < n)
        {
            list.RemoveAt(k); // приймає номер позиції   
        }
        else
        {
            Console.Write("такої позиції не існує");
        }
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.ReadKey();
    }
}