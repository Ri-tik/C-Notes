
namespace FirstProgram  //The namespace keyword is used to declare a scope that contains a set of related objects.
{
	class Program
	{
		static void Main(string[] args)  // static as it should be called directly by name, and void as it should not return anything, and The string[] args is a variable that has all the values passed from the command line that we can further use for ex: args.Length
		{
			int a = 2;
			double height = 300.5;
			bool alive = true;
			float b = 2.2;
			char symbol = '@'; //Single Quotes
			string name = "Bro"; //Double Quotes
			
			const double PI = 3.14;   //Immutable values which are known at compile time, and cannot be changed throghout the program
			
			Console.Write("Hey");     //Outputs without newline at end
			Console.WriteLine("Hello");     //Outputs with newline at end
			Console.ReadKey();     //For Single Character Input
		}
	}
}

Output: HeyHello

> SingleLine Comment: //Hello

> Multine Comment: /*Hello This is Comment */

> When Some Methods only Returns Some Specific Information without performing any actions: They're generally without () brackets
Ex: String.Length

> When Some Methods performs some actions and then returns the applied action: They're with () brackets
Ex: String.ToUpper(), String.Insert(0,"")

---------------!---------------

>TypeCasting

double a = 3.14;
int b = Convert.ToInt32(a);  //3
Console.WriteLine(b.GetType());  //System.Int32

int a = 2;
double b = Convert.ToDouble(a);  //2.0
Console.WriteLine(b.GetType());  //System.Double

int a = 320;
string b = Convert.ToString(a);  //"320"
Console.WriteLine(b.GetType());  //System.String

string a = "$";
char b = Convert.ToChar(a);   //'$'
Console.WriteLine(b.GetType());   //System.Char

string a = "true";
char b = Convert.ToBoolean(a);   //true
Console.WriteLine(b.GetType());   //System.Boolean

---------------!---------------

>User Input

Console.WriteLine("Whats Your Name");
string name = Console.ReadLine();

//To Convert The Default String Input To Integer
Console.WriteLine("Whats Your Age");
int age = Convert.ToInt32(Console.ReadLine());

---------------!---------------

>Math Class

double x = 3;
double y = 3.14;
Console.WriteLine(Math.Pow(x, 2));  //x to the power 2 i.e 3^2 = 9

Math.Sqrt(9);  //3
Math.Abs(-2);  //2
Math.Round(3.14);  //3 rounds to nearest unit value
Math.Ceiling(3.14);  //4  rounds to Upper value
Math.Floor(3.99);  //3 rounds to Lower value

Math.Max(x,y);  //3.14
Math.Min(x,y);  //3


---------------!---------------


>Random Class

Random random = new Random();

int num = random.Next(1,7); //Next() generates random whole integer between 1 to 6

double num = random.NextDouble();  //random number of type double 


---------------!---------------


>String Class Method

string name = "Bro";
string phone = "123-456-7890";

name.ToUpper();  //BRO
name.ToLower();  //bro

phone = phone.Replace('-','/');  //123/456/7890

string userName = name.Insert(0,"@");  //@Bro

name.Length;  //3


string fullName = "Bro Code";
string firstName = fullName.Substring(0,3);  //Syntax: Substring(index,length after index)
string lastName = fullName.Substring(4,4); 


---------------!---------------


>Array

//Fixed Size Array

string[] cars = new string[3];

//Dynamic Size Array

string[] cars = {"BMW", "Tesla", "Mustang"};
cars[0];  //BMW

cars[0]="Audi";  //Changed from bmw to audi


---------------!---------------


> ForEach Loop

foreach(string car in cars)
{
	Console.WriteLine(car);   //audi tesla mustang each in newline
}


---------------!---------------


> Param Keyword  //( a method parameter that takes a variable number of arguments)

static double CheckOut(params double[] prices)
{
	double total = 0;
	foreach ( double price in prices)
	{
		total+=price;
	}
	return total;
}

double total = CheckOut(3.99,4.5,5.6,7.8,8.9,5.1,1.7); //any number of arguments can be passed


---------------!---------------


> Exception

try
{
	Console.WriteLine(2/0);
}
catch(DivideByZeroException e)
{
	Console.WriteLine("Cannot divide by 0");
}
catch(Exception e)
{
	Console.WriteLine(e);
}
finally   //always executes at end
{
	Console.WriteLine("Thanks!");
}


---------------!---------------


> Ternary Operator // (condition) ? x : y

double temp = 20;

message = (temp >=15) ? "Its Warm" : "Its Cold";   //O.P: 'Its Warm'


---------------!---------------


> String Interpolation

String fName = "Bro";
String lName = "Code";
int age = 21;

Console.WriteLine($"Hello {fName} {lName} and your age is {age}");  //O.P: Hello Bro Code and your age is 21


//To Allocate Spaces 

Console.WriteLine($"Your Age {age,5} old");  //O.P: You Age      21 old
Console.WriteLine($"Your Age {age,5} old");  //O.P: You Age 21      old


---------------!---------------


> MultiDimensional Array  // [row][column]

String[,] parking = {{"A","B"},
					 {"C","D"},
					 {"E","F"}};

parking[0,1]  // B

for(int i=0; i<parking.GetLength(0);i++)  //GetLength(dimension number) 0=row,1=column 
{
	for(int j=0; j<parking.GetLength(1);j++)
	{
		Console.WriteLine(parking[i,j]);
	}
}


---------------!---------------


> Constructor

class Car
{
	string model,color;
	int year;
	
	public Car(string model, string color, int year)
	{
		this.model = model;
		this.color = color;
		this.year = year;
	}
	
	publci void Drive()
	{
		Console.WriteLine("You're Driving "+model);
	}
}

class Program
{
	static void Main(string[] args)
	{
		Car car = new Car("Mustang","Black",2022);
		car.Drive();   //O.p: You're Driving Mustang
	}
}


---------------!---------------

> Static Modifier  // Static member belongs to a class itself rather to an object

// If Class is static then all method and variable has to be static

~Ex1: //Static Class
 
static Class Message 
{ 
	static msg = "";
	static void Hello()
	{	
	} 
}

Message.Hello(); //Have to be accessed by name of class, cannot create objects


~Ex2: //Static Variable & Method //can also be used to count number of objects created of class

class Car
{
	string name;
	public static int noOfCars;
	
	public Car(string name)
	{
		this.name = name;
		noOfCars++;
	}
	
	public static Start()
	{
		Console.WriteLine("Race Started");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Car car1 = new Car("Mustang");
		Car car2 = new Car("Ferrari");
		Car car3 = new Car("Audi");
		Console.WriteLine(Car.noOfCars);   //O.p: 3  //Count of no. of object created 
		Car.Start();
		//Accessed not by object but by class since its a member of a class only
	}
}


---------------!---------------


> Overloaded Constructor  //Used for instantiating a class with different set of parameters


class Program
{
	static void Main(string[] args)
	{
		Pizza pizza = new Pizza("stuffed crust","red sauce","mozzarella","pepperoni"); //Pizza with all attributes
		Pizza pizza = new Pizza("stuffed crust","red sauce","mozzarella"); // Cheese pizza without Topping 
	}
}

class Pizza
{
	string bread,sauce,cheese,topping;
	
	public Pizza(string bread, string sauce, string cheese, string topping)
	{
		this.bread=bread;
		this.sauce=sauce;
		this.cheese=cheese;
		this.topping=topping;
	}
	
	public Pizza(string bread, string sauce, string cheese)
	{
		this.bread=bread;
		this.sauce=sauce;
		this.cheese=cheese;
		this.topping=topping;
	}
	
	public Pizza(string bread, string sauce)
	{
		this.bread=bread;
		this.sauce=sauce;
		this.cheese=cheese;
		this.topping=topping;
	}
}



---------------!---------------

> Abstract Class // A modifier that indicates missing components or incomplete implementation

//Cannot create objects of the abstract class
// You have to implement this class by inheriting it

abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound()
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}

---------------!---------------

> Array of objects
//Similar to how we were creating an Array of strings,int,etc we can create array of objects.
// string[] arr = new string[5]; OR string[] arr = {"A","B"};

class Car
{
	string name;
	public Car(string name)
	{
		this.name = name;
	}
}

Car[] garage = new Car[3];
Car car1 = new Car("Mustang");
Car car2 = new Car("BMW");

garage[0] = car1;
garage[1] = car2;

garage[0].name //Mustang

OR
Car[] garage = {new Car("Mustang"), new Car("BMW")};  //you can directly intantiate the class inside array


---------------!---------------

> Objects as argument  //passing Object as a parameter

//Ex for Changing Car color

class Car
{
	string name,color;
	public Car(string name, string color)
	{
		this.name = name;
		this.color = color;
	}
}

class Program
{
	//This is the method which we can use by passing a Car object and a color to change that objects i.e cars color.
	public static void ChangeColor(Car car, string color)
	{
		car.color = color;
	}
	
	Car car1 = new Car("BMW","Red");
	car1.color;  //Red
	
	ChangeColor(car1,"Black");
	car1.color;  //Black	
}

//Example 2: To create a copy of car object

public static Car Copy(Car car)
{
	return new Car(car.model, car.color);
}

//So now if we want to create a copy of car1 object, we can do:
Car car2 = Copy(car1);


---------------!---------------

> Method Overriding
//provides a new version of a method inherited from a parent class
//Inherited method must be abstract, virtual or already overriden

class Animal
{
	public virtual void Speak()
	{
		Console.WriteLine("Animal Speaks *brrr*");
	}
}

class Dog : Animal
{
	public override void Speak()
	{
		Console.WriteLine("Dog Speaks *woof*");
	}
}

class Cat : Animal
{
	public override void Speak()
	{
		Console.WriteLine("Cat Speaks *meow*");
	}
}

Dog dog = new Dog();
dog.Speak();  
//Dog Speaks *woof* 
//Animal Speaks *brrr*
cat.Speak();
//Dog Speaks *woof* 
//Cat Speaks *meow*


---------------!---------------

> ToString() Method
//converts an object to its string representation so that it is suitable for display

//Before Overriding
class Car
{
	string name,color;
	public Car(string name, string color)
	{
		this.name = name;
		this.color = color;
	}
}

Car car = new car("BMW","Red");
Console.WriteLine(car.ToString());  //Program.Car

//After Overriding
class Car
{
	string name,color;
	public Car(string name, string color)
	{
		this.name = name;
		this.color = color;
	}
	public override string ToString()
	{
		return $"This is a {name} and its color is {color}";
	}
}

Car car = new car("BMW","Red");
Console.WriteLine(car.ToString());  //This is a BMW and its color is Red


---------------!---------------

> Interface
// defines a contract that all the classes inheriting should follow:
// 1. An interface declares "what a class should have"
// 2. An inheriting class defines "how it should do it"

interface IPrey
{
	void Flee();
}

interface IPredator
{
	void Hunt();
}

class Rabbit : IPrey
{
	public void Flee()
	{
		Console.WriteLine("The Rabbit flees away");
	}
}

class Hawk : IPredator
{
	public void Hunt()
	{
		Console.WriteLine("The Hawk is searching for food");
	}
}

class Fish : IPrey, IPredator      //It *must* implement the interface methods
{
	public void Flee()
	{
		Console.WriteLine("The Fish Swims away");
	}
	public void Hunt()
	{
		Console.WriteLine("The F is searching for smaller fish");
	}
}


Rabbit rabbit = new Rabbit();
rabbit.Flee();  //The Rabbit flees away

Fish fish = new Fish()
fish.Flee();  //The Fish Swims away
fish.Hunt();  //The Fish is searching for smaller fish



---------------!---------------

> List  //Included in System.Collections.Generic

List<string> food = new List<string>();
//List Methods
food.Add("Pizza");
food.Add("Burger");
food.Add("Fries");
food.Add("Pizza"));

// ["Pizza","Burger","Fries","Pizza"]

food.Remove("Fries");  //["Pizza","Burger","Pizza"]

food.Insert(0, "Sushi");  //["Sushi","Pizza","Burger","Pizza"]

food.Count;  //4

food.IndexOf("Pizza");  //1

food.LastIndexOf("Pizza");  //3

food.Contains("Pizza");  //True

food.Sort();  //Sorts a list

food.Reverse();  //Sorts in reverse order

food.Clear();  //Empties the list, removes every item from a list

String[] foodArray = food.ToArray();  //{"Sushi","Pizza","Burger","Pizza"}



---------------!---------------

> Getters & Setters // adds security to fields by encapsulation / use to set or access the value of private members

class Car
{
	private int speed;
	
	public Car(int speed)
	{
		Speed = speed;
	}
	
	public int Speed
	{
		get { return speed };
		set { speed = value };
	}
}

OR

class Car
{
	public string Speed {get; set;}
}

Car car = new Car();
car.Speed = 500;
car.Speed  //500


---------------!---------------

> Enum 
//Special class that contains a set of named integer constants.
//Use enum when you have values that will not change.
//To get the integer value from an item, you must explicitly convert to an int

enum Planets
{
	Mercury,
	Venus,
	Earth,
	Mars,
	Jupiter,
	Saturn,
	Uranus,
	Neptune
}

Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
//Mercury is planet #0

//Ex2
enum PlanetsRadius
{
	Mercury=2439,
	Venus=2554,
	Earth=3555,
	Mars=44455,
	Jupiter=5444,
	Saturn=4446,
	Uranus=88887,
	Neptune=8848
}

Console.WriteLine(Planets.Mercury.ToString() + " is planet with radius " + (int)PlanetsRadius.Mercury);
//Mercury is planet with radius 2439

//Ex3
public static double Volume(PlanetRadius radius)
{
	return 3.14*(int)radius;
}

Volume(PlanetRadius.Earth);


---------------!---------------

>Generic
//Not specific to a particular data type, allows for code reusability for different data types
//add <T> to classes, methods, fields, etc.

int[] intArray = {1,2,3};
double[] doubArray = {1.0, 2.0, 3.0};
string[] strArray = {"1","2","3"};

public static void displayElements<Things>(Things[] array)
{
	foreach(Things item in array)
	{
		Console.WriteLine(item);
	}
}

displayElements(intArray);
displayElements(doubArray);


---------------!---------------

> MultiThreading
//An execution path of a program
//we can use multiple threads to perform, different tasks of our program at the same time
//current thread running is "main" thread
//using System.Threading;

public static void CountDown()
{
	for(int i=3;i>0;i--)
	{
		Console.WriteLine(i);
		Thread.Sleep(1000);
	}
	Console.WriteLine("Timer 1 is Complete");
}

public static void CountUp()
{
	for(int i=0;i>=3;i++)
	{
		Console.WriteLine(i);
		Thread.Sleep(1000);
	}
	Console.WriteLine("Timer 2 is Complete");
}

static void main(string args[])
{
	Thread mainThread = Thread.CurrentThread;
	mainThread.Name = "Main Thread";
	mainThread.Name; //Main Thread
	
	CountDown();
	CountUp();
	Console.WriteLine("Main Timer is Complete");
}

//OP
3
2
1
Timer 1 is Complete
0
1
2
3
Timer 2 is Complete
Main Timer is Complete
//

//If want to run thread simultaneously

Thread thread1 = new Thread(CountDown);
Thread thread2 = new Thread(CountUp);
thread1.Start();
thread2.Start();

//Now it'll run simultaneously
//OP
3
0
2
1
...


---------------!---------------






















