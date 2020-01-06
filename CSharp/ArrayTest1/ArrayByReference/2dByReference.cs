using System;
namespace TwoDByReference
{
    class TwoDByReference
    {
        public static void DisplayArray(string[,] month)
        {
            int i, j;
            Console.WriteLine($"Calendar");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write($"{month[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public static void LoadArray(string[,] month)
        {
            string[] days = { "Sun", "Mon" , "Tue" , "Wed" , "Thu" , "Fri" , "Sat"  }; 
            int i, j;
            int date = 1;
            for (i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    for (j = 0; j < 7; j++)
                    {
                        month[i, j] = days[j];
                    }
                }
                else
                {
                    for (j = 0; j < 7; j++)
                    {
                        month[i, j] = date++.ToString("n0");
                        
                    }
                }
            }
        }

        public static void Main()
        {
            string[,] month = new string[5, 7];

            LoadArray(month);
            DisplayArray(month);
            Console.ReadKey();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
