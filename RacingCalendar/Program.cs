
using System.ComponentModel.Design;

var races = new List<Race>();
var race1 = new Race("Race1", "01/01/2019", "Track1");
var race2 = new Race("Race2", "01/02/2019", "Track2");
var race3 = new Race("Race3", "01/03/2019", "Track3");
races.Add(race1);
races.Add(race2);
races.Add(race3);
race1.AddDriver(new Driver { Name = "Driver1" });
race1.AddDriver(new Driver { Name = "Driver2" });   
race1.AddDriver(new Driver { Name = "Driver3" });
race1.AddDriver(new Driver { Name = "Driver4" });
race1.AddDriver(new Driver { Name = "Driver5" });
race1.AddDriver(new Driver { Name = "Driver6" });
race1.AddDriver(new Driver { Name = "Driver7" });
race1.AddDriver(new Driver { Name = "Driver8" });
race1.AddDriver(new Driver { Name = "Driver9" });
race1.AddDriver(new Driver { Name = "Driver10" });
race1.AddDriver(new Driver { Name = "Driver11" });
race1.AddDriver(new Driver { Name = "Driver12" });

Console.WriteLine(races.Count());
Console.WriteLine(race1.Drivers.Count());
Console.WriteLine(race1.Drivers2.Count());
//Console.WriteLine(race1.Drivers2.Pop().Name);


foreach (var race in races)
{
    Console.WriteLine($"\nRace info: "+race.ToString());
}






public class Race
{
    public Race(string name, string date, string trackName)
    {
       Name = name;
        Date = date;
        TrackName = trackName;
    }
    public string Name { get; set; }
    public string Date { get; set; }
   
    public string TrackName { get; set; }

    public override string ToString()
    {
        return $"{Name} {Date} {TrackName}";
    }
    public List<Driver> Drivers;
    public Stack<Driver> Drivers2 = new Stack<Driver>();

    public void AddDriver(Driver driver)
    {
        try
        {
            if (Drivers == null )
            {
                Drivers = new List<Driver>();
            }
            if (Drivers.Count >= 20)
            {
                throw new Exception("Max 20 drivers allowed");
            }
            Drivers.Add(driver);
            Drivers2.Push(driver);
            Console.WriteLine($"Driver {driver.Name} added");
          
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
      
    }

   
}

public class Driver
{
    /*public Driver(string name)
    {
        Name = name;
    }
    */
    public string Name { get; set; }
}


