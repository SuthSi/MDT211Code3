class Program
{
    static void Main(string[] args)
    {
        int z = 1, x = -1;
        CircularLinkedList<char> fruit = new CircularLinkedList<char>();
        Queue<char> queue = new Queue<char>();
        Console.Write("Input size : ");
        do{
            x++;
            fruit.Add(char.Parse(Console.ReadLine()));
            if(fruit.Get(x) != 'L' && fruit.Get(x) != 'M' && fruit.Get(x) != 'S')
            {
            z = 1;
            }

            else if(fruit.Get(x) == 'L')
            {
            queue.Push('1');
            z = 0;
            }

            else if(fruit.Get(x) == 'M')
            {
            queue.Push('2');
            z = 0;
            }

            else if(fruit.Get(x) == 'S')
            {
            queue.Push('3');
            z = 0;
            }
        }
        while(z == 0);

        int a = 0;
        int b = 0;
        while(a == 0)
        {
        for(b = 0; b < queue.GetLength(); b++)
        {
            if(queue.Get(b) == '1')
            {
              queue.Push('2');
              queue.Push('2');
            }
            else if(queue.Get(b) == '2')
            {
              queue.Push('3');
              queue.Push('3');
              queue.Push('3');
            }
        }
        for( b = 0; b < queue.GetLength(); b++)
        {
            Console.Write(queue.Get(b));
        }
            
            if(b == queue.GetLength())
            {
              a = 1;
            }
        }
    }
}