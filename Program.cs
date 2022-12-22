internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter n1 && n2");
        int n1=int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        for(n1=n1;n1<=n2;n1++)
        {
            int max = 1;
            for(int i=2;i<n1;i++)
            {
                if(n1%i==0)
                {
                    max = 0;
                    break;
                }
            }

            if (max != 0)

                Console.WriteLine(n1+"  is prime ");
        }

    }
}