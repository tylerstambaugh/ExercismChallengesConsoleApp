//https://exercism.org/tracks/csharp/exercises/building-telemetry/edit

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

public class RemoteControlCar2
{
    private int batteryPercentage = 100;
    private int distanceDrivenInMeters = 0;
    private string[] sponsors = new string[0];
    private int latestSerialNum = 0;

    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            batteryPercentage -= 10;
            distanceDrivenInMeters += 2;
        }
    }

    public void SetSponsors(params string[] sponsors)
    {
        this.sponsors = sponsors;

    }

    public string DisplaySponsor(int sponsorNum)
    {
        return this.sponsors[sponsorNum];
    }

    public bool GetTelemetryData(ref int serialNum,
        out int batteryPercentage, out int distanceDrivenInMeters)
    {
        if (serialNum < latestSerialNum)
        {
            serialNum = this.latestSerialNum;
            batteryPercentage = -1;
            distanceDrivenInMeters = -1;
            
            return false;
        }
        else
        {
            this.latestSerialNum = serialNum;
            batteryPercentage = this.batteryPercentage;
            distanceDrivenInMeters = this.distanceDrivenInMeters;
            return true;
        }
    }

    public static RemoteControlCar2 Buy()
    {
        return new RemoteControlCar2();        
    }
}

public class TelemetryClient
{
    private RemoteControlCar2 car;

    public TelemetryClient(RemoteControlCar2 car)
    {
        this.car = car;
    }

    public string GetBatteryUsagePerMeter(int serialNum)
    {
        return (car.GetTelemetryData(ref serialNum, out int batteryPercentage, out int distanceDrivenInMeters) && distanceDrivenInMeters != 0) ?
            $"usage-per-meter={(100 - batteryPercentage) / distanceDrivenInMeters}"
            : "no data";        
    }
}
