namespace ExercismChallengesConsoleApp
{
    class RotationalCipher
    {
       public static readonly List<char> alphabetList = Enumerable.Range('a', 26).Select(x => (char)x).ToList();      

        public static string Rotate(string text, int shiftKey)
        {
            //build cipher, start at shiftkey -> end, then addRange beginning to shiftkey
            var cipherList = alphabetList.GetRange(shiftKey, alphabetList.Count);
            cipherList.AddRange(alphabetList.GetRange(0, shiftKey - 1));

            var returnText = "";

            returnText = (string)text.Select(c => cipherList[alphabetList.IndexOf(c)]);

            return returnText;
        }
    }
}
