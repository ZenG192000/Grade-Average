// See https://aka.ms/new-console-template for more information
double number1, number2, number3, number4;

Console.Write("Enter the Prelim Grade: ");
number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Midterm Grade: ");
number2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the PreFinal Grade: ");
number3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Final Grade: ");
number4 = Convert.ToDouble(Console.ReadLine());

double result = (number1 + number2 + number3 + number4) / 4;
Console.WriteLine("Your average is " + result);
