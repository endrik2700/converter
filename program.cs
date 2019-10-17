using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hi! What do you want to convert? If celsius,, type a, if fahrenheir type b");
		string userChoice= Console.ReadLine();
		Console.WriteLine("Enter the number to be converted!");
	   double userInput = double.Parse(Console.ReadLine());
}
	public static Double (double nr) {
		double temperature;
		if ( userChoice == "a") {
		 userChoice = "Celsius";
		}
		else {
			userChoice = "Fahrenheit";
		}
		if (userChoice == "Celsius") 
			
		{
			temperature = userInput*9/5+32;
		}
		return temperature;
	}					 
}
