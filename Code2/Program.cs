class Program
{
    static void Main(string[] args)
    {
        Queue<int> Ss = new Queue<int>();
        Queue<int> Ms = new Queue<int>();
        Queue<int> Ls = new Queue<int>();
        Char Size = 'L';
        while(Size == 'S'|| Size == 'M'|| Size == 'L'){
            Size = Char.Parse(Console.ReadLine());
            if(Size == 'S'){
                Ls.Push(3);
            }
            else if(Size == 'M'){
                Ls.Push(2);
                for(int i = 0; i < 3; i++){
                    Ms.Push(2);
                }
            }
            else if(Size == 'M'){
                Ls.Push(2);
                for(int i = 0; i < 3; i++){
                    Ms.Push(2);
                }
            }
            else if(Size == 'L'){
                Ls.Push(1);
                for(int i = 0; i < 2; i++){
                    Ms.Push(2);
                }
                for(int i = 0; i < 6; i++){
                    Ss.Push(3);
                }
            }
        }
        
    }
    static void output(Queue<int> Ss,Queue<int> Ms,Queue<int> Ls)
    {
    Console.Write("---");
    for(int n =0; n<Ss.GetLength(); n++)
    {
        Console.Write("{0}",Ss.Get(n));
    }
    for(int n =0; n<Ms.GetLength(); n++)
    {
        Console.Write("{0}",Ms.Get(n));
    }
    for(int n =0; n<Ls.GetLength(); n++)
    {
        Console.Write("{0}",Ls.Get(n));
    }
    Console.WriteLine("");
    Console.WriteLine("Input : ");
    }
}