//https://exercism.org/tracks/csharp/exercises/armstrong-numbers
namespace ExercismChallengesConsoleApp
{

    public static class ArmstrongNumbers
    {
        public static bool IsArmstrongNumber(int number)
        {
            int charCount = number.ToString().Length;
            string numberString = number.ToString();
            double total = 0;

            for(int i = 0; i < charCount; i++)
            {
                int digit = int.Parse(numberString[i].ToString());
                total += Math.Pow(digit, charCount);
            }

            return total == number;
        }
    }
}
