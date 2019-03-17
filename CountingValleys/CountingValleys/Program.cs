using System;

namespace CountingValleys
{
    class Program
    {
        static int CountingValleys(string s)
        {
            int valleys = 0;
            int level = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U' && level == -1)
                {
                    valleys++;
                    level++;
                }
                else if (s[i] == 'D')
                {
                    level--;
                }
                else if (s[i] == 'U')
                {
                    level++;
                }
            }

            return valleys;
        }

        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Hacker Rank Counting Valleys Solution in C#\r");
            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine("steps taken on hike represented by U for Up and D for Down to determine how many valleys were traversed");
            Console.WriteLine("provide console with string represting steps taken, for example UUDDDU");
            Console.WriteLine("this string represents two steps up, three steps down and then one final step up");
            Console.WriteLine("\r");

            while (!endApp)
            {
                Console.WriteLine("steps taken: ");
                string s = Console.ReadLine();

                int result = CountingValleys(s);
                Console.WriteLine("number of valleys traversed: {0:0.##}\n", result);

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;
            }
        }
    }
}
