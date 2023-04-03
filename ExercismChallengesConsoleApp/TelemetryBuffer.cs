using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] returnArray = new byte[];
        if (reading > 0 && reading < 65535)
        {
            returnArray =  BitConverter.GetBytes((int)reading);
            return returnArray;
        }
        else
        {
            return BitConverter.GetBytes(reading);
        }
    }

    public static long FromBuffer(byte[] buffer)
    {
       return BitConverter.ToInt64(buffer, 0);
    }
}
