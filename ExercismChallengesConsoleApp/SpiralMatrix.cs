﻿using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        {
            //int[,] array = new int[4,2]; four rows and two columns

            int[,] returnArray = new int[size, size];
            int intSize = size * size;
            int loopNum = 1;
            int keyValue = 1;
            int i = 0;
            int j = 0;
            bool keepRunning = true;

            if(size == 1)
            {
                returnArray [0,0] = 1;
                return returnArray;
            }

            while (keepRunning)
            {
                //write row right to left
                while (j < size - loopNum)
                {
                    returnArray[i, j] = keyValue;
                    keyValue++;
                    j++;
                }

                while (i < size - loopNum)
                {
                    returnArray[i, j] = keyValue;
                    keyValue++;
                    i++;
                }

                while (j > (loopNum - 1))
                {
                    returnArray[i, j] = keyValue;
                    keyValue++;
                    j--;
                }

                while (i > (loopNum - 1))
                {
                    returnArray[i, j] = keyValue;
                    keyValue++;
                    i--;
                }
                j++;
                i++;
                loopNum++;

                if(size - loopNum == 1 && size % 2 != 0)
                {
                    returnArray[size / 2, size / 2] = keyValue;
                    keepRunning = false;
                    break;
                }

                keepRunning = keyValue <= intSize;
            }

            return returnArray;

        }
    }
}

