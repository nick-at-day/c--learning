// Convert f° to c°
// My solution:

int fahrenheit = 94;
Console.WriteLine("The temperature is " + ((decimal)fahrenheit-(decimal)32)*((decimal)5/(decimal)9) + " Celsius.");

// Suggested solution:

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");