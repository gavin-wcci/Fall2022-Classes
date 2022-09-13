using Fall2022_Classes;

//creating a car with our default constructor
Car ashleysCar = new Car();

Console.WriteLine("Ashley has a " + ashleysCar.Make);

ashleysCar.IsPaidFor = true;

Console.WriteLine("This car is paid for? : " + ashleysCar.IsPaidFor);

var gavCarMake = "Toyota";

//creating another car with a different constructor
Car gavinsCar = new Car(gavCarMake, "Camry", "Grey", 2007);

Console.WriteLine("Gavin has a " + gavinsCar.Make);


//making a list of objects from out new class
var garage = new List<Car>();

//adding our cars to the list
garage.Add(ashleysCar);
garage.Add(gavinsCar);

//showing we can access those cars and their properties from our list
Console.WriteLine(garage[1].Model);