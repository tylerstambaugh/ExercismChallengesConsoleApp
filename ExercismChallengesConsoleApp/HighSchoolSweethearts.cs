namespace ExercismChallengesConsoleApp
{
    public static class HighSchoolSweethearts
    {
        public static string DisplaySingleLine(string studentA, string studentB)
        {
            return string.Format($"{studentA,29} ♡ {studentB,-29}");
        }

        public static string DisplayBanner(string studentA, string studentB)
        {
            string topArt = @"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **";

            string bottomArt = @"
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *";

            return $"{topArt}\n**     {studentA} +  {studentB}    **{bottomArt}";
        }

        public static string DisplayGermanExchangeStudents(string studentA
            , string studentB, DateTime start, float hours)
        {
            throw new NotImplementedException($"Please implement the (static) HighSchoolSweethearts.DisplayGermanExchangeStudents() method");
        }
    }
}
