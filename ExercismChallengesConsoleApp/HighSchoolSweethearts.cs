namespace ExercismChallengesConsoleApp
{
    public static class HighSchoolSweethearts
    {
        public static string DisplaySingleLine(string studentA, string studentB) => string.Format($"{studentA,29} ♡ {studentB,-29}");

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
            , string studentB, DateTime start, float hours) => $"{studentA} and {studentB} have been dating since {start.ToString("dd.MM.yyyy", new System.Globalization.CultureInfo("de-DE"))} - that's {hours.ToString("N2", new System.Globalization.CultureInfo("de-DE"))} hours";
    }
}
