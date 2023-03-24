﻿//https://exercism.org/tracks/csharp/exercises/beauty-salon-goes-global/edit

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
        throw new NotImplementedException("Please implement the (static) Appointment.GetAlertTime() method");
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.HasDaylightSavingChanged() method");
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.NormalizeDateTime() method");
    }
}
