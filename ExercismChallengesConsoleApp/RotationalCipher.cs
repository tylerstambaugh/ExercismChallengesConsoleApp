namespace ExercismChallengesConsoleApp
{
    class RotationalCipher
    {
        public static List<char> lowerAlphabetList = new List<char>
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

        public static List<char> upperAlphabetList = new List<char>
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
        public static string Rotate(string text, int shiftKey)
        {
            var cipherList = lowerAlphabetList.GetRange(shiftKey, lowerAlphabetList.Count - shiftKey).ToList();
            cipherList.AddRange(cipherList.GetRange(0, shiftKey));
            var upperCipherlist = upperAlphabetList.GetRange(shiftKey, upperAlphabetList.Count - shiftKey).ToList();
            upperCipherlist.AddRange(upperCipherlist.GetRange(0, shiftKey));
            cipherList.AddRange(upperCipherlist);

            lowerAlphabetList.AddRange(upperAlphabetList);

            var fullAlphabetlist = lowerAlphabetList;


            var returnText = new string(CipherText(text.ToLower(), fullAlphabetlist, cipherList).ToArray());


            return returnText;
        }

        public  static IEnumerable<char> CipherText(string text, List<char> alphabetList, List<char> cipherList)
        {
            foreach (char c in text)
            {
                int index = alphabetList.IndexOf(c);
                if (index >= 0)
                {
                    yield return cipherList[index];
                }
                else
                {
                    yield return c;
                }
            }
        }
    }
}
