using System;
using System.Text;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        //byte[] returnArray = new byte[];
        if (reading > 0 && reading < 65535)
        {
            long payload = reading; // Example integer to convert to bytes
            byte[] payloadBytes = BitConverter.GetBytes(payload); // Convert the integer to bytes
            byte payloadSize = (byte)payloadBytes.Length; // Determine the payload size

            byte[] byteArray = new byte[payloadSize + 1]; // Create the final byte array
            byteArray[0] = payloadSize; // Set the first byte to the payload size
            Array.Copy(payloadBytes, 0, byteArray, 1, payloadSize); // Copy the payload bytes to the final array

            // Print the byte array for verification
            Console.WriteLine(BitConverter.ToString(byteArray));
            return byteArray;
        }
        else
        {
            var returnArray =  BitConverter.GetBytes(reading);
            var returnArrayAsHex = ByteArrayToHexString(returnArray);
            return returnArray;
        }
    }


    static string ByteArrayToHexString(byte[] byteArray)
    {
        StringBuilder hex = new StringBuilder(byteArray.Length * 2);
        foreach (byte b in byteArray)
        {
            hex.AppendFormat("{0:X2}", b);
        }
        return hex.ToString();
    }

    public static long FromBuffer(byte[] buffer)
    {
        return BitConverter.ToInt64(buffer, 0);
    }
}
