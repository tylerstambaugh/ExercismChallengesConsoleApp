//main console app


var car = RemoteControlCar.Buy();
var tc = new TelemetryClient(car);
var output = tc.GetBatteryUsagePerMeter(serialNum: 1);
Console.WriteLine($"{output}");

Console.ReadLine();