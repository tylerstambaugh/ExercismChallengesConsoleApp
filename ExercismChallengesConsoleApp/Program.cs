//main console app


using ExercismChallengesConsoleApp;

var returnBytes = TelemetryBuffer.ToBuffer(Int32.MaxValue);
Console.WriteLine(  returnBytes.ToList());
for(int i = 0; i < returnBytes.Length; i++)
{
    Console.WriteLine(returnBytes[i]);
}

Console.ReadLine();