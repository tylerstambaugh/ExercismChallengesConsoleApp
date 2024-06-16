//main console app


using ExercismChallengesConsoleApp;
using System.Text.Json;

var car = new RemoteControlCar();
string expected = "100 meters per second";
car.Telemetry.SetSpeed(100, "mps");

Console.WriteLine(car.GetSpeed());
Console.ReadLine();