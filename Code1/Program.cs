class Program
{
    static void Main(string[] args)
    {
        int z = 1, x = -1;
        CircularLinkedList<char> flower = new CircularLinkedList<char>();
        do{
            x++;
            flower.Add(char.Parse(Console.ReadLine()));
            char bunch = flower.Get(flower.GetLength()-1);
        if(bunch != 'J' && bunch != 'G' && bunch != 'O' && bunch != 'R')
        {
            flower.Remove(x);
            x--;
            z = 2;
        }
        else if(flower.Get(x) == 'R' && flower.GetLength() == 1)
        {
            {
            Console.WriteLine("Ivalid pattern",flower.Get(x));
            x--;
            }
        }
        else if(flower.Get(0) == 'R')
        {
            flower.Remove(0);
        }
        else if(flower.Get(x) == 'R' && flower.GetLength() > 1)
            {
                if(flower.Get(x-1) == 'R')
                {
                Console.WriteLine("Ivalid pattern");
                flower.Remove(x);
                x--;  
                }
                
                else if(flower.Get(x+1) == flower.Get(x-1) && flower.GetLength() > 3) 
                {
                Console.WriteLine("Ivalid pattern");
                flower.Remove(x);
                x--;  
                }
                else z = 1;
            }

        else if(flower.Get(x) == 'J' && 
        flower.Get(x-1) == 'R' && 
        flower.Get(x-2) == 'J'&& 
        flower.GetLength() > 2)
            {
            Console.WriteLine("Ivalid pattern");
            flower.Remove(x);
            x--; 
            }
            
        else if(flower.Get(x) == 'O' && 
        flower.Get(x-1) == 'R' && 
        flower.Get(x-2) == 'O'&& 
        flower.GetLength() > 2)
            {
            Console.WriteLine("Ivalid pattern");
            flower.Remove(x);
            x--; 
            }

        else if(flower.Get(x) == 'G' && 
        flower.Get(x-1) == 'R' && 
        flower.Get(x-2) == 'G' && 
        flower.GetLength() > 2)
            {
            Console.WriteLine("Ivalid pattern");
            flower.Remove(x);
            x--; 
            }

        else if(flower.Get(x) == 'G' && 
        flower.GetLength() > 3)
            {
            if(flower.Get(x-1) == 'G' && 
            flower.Get(x-2) == 'G' && 
            flower.Get(x-3) == 'G')
                {
                Console.WriteLine("Ivalid pattern");
                flower.Remove(x);
                x--;
                }

            else if(flower.Get(x+1) == 'G' && 
            flower.Get(x+2) == 'G' && 
            flower.Get(x+3) == 'G')
                {
                Console.WriteLine("Ivalid pattern");
                flower.Remove(x);
                x--;
                }

            else if(flower.Get(x-1) == 'G' && 
            flower.Get(x+1) == 'G' && 
            flower.Get(x+2) == 'G')
                {
                Console.WriteLine("Ivalid pattern");
                flower.Remove(x);
                x--;
                }

            else if(flower.Get(x-2) == 'G' && 
            flower.Get(x-1) == 'G' && 
            flower.Get(x+1) == 'G')
                {
                Console.WriteLine("Ivalid pattern");
                flower.Remove(x);
                x--;
                }
            else z = 1;
            }
        else z = 1;
        }

        while(z == 1);
        for (int i = 0; i < flower.GetLength(); i++) 
        {
        Console.Write(flower.Get(i));
        }
    }
}