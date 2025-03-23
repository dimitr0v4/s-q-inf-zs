namespace _21325s2
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter a number");
            int h = int.Parse(Console.ReadLine());
            if (h < 5 || h > 55)
            {
                Console.WriteLine("the number must be between 5 and 55");
                h = int.Parse(Console.ReadLine());
            }
            Stack<int> st = new Stack<int>();
            
            int pc = h;
            for (int i = 0; i < h; i++)
            { st.Push(ReFib(pc));
                pc--;
            }

            for (int i = 0; i < h; i++)
            { Console.WriteLine(st.Pop()); }


        }

        private static int ReFib(int n)
        { if (n == 0)
                return 0;
            else if (n == 1 )
                return 1;
            else { return (ReFib(n - 1) + ReFib(n - 2)); }
        }
    }
}
