//main console app


using ExercismChallengesConsoleApp;

var dt = new DateTime(2030, 07, 25, 13, 45, 0);
var tzi = TimeZoneInfo.Local;
var offset = tzi.GetUtcOffset(dt);
Console.WriteLine($"dt + offest= {dt + offset}, appt local time = {Appointment.ShowLocalTime(dt)}");

var scheduledAppt = Appointment.Schedule("7/25/2019 08:45:00", Location.NewYork);
var scheduledAppt2 = Appointment.Schedule("7/25/2019 13:45:00", Location.London);
var scheduledAppt3 = Appointment.Schedule("7/25/2019 14:45:00", Location.London);

Console.WriteLine($"1: {scheduledAppt}, 2: {scheduledAppt2}, 3: {scheduledAppt3}");

Console.ReadLine();