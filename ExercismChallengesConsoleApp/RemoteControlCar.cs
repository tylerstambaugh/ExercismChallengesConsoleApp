//https://exercism.org/tracks/csharp/exercises/remote-control-cleanup/edit

using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using static RemoteControlCar;

public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }

    private Speed currentSpeed;
    public ITelemetry Telemetry { get; }

    public interface ITelemetry
    {
        public void Calibrate();
        public bool SelfTest();
        public void ShowSponsor(string sponsorName);
        public void SetSpeed(decimal amount, string unitsString);
    }

    public RemoteControlCar()
    {
        Telemetry = new RemoteControlCarTelemetry(this);
    }


    private class RemoteControlCarTelemetry : ITelemetry
    {
        private readonly RemoteControlCar _car;

        public RemoteControlCarTelemetry(RemoteControlCar car)
        {
            this._car = car;
        }
        public void Calibrate()
        {

        }

        public bool SelfTest()
        {
            return true;
        }



        public void ShowSponsor(string sponsorName)
        {
           _car.SetSponsor(sponsorName);
        }

        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps")
            {
                speedUnits = SpeedUnits.CentimetersPerSecond;
            }

            _car.SetSpeed(new Speed(amount, speedUnits));
        }
    }

    public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    private void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;

    }

    private void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }
}

internal enum SpeedUnits
{
    MetersPerSecond,
    CentimetersPerSecond
}

internal struct Speed
{
    public decimal Amount { get; }
    public SpeedUnits SpeedUnits { get; }

    public Speed(decimal amount, SpeedUnits speedUnits)
    {
        Amount = amount;
        SpeedUnits = speedUnits;
    }

    public override string ToString()
    {
        string unitsString = "meters per second";
        if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
        {
            unitsString = "centimeters per second";
        }

        return Amount + " " + unitsString;
    }
}
