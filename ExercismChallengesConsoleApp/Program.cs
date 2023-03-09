//main console app



var car = RemoteControlCar.Buy();
car.SetSponsors("Exercism", "Walker Industries", "Acme Co.");

var sp1 = car.DisplaySponsor(sponsorNum: 0);
var sp2 = car.DisplaySponsor(sponsorNum: 1);
var sp3 = car.DisplaySponsor(sponsorNum: 2);

Console.WriteLine($"{sp1}");
Console.WriteLine($"{sp2}");
Console.WriteLine($"{sp3}");

Console.ReadLine();