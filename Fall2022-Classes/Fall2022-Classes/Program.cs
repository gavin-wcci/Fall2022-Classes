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

//see the effects of the Accelerate method
//Speed by default is 0
Console.WriteLine(gavinsCar.Speed);
gavinsCar.Accelerate(); //up to 5 from 0
Console.WriteLine(gavinsCar.Speed);
gavinsCar.Accelerate(); //up to 10 from 5
Console.WriteLine(gavinsCar.Speed);
//use of our overloaded Accelerate method
gavinsCar.Accelerate(7); //up to 17 from 10
Console.WriteLine(gavinsCar.Speed);
var timeToDrive = gavinsCar.TimeToTravelDistance(500);
Console.WriteLine(timeToDrive);

//calling our static method from Car.cs
//Note this only works by calling the class, not an instance of the class (aka an object)
Car.Honk();
