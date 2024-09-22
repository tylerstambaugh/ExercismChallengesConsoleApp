//main console app


using ExercismChallengesConsoleApp;
using System.Text.Json;

var cipher = new RotationalCipher();

var cirBuf = new CircularBuffer<int>(1);

cirBuf.Write(1);
cirBuf.Write(2);
var result = cirBuf.Read();