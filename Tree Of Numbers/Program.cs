using System;

namespace Tree_Of_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Give the n number: ");
            int n = Convert.ToInt32(Console.ReadLine());        // Creating n 

            CreatingTree(n);                                                   // Creating the Tree

        }

        static void CreatingTree(int n)
        {
            for (int i = 0; i < 100; i++) { Console.Write("*"); if (i == 99) { Console.WriteLine(); } }

            for (int r = n, b = 0; r >= 0; r--, b++)                      // r --> Rows left to print
            {                                                                           // b --> Starting number of Branches

                for (int w = r + 25; w > 0; w--)                            // w --> Number of White Spaces to print
                {
                    Console.Write(" ");
                }
                for (int x = -b; x <= b; x++)                              // Printing the created branches
                {
                    Console.Write(Math.Abs(x));
                }
                if (r == n / 2)                                                    // Printing the useless christmas message
                {                                                                     // in the middle of the tree
                    Console.Write("\t\tMerry Christmas~~");
                }
                Console.Write("\n");
            }
            for (int i = 0; i < 2; i++)
            {
                for (int y = n + 24; y >= 0; y--)                          // Creating the tree stalk (bg = stublo)
                {
                    Console.Write(" ");
                }
                Console.Write("0\n");
            }
            for (int i = 0; i < 100; i++) { Console.Write("="); }
        }

    }
}
