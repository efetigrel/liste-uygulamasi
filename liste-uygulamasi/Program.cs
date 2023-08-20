

var sehirler = new List<string>()
{
    "Ankara",
    "Istanbul",
    "Van",
    "Samsun",
    "Ordu",

};

/*
    foreach (string s in sehirler)
    {                               -----> Bunun yerine alttakini kullan               
    Console.WriteLine(s); 
    }
*/

// Lamda expression
sehirler.ForEach(s => Console.WriteLine(s));


Console.WriteLine(new string('-',50)); 


var iller = sehirler;
iller.ForEach(i => Console.WriteLine(i));


Console.WriteLine(new string('-', 50));


sehirler.Add("Sinop");
sehirler.ForEach(s => Console.WriteLine(s));


Console.WriteLine(new string('-', 50));


iller.ForEach(i => Console.WriteLine(i));


Console.WriteLine(new string('-', 50));


iller.Remove("Ankara");
iller.ForEach(i => Console.WriteLine(i));


Console.WriteLine(new string('-', 50));


sehirler.ForEach(s => Console.WriteLine(s));



Console.ReadKey();