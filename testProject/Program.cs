namespace testProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("My Name is Hanas Bayu Pratama and I love girl that have character like xaviera putri");

            //int a = 13;
            //int b = 22;
            //if (a > b)
            //{
            //    Console.WriteLine("a is greater than b");
            //}
            //else
            //{
            //    Console.WriteLine("a is less than b");
            //}

            //Console.WriteLine(17 == 17);

            //Console.WriteLine("Tambahan");
            //for (int i = 1; i <= 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\n");

            //Console.WriteLine("Pengurangan");
            //for (int i = 20; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Outer loop
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Outer: " + i); //Executes 2 Times

                //Inner loop
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }
        }
    }
}
