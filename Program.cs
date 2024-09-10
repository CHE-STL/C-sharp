

Console.WriteLine("###THIS IS A CALCULATOR! (Whole numbers only)###");
// initial value of the first number
int firstNumber = 0;
// initial value of the second number 
int secondNumber = 0;
Console.WriteLine("Enter the first number:");
//create a place for the user to input their numbers
string userInput = Console.ReadLine();
Console.WriteLine("Enter the second number");
string userInput2 = Console.ReadLine();
//convert the strings into an ints using the Parse method
firstNumber = int.Parse(userInput);
secondNumber = int.Parse(userInput2);
//Add the numbers together 
int result = firstNumber + secondNumber;
//string itnterpolation is used below to add the variables into the string
Console.WriteLine($"The sum of {firstNumber} + {secondNumber} is {result}!");

Console.ReadKey();

 