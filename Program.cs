using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        private int noofwheels;
        private string model;
       
        public int Noofwheels ///GETTER SETTER PRIVATE FIELDS
        {
            get { return noofwheels; }
            set { noofwheels = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
    }
    public abstract class Shape
    {
        public abstract double calculate_area(); ///ABSTRACTION METHODS DOESN'T HAVE A BODY
    }

    class Circle : Shape
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double calculate_area()
        {
            return Math.PI * (radius * radius);
        }
    }
    class Animal ///PARENT CLASS
    {
        public string zooname = "Safarii";

        public void Zoo()
        {
            Console.WriteLine("WELCOME TO SAFARI ZOO");
        }
        public void sound() ///PARENT CLASS METHOD
        {
            Console.WriteLine("WOOOOOOOOOOOOOOOOOOOOO");
        }
    }

    class Elephant : Animal  ///DERIVED CLASS
    {
        public string name = "Raniii";
        public void sound()
        {
            Console.WriteLine("MOOOOOOOOOOOOOOOOOOOOOOOOOOO");
        }
    }
    class Student
    {
        public string name; ///FIELD INITIALIZING IN C#
        public int age;
        public string course;
       public Student(string name,int age,string course) ///CONSTRUCTOR IN C#
        {
            this.name = name;
            this.age = age;
            this.course = course;
        }
        public void display()
        {
            Console.WriteLine($"Student name is {this.name} and enrolled in {this.course}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Aiman", 20, "Ds");
            s1.display();
            Console.WriteLine("INHERITANCE IN C#");
            Elephant e1 = new Elephant();
            Console.WriteLine($"{e1.name} lives in {e1.zooname}");
            e1.Zoo();
            Console.WriteLine("POLYMORPHISM IN C#");
           e1.sound();
            Console.WriteLine("ABSTRACTION IN C#");
            Circle c1 = new Circle(6.7);
            Console.WriteLine(c1.calculate_area());
            Console.WriteLine("GETTER SETTER IN C#");
            Car car1 = new Car();
            car1.Model = "Corolla";
            car1.Noofwheels = 4;
            Console.WriteLine($"CAR MODEL IS ${car1.Model} and no of wheels {car1.Noofwheels}");
        }
    }
}
