//https://exercism.org/tracks/csharp/exercises/beauty-salon-goes-global/edit

using System;
using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc)
    {
        return dtUtc.ToLocalTime();
    }

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        DateTime returnDateTime = new DateTime();
        string format = "M/d/yyyy HH:mm:ss";

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            if (location == Location.NewYork)
            {
                returnDateTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.ParseExact(appointmentDateDescription, format, CultureInfo.InvariantCulture), TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
            }
            if (location == Location.London)
            {
                returnDateTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.ParseExact(appointmentDateDescription, format, CultureInfo.InvariantCulture), TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
            }
            if (location == Location.Paris)
            {
                returnDateTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.ParseExact(appointmentDateDescription, format, CultureInfo.InvariantCulture), TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"));
            }

        }
            
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            if (location == Location.NewYork)
            {
                returnDateTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.ParseExact(appointmentDateDescription, format, CultureInfo.InvariantCulture), TimeZoneInfo.FindSystemTimeZoneById("America/New_York"));
            }
            if (location == Location.London)
            {
                returnDateTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.ParseExact(appointmentDateDescription, format, CultureInfo.InvariantCulture), TimeZoneInfo.FindSystemTimeZoneById("Europe/London"));
            }
            if (location == Location.Paris)
            {
                returnDateTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.ParseExact(appointmentDateDescription, format, CultureInfo.InvariantCulture), TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris"));
            }
        }

        return returnDateTime;
    }



    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        DateTime returnDate = new DateTime();
        TimeSpan early = new TimeSpan(24, 0, 0);
        TimeSpan normal = new TimeSpan(1, 45, 0);
        TimeSpan late = new TimeSpan(0, 30, 0);
        switch(alertLevel)
        {
            case AlertLevel.Early:
                returnDate = appointment - early;
                break;

            case AlertLevel.Standard:
                returnDate = appointment - normal;
                break;

            case AlertLevel.Late:
                    returnDate = appointment - late;
                break;

            default:
                throw new ArgumentException();
        }

        return returnDate;
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        bool returnBool = false;
        TimeSpan week = new TimeSpan(7, 0, 0, 0);

        switch(location)
        {
            case Location.London:
                if ((TimeZoneInfo.FindSystemTimeZoneById("Europe/London").IsDaylightSavingTime(dt - week) !=
                    TimeZoneInfo.FindSystemTimeZoneById("Europe/London").IsDaylightSavingTime(dt)))
                    returnBool = true;
                break;
            case Location.Paris:
                if ((TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris").IsDaylightSavingTime(dt - week) !=
                    TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris").IsDaylightSavingTime(dt)))
                    returnBool = true;
                break;
            case Location.NewYork:
                if ((TimeZoneInfo.FindSystemTimeZoneById("America/New_York").IsDaylightSavingTime(dt - week) !=
                    TimeZoneInfo.FindSystemTimeZoneById("America/New_York").IsDaylightSavingTime(dt)))
                    returnBool = true;
                break;
            default:
                throw new ArgumentException();
        }
        return returnBool;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.NormalizeDateTime() method");
    }
}
