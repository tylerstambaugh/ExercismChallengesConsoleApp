//main console app


using ExercismChallengesConsoleApp;

//var returnBytes = TelemetryBuffer.ToBuffer(Int32.MaxValue);
//Console.WriteLine(  returnBytes.ToList());
//for(int i = 0; i < returnBytes.Length; i++)
//{
//    Console.WriteLine(returnBytes[i]);
//}

//Console.ReadLine();

List<int> nums = new List<int>() { 0, 4, 9, 152, -56 };

foreach(int i in nums)
{
    Console.WriteLine($"steps for {i} = {CollatzConjecture.Steps(i)}");
}
Console.ReadLine();