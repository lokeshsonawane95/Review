namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Power of 2
            //a.Desc ­> This program takes a command­line argument N and prints a table of the
            //powers of 2 that are less than or equal to 2 ^ N.
            //b.I / P ­> The Power Value N.Only works if 0 <= N < 31 since 2 ^ 31 overflows an int
            //c.Logic ­> repeat until i equals N.

            Console.Write("Enter the power of 2 ( power must be in range 0 to 31 as it overflows int) : ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N >= 0 && N < 31)
            {
                Console.WriteLine("Table of 2 is :");
                for (int i = 0; i <= N; i++)
                {
                    Console.WriteLine("2^" + i + " : " + Math.Pow(2, i)); ;
                }
            }
            else
            {
                Console.WriteLine("Invalid input or range exceeded");
            }
        }
    }
}