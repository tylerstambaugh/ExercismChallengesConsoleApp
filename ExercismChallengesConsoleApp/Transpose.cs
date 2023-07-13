namespace ExercismChallengesConsoleApp
{
    public static class Transpose
    {
        public static string String(string input)
        {
            List<string> listOfStrings = GetListOfStrings(input);
            List<string> paddedListOfStrings = PadStrings(listOfStrings);

            return TransposeFromList(paddedListOfStrings);
        }

        public static int GetCountOfLines(string s)
        {
            int countOfLines;

            if (s.Length == 0)
                countOfLines = 0;
            else
            {
                countOfLines = 1;
                foreach (char c in s)
                {
                    if (c == '\n')
                        countOfLines++;
                }
            }
            return countOfLines;
        }

        public static List<string> GetListOfStrings(string input)
        {
            List<string> returnList = new List<string>();

            int stringLength = input.Length;
            int index = 0;
            string stringToAdd = "";
            while (index <= stringLength)
            {
                if (index < stringLength)
                {
                    if (input.Substring(index, 1) != "\n")
                        stringToAdd += input.Substring(index, 1);
                }

                if (index < stringLength)
                {
                    if (input.Substring(index, 1) == "\n")
                    {
                        returnList.Add(stringToAdd);
                        stringToAdd = "";
                    }
                }

                if (index == stringLength)
                {
                    returnList.Add(stringToAdd);
                }
                index++;
            }
            return returnList;
        }

        public static string TransposeFromList(List<string> listOfStrings)
        {
            string returnString = "";

            for (int i = 0; i < listOfStrings[0].Length; i++)
            {
                int stringIndex = 0;
                while (stringIndex < listOfStrings.Count)
                {
                    returnString += listOfStrings[stringIndex].Substring(i, 1);
                    stringIndex++;
                }
                if (i < listOfStrings[0].Length - 1)
                    returnString += "\n";
            }
            return returnString;
        }

        public static List<string> PadStrings(List<string> listOfStrings)
        {
            List<string> paddedListOfStrings = new List<string>();

            //get longest string length
            int longestStringLength = listOfStrings[0].Length;

            for (int i = 0; i < listOfStrings.Count - 1; i++)
            {
                if (listOfStrings[i + 1].Length > longestStringLength)
                    longestStringLength = listOfStrings[i + 1].Length;
            }

            //pad each string with " " so it is same length as longest string
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                while (listOfStrings[i].Length < longestStringLength)
                {
                    listOfStrings[i] += " ";
                }
                paddedListOfStrings.Add(listOfStrings[i]);
            }
            return paddedListOfStrings;
        }
    }
}

