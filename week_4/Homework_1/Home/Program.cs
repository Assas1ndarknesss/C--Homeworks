// using Infrastructure;

// Computer computer = new Computer("Samsung",10000,2024);
// computer.Work();
// computer.ShowInfo();

// System.Console.WriteLine();

// Laptop laptop = new Laptop("Dell",4000,2023);
// laptop.AnotherJob();
// laptop.ShowInfo();

// System.Console.WriteLine();

// Smartphone smartphone = new Smartphone("Redmi Note 13 Pro",2400,2020);
// smartphone.Get("USA");
// smartphone.Smart();
// smartphone.ShowInfo();

using Infrastructure;

Transport transport = new Transport("Vazik",2000,200);
transport.Show();
transport.About();

System.Console.WriteLine();

Auto auto = new Auto("Bmw",4000,320);
auto.Show();
auto.Show("Black");

System.Console.WriteLine();

LightweightCars car = new LightweightCars("Tiko",1000,180);
car.GetShow("Dubai");
car.Show();

System.Console.WriteLine();

OverWeight Volvo = new OverWeight("Volvo Kamaz",400000,120);
Volvo.GetShow("12 people");
Volvo.Show();

System.Console.WriteLine();

Plane plane = new Plane("Tajik Air",1000000,1000);
plane.MyJob();
plane.GetInforms("Sport","Bill Gayst");
plane.ShowPlane();
plane.Show();

System.Console.WriteLine();

Passenger passenger = new Passenger("Welconiya",600000,800);
passenger.Show();
passenger.travelway("Brazil","China");

System.Console.WriteLine();

CargoPlane cargoPlane = new CargoPlane("Laconiya",700000,900);
cargoPlane.Show();
cargoPlane.mycargo("Shoes");