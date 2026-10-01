using System.Diagnostics.CodeAnalysis;

Random rng = new Random();

//Part 1 Input
System.Console.WriteLine("What is your full name? ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();


//Formatting mumbo jumbo
string nameCaps = " ";
nameCaps = fullName.ToUpper();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string firstInitial = fullName.Substring(0, 1);
string lastInitial = fullName.Substring(spacePosition + 1, 1);
int lengthOfLast = fullName.Substring(spacePosition + 1).Length;

// Part 1 Output
System.Console.WriteLine("Name on badge: " + nameCaps);
System.Console.WriteLine("Username: " + firstName.ToLower() + lastName.ToLower());
System.Console.WriteLine("Initials: " + firstInitial.ToUpper() + "." + lastInitial.ToUpper() + ".");
System.Console.WriteLine("Letters in last name: " + lengthOfLast);
System.Console.WriteLine(" ");

//Part 2
double studentID = rng.Next(100000, 1000000);
double lockerNumber = rng.Next(1, 501);

System.Console.WriteLine("Student ID: " + studentID);
System.Console.WriteLine("Locker: " + lockerNumber);

//Part 3 Input (dorm)
System.Console.WriteLine("What is the X value of your dorm? ");
double dormX = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("What is the Y value of your dorm? ");
double dormY = Convert.ToDouble(Console.ReadLine());

//Part 3 Input (class)
System.Console.WriteLine("What is the X value of your class? ");
double classX = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("What is the Y value of your class? ");
double classY = Convert.ToDouble(Console.ReadLine());

//Distance formula
double parenthesisOne = classX - dormX;
double halfOne = Math.Pow(parenthesisOne,2);

double parenthesisTwo = classY - dormY;
double halfTwo = Math.Pow(parenthesisTwo, 2);

double halvesAdded = halfOne + halfTwo;
//Need to format this as one decimal point
double finalDistance = Math.Sqrt(halvesAdded);

System.Console.WriteLine("Distance: ");