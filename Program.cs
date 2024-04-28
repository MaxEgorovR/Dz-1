
using System;

bool flag = true;
string choise, choise1, choise2, name, surname, age, length, mass, x1, y1, x2, y2, city;
int a, b;
Questionnaire questionnaire;
BestMethods bestMethods = new BestMethods();
while (flag)
{
    Console.WriteLine("1 - Continue\nElse - Exit");
    choise = Console.ReadLine();
    if (int.Parse(choise) == 1)
    {
        Console.WriteLine("1 - Task 1\n" + "2 - Task 2\n3 - Task 3\n4 - Task 4\n5 - Task 5\nElse - Task 6");
        choise1 = Console.ReadLine();
        if (int.Parse(choise1) == 1)
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            surname = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            age = Console.ReadLine();
            Console.WriteLine("Enter your length:");
            length = Console.ReadLine();
            Console.WriteLine("Enter your mass:");
            mass = Console.ReadLine();
            questionnaire = new Questionnaire(name, surname, int.Parse(age), double.Parse(length), double.Parse(mass));
            Console.WriteLine("1 - Output with concatenation\n2 - Output with placeholder\nElse - Output with interpolation");
            choise2 = Console.ReadLine();
            if (int.Parse(choise2) == 1)
            {
                questionnaire.infoWithUsingGluing();
            }
            else if (int.Parse(choise2) == 2)
            {
                questionnaire.infoWithUsingFormattedOutput();
            }
            else
            {
                questionnaire.infoWithUsingSimbol();
            }
        }
        else if (int.Parse(choise1) == 2)
        {
            Console.WriteLine("Enter your length:");
            length = Console.ReadLine();
            Console.WriteLine("Enter your mass:");
            mass = Console.ReadLine();
            questionnaire = new Questionnaire(double.Parse(length), double.Parse(mass));
            questionnaire.setBodyMassIndex();
        }
        else if (int.Parse(choise1) == 3)
        {
            Console.WriteLine("Enter the x 1: ");
            x1 = Console.ReadLine();

            Console.WriteLine("Enter the y 1: ");
            y1 = Console.ReadLine();

            Console.WriteLine("Enter the x 2: ");
            x2 = Console.ReadLine();

            Console.WriteLine("Enter the y 2: ");
            y2 = Console.ReadLine();
            Console.WriteLine(Range(double.Parse(x1), double.Parse(y1), double.Parse(x2), double.Parse(y2)));
        }
        else if (int.Parse(choise1) == 4)
        {
            Console.WriteLine("Enter the first num:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second num:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine($"First num: {a} Second num: {b}");
            (a, b) = (b, a);
            Console.WriteLine("After:");
            Console.WriteLine($"First num: {a} Second num: {b}");
        }
        else if (int.Parse(choise1) == 5)
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            surname = Console.ReadLine();
            Console.WriteLine("Enter your city:");
            city = Console.ReadLine();
            bestMethods.printCentral("Name: "+name+" Surname: "+surname+" City: "+city);
        }
        else { }
    }
    else
    {
        flag = false;
    }
}

double Range(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
class Questionnaire
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public int Age { get; set; }
    public double Length { get; set; }
    public double Mass { get; set; }
    public double bodyMassIndex { get; set; }

    public Questionnaire(string name, string surname, string city)
    {
        Name = name; 
        Surname = surname; 
        City = city;
    }
    public Questionnaire(double length,double mass)
    {
        Length = length;
        Mass = mass;
    }
    public Questionnaire(string name, string surname, int age, double length, double mass)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Length = length;
        Mass = mass;
    }

    public void infoWithUsingGluing()
    {
        Console.WriteLine("Name: " + Name + " Surname: " + Surname + " Age: " + Age + " Length: " + Length + " Mass: " + Mass);
    }

    public void infoWithUsingFormattedOutput()
    {
        Console.WriteLine("Name: {0} Surname: {1} Age: {2} Length: {3} Mass: {4}", Name, Surname, Age, Length, Mass);
    }

    public void infoWithUsingSimbol()
    {
        Console.WriteLine($"Name: {Name} Surname: {Surname} Age: {Age} Length: {Length} Mass: {Mass}");
    }
    public void setBodyMassIndex()
    {
        bodyMassIndex = Mass / (Length * Length);
        Console.WriteLine("BMI: {0:0.00}", bodyMassIndex);
    }
}

class BestMethods
{
    public void Print(string str)
    {
        Console.WriteLine(str);
    }

    public void printCentral(string str)
    {
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (str.Length / 2)) + "}", str));
    }
    public int ParseInt(string str)
    {
        return int.Parse(str);
    }

    public double ParseDouble(string str)
    {
        return double.Parse(str);
    }
}

