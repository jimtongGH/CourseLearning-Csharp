// According to class PDF 7 02_revision
using System;
namespace CourseLearning;
// Main
class MyClass
{
    static void Main()
    {
        // 1 Hello, World!
        Console.WriteLine("Hello, World!");

        // 2 Types and Variables
        // Value types and reference types
        int i = 1;
        object o = i; // boxing
        int j = (int)o; // unboxing
        Console.WriteLine("i:" + i);
        Console.WriteLine("o:" + o);
        Console.WriteLine("j:" + j);
        
        // 3 Classes and Objects
        StackArray sa = new StackArray();
        Console.WriteLine("IsEmpty:" + sa.IsEmpty());
        sa.Push(9);
        Console.WriteLine("size:" + sa.Size());
        sa.Push(8);
        Console.WriteLine("size:" + sa.Size());
        sa.Push(7);
        Console.WriteLine("size:" + sa.Size());
        Console.WriteLine("IsEmpty:" + sa.IsEmpty());
        Console.WriteLine("size:" + sa.Size());
        Console.WriteLine("Pop:" + sa.Pop());
        Console.WriteLine("size:" + sa.Size());
        
        // 6 Inheritance
        // 6.1 Sigle inheritance
        SubB.Print();
        // 6.2 Multiple inheritance
        Bird bird = new Bird();
        bird.Speak();
        bird.Fly();
        // 6.3 Root Class
        RCTest rcTest = new RCTest();
        rcTest.ToString();
        rcTest.Equals(0);
        rcTest.GetHashCode();
        
        // 7 Polymorphism
        // 7.1.1 Static Binding + Method Overriding
        Animal animal1 = new Dog();
        animal1.Speak();
        Dog dog = new Dog();
        dog.Speak();
        Animal animal2 = new Cat();
        animal2.Speak();
        Cat cat = new Cat();
        cat.Speak();
        
        // 7.1.2 Dynamic Binding 
        Animal myPet;
        //myPet = new Dog();
        myPet = new Cat();
        myPet.Speak();
        
        // 7.2 Exercise
        // 7.2.1 Static Binding + Method Overriding
        Polygon polygon1 = new Triangle();
        Console.WriteLine(polygon1.GetArea());
        Polygon polygon2 = new Rectangle();
        Console.WriteLine(polygon2.GetArea());
        Polygon polygon3 = new Hexagon();
        Console.WriteLine(polygon3.GetArea());
        
        // 7.2.2 Dynamic Binding
        Polygon myPolygon;
        // myPolygon = new Triangle();
        // myPolygon = new Rectangle();
        myPolygon = new Hexagon();
        Console.WriteLine(myPolygon.GetArea());
        
        // 7.3 Overloading
        int a = 2;
        double aa = 3.5;
        float b = 4.5f;
        Display();
        Display(a);
        Display(aa);
        Display(a, b);
    }
    
    // 3 Classes and Objects
    public class StackArray
    {
        private int size;
        private int[] a;
        private const int max = 100;

        public StackArray()
        {
            a = new int[max];
            size = 0;
        }
    
        public bool IsEmpty()
        {
            return size == 0;
        }
    
        public void Push(int x)
        {
            a[size] = x;
            size += 1;
        }
    
        public int Pop()
        {
            size -= 1;
            return a[size];
        }
    
        public int Size()
        {
            return size;
        }
    }
    
    // 4 Messages
    // informative message
    // iterrogative message
    // imperative message
    
    // 5 Class
    
    // 6 Inheritance
    // 6.1 Sigle inheritance
    class SuperA
    {
        public static void Print()
        {
            Console.WriteLine("SuperA");
        }
    }

    class SubB : SuperA;
    
    // 6.2 Multiple inheritance
    interface IAnimal { void Speak(); }
    interface IFly { void Fly(); }
    
    class Bird : IAnimal, IFly
    {
        public void Speak()
        {
            Console.WriteLine("Bird Speak");
        }
        
        public void Fly()
        {
            Console.WriteLine("Bird Fly");
        }
    }
    
    // 6.3 Root Class
    // Object class
    class RCTest {}

    // 7 Polymorphism
    // 7.1.1 Static Binding + Method Overriding
    class Animal
    {
        public virtual void Speak() { Console.WriteLine("Animal Speak"); }
    }

    class Dog : Animal
    {
        public override void Speak() { Console.WriteLine("Dog Bark"); }
    }

    class Cat : Animal
    {
        public override void Speak() { Console.WriteLine("Cat Meow"); }
    }
    // 7.1.2 Dynamic Binding
    
    // 7.2 Exercise
    // 7.2.1 Static Binding + Method Overriding
    class Polygon
    {
        private int area;

        public virtual int GetArea()
        {
            return area;
        }
    }
    
    class Triangle : Polygon { public override int GetArea() { return 3; } }
    class Rectangle : Polygon { public override int GetArea() { return 4; } }
    class Hexagon : Polygon { public override int GetArea() { return 6; } }
    
    // 7.2.2 Dynamic Binding
    
    // 7.3 Overloading
    static void Display() { Console.WriteLine("void Display 1: void"); }
    static void Display(int a) { Console.WriteLine("void Display 2: int " + a); }
    static float Display(double a) { Console.WriteLine("float Display 1: double " + a); return (float)a; }
    static float Display(int a, float b) { Console.WriteLine("float Display 2: int " + a + " float " + b); return a + b; }
}

