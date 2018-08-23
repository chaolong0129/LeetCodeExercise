using System;

namespace ex804UniqueMorseCodeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" }));
            Console.WriteLine(solution.UniqueMorseRepresentations(new string[] { "aittjje", "auyyn", "lqtktn", "lmjwn" }));
            Console.WriteLine(solution.UniqueMorseRepresentations(new string[] { "aittjje"}));

            Console.WriteLine(solution.UniqueMorseRepresentations2(new string[] { "gin", "zen", "gig", "msg" }));
            Console.WriteLine(solution.UniqueMorseRepresentations2(new string[] { "aittjje", "auyyn", "lqtktn", "lmjwn" }));
            Console.WriteLine(solution.UniqueMorseRepresentations2(new string[] { "aittjje" }));
            Console.ReadLine();
        }
    }
}
