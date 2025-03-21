namespace _21325s1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int h=int.Parse(Console.ReadLine());
            if(h<10||h>100)
            { Console.WriteLine("the number must be between 10 and 100");
                h = int.Parse(Console.ReadLine());
            }
                List<int> l=new List<int>();
            Stack<int> st=new Stack<int>();
            Queue<int> qu=new Queue<int>();
            Random r=new Random();
        
            for (int i=0;i<=h;i++) 
                {int n=r.Next(1,101);
                l.Add(n);
            
                if (n%2==0)
                {qu.Enqueue(n); }
                else{ st.Push(n);} }
           
            foreach (int n in l){Console.Write(" "+n);}
            Console.WriteLine();
            for(int i=0;i<qu.Count;i++)
            { Console.Write(qu.Dequeue()+" ");}
            for(int i=0;i<st.Count;i++)
            { Console.Write(st.Pop()+" ");}


        }

    }
}
