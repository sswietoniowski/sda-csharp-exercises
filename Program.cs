using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasRequiredComplexity("abc"));
            Console.WriteLine(HasRequiredComplexity("aA$bbb1"));
        }

        private static bool HasRequiredComplexity(string password)
        {
            bool hasRequiredLength = password.Length >= 6;
            bool containsLowerCharacter = false;
            bool containsUpperCharacter = false;
            bool containsDigit = false;
            string specialCharacters = "&*$#";
            bool containsSpecialCharacter = false;
            foreach (char character in password.ToCharArray())
            {
                if (Char.IsLower(character))
                {
                    containsLowerCharacter = true;
                }

                if (Char.IsUpper(character))
                {
                    containsUpperCharacter = true;
                }

                if (Char.IsDigit(character))
                {
                    containsDigit = true;
                }

                if (specialCharacters.Contains(character))
                {
                    containsSpecialCharacter = true;
                }
            }

            return hasRequiredLength && containsLowerCharacter &&
                   containsUpperCharacter && containsDigit &&
                   containsSpecialCharacter;
        }
    }
}
