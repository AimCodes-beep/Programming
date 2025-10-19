using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Person
        
    {
        public string name;
        public int age;
        public string email;
        public Person(string name1,int age1,string email1)
        {
            name = name1;
            age= age1;
            email = email1;
        }
        public void Message()
        {
            Console.WriteLine("HELLO OOPS IN C#");
        }

       
    }
    class Vehicle
    {
        public int wheels;
        Vehicle(int wheel)
        {
            wheels = wheel;
        }
        public void honk()
        {
            Console.WriteLine("TCHHH TCH!!!!!!!!!");
        }

    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Aiman", 20, "aimanmemon417@gmail.com");
            Console.WriteLine($"Person name is {p1.name} and his/her age is {p1.age} and email is {p1.email}");
            p1.Message();

        }
    }
}
