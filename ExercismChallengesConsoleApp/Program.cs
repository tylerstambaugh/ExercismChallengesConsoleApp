//main console app

using ExercismChallengesConsoleApp;

WeighingMachine wm = new WeighingMachine(4);

wm.TareAdjustment = 10.0;
wm.Weight = 100.770M;

Console.WriteLine(wm.DisplayWeight);
Console.ReadLine();