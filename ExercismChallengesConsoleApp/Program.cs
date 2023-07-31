//main console app


using ExercismChallengesConsoleApp;

//var returnBytes = TelemetryBuffer.ToBuffer(Int32.MaxValue);
//Console.WriteLine(  returnBytes.ToList());
//for(int i = 0; i < returnBytes.Length; i++)
//{
//    Console.WriteLine(returnBytes[i]);
//}

//Console.ReadLine();

//var lines = "The longest line.\n" + "A long line.\n" + "A longer line.\n" + "A line.";

//Console.WriteLine(Transpose.String(lines));
//Console.ReadLine();
var array = new object[]
        {
            1,
            new object[]
            {
                2,
                3,
                4,
                5,
                6,
                7
            },
            8
        };

var flatArry = FlattenArray.Flatten(array);
Console.WriteLine("array01:");
foreach (var item in flatArry)
{
    Console.WriteLine(item);
}
Console.ReadLine();
array = new object[]
{
            1,
            new object[] { 2, new object[] { new object[] { 3 } }, new object[] { 4, new object[] { new object[] { 5 } } }, 6, 7 },
            8
};

flatArry = FlattenArray.Flatten(array);
Console.WriteLine("array 1:");
foreach (var item in flatArry)
{
    Console.WriteLine(item);
}
Console.ReadLine();

array = new object[]
{
            1,
            null,
            null,
            4
};

flatArry = FlattenArray.Flatten(array);
Console.WriteLine("array 2:");
foreach (var item in flatArry)
{
    Console.WriteLine(item);
}
Console.ReadLine();