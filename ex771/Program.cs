using System;
using System.Text.RegularExpressions;

namespace ex771 {
    class Program {
        private static bool IsValidFormat (string input) {
            return Regex.IsMatch (input, @"^[a-zA-Z]+$");
        }

        private static bool IsValidInput (string input) {
            return !(String.IsNullOrEmpty (input) || input.Length >= 50);
        }

        public static bool IsCheckingInput (string input) {
            if (!IsValidInput (input)) {
                System.Console.WriteLine ($"The Input({input}) must be alpha and the length({input.Length}) should not over 50 chars.");
                return false;
            }
            if (!IsValidFormat (input)) { 
                System.Console.WriteLine($"The Input({input}) is not valid format.");
                return false;
            }
            return true;
        }
        static void Main (string[] args) {
            System.Console.Write ("Input jewels :");
            var J = System.Console.ReadLine ();
            if (!IsCheckingInput (J)) return;
            System.Console.Write ("Input stones :");
            var S = System.Console.ReadLine ();
            if (!IsCheckingInput (S)) return;
            System.Console.WriteLine ($"Jewels : {J}, Stones : {S}");
            var solutions = new Solution ();
            var count = solutions.NumJewelsInStones (J, S);
            System.Console.WriteLine ($"Output : {count}");

        }
    }
}