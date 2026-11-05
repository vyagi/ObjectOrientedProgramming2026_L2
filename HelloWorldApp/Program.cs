const int numberOfNumbers = 5;
var numbers = new List<int>();

for (int i = 0; i < numberOfNumbers; i++)
{
    Console.WriteLine($"Enter number {i + 1}:");
    numbers.Add(int.Parse(Console.ReadLine()));
}

var sum = 0;
for (int i = 0; i < numberOfNumbers; i++)
    sum += numbers[i];

var average = 1.0 * sum / numberOfNumbers;
Console.WriteLine($"The sum is {sum} and the average is {average}");


//Task 10b
//const int numberOfNumbers = 5;

//int[] numbers = new int[numberOfNumbers];

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine($"Enter number {i + 1}:");
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//var sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//    sum += numbers[i];

//var average = 1.0 * sum / numberOfNumbers;
//Console.WriteLine($"The sum is {sum} and the average is {average}");




////Task 10
//Console.WriteLine("Enter the first number");
//var a = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the second number");
//var b = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the third number");
//var c = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the fourth number");
//var d = int.Parse(Console.ReadLine());

//var sum = a + b + c + d;
//var average = sum / 4.0;

//Console.WriteLine($"The sum is {sum} and the average is {average}");

//Task 8
//Console.WriteLine("Enter the length of side A:");
//double a = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the length of side B:");
//double b = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the length of side C:");
//double c = double.Parse(Console.ReadLine());

//double perimeter = a + b + c;
//double p = perimeter / 2;

//double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
//Console.WriteLine($"The area is {area} and perimeter is {perimeter}");




//Task 5
//Console.WriteLine("Please enter the radius:");

//double radius = double.Parse(Console.ReadLine());

//double area = Math.PI * Math.Pow(radius, 2);

//Console.WriteLine($"The area of the circle is {area}");

//Task 4
//Console.WriteLine("Please enter your name:");

//string name = Console.ReadLine();

//Console.WriteLine($"Hello {name}");

//3d
//string name = "Marcin";
//Console.WriteLine($"Hello {name}");


//3c
//Console.WriteLine(string.Format("Hello {0}", name));

//3b
//Console.WriteLine("Hello " + name);

//3a
//Console.Write("Hello ");
//Console.WriteLine(name);


//Task 2
//string name = "Marcin";
//Console.WriteLine(name);

//Task 1
//Console.WriteLine("Hello");
