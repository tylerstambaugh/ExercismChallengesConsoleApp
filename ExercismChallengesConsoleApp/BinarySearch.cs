namespace ExercismChallengesConsoleApp
{
    public static class BinarySearch
    {
        //Console.WriteLine(BinarySearch.Find(new[]{ 1, 3, 4, 5, 6, 8, 9, 11, 56, 65 }, 6));
        public static int Find(int[] input, int value)
        {
            int keyPosition = -1;
            bool keepSearching = true;
            int middleOfArrayIndex;
            int addr = 0;

            if (input.Length == 0)
                keepSearching = false;
            while (keepSearching)
            {
                //if input length is not even, put middleOfArrayIndex at 1/2 length 
                if (input.Length % 2 == 0)
                {
                    middleOfArrayIndex = input.Length / 2;
                }
                else
                {
                    middleOfArrayIndex = (input.Length / 2);
                }

                if (input[middleOfArrayIndex] == value)
                {
                    keyPosition = middleOfArrayIndex + addr;
                    keepSearching = false;
                }
                //return -1 if value is not found
                else if (input.Length == 1 && input[0] != value)
                {
                    keepSearching = false;

                }
                //make input array equal to left half of original array
                else if (input[middleOfArrayIndex] > value)
                {
                    input = input.Take(middleOfArrayIndex).ToArray();
                    keepSearching = true;
                }

                //make input array equal to right half of original array
                else if (input[middleOfArrayIndex] < value)
                {
                    input = input.Skip(middleOfArrayIndex).Take(input.Length - (middleOfArrayIndex - 1)).ToArray();
                    addr += middleOfArrayIndex;
                    keepSearching = true;
                }
            }
            return keyPosition;
        }

    }
}
