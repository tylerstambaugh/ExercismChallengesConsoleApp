//main console app


using ExercismChallengesConsoleApp;

//var returnBytes = TelemetryBuffer.ToBuffer(Int32.MaxValue);
//Console.WriteLine(  returnBytes.ToList());
//for(int i = 0; i < returnBytes.Length; i++)
//{
//    Console.WriteLine(returnBytes[i]);
//}

//Console.ReadLine();

var lines = "The longest line.\n" + "A long line.\n" + "A longer line.\n" + "A line.";

Console.WriteLine(Transpose.String(lines));
Console.ReadLine();