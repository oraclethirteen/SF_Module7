using System;

namespace SF_Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* (VII) [7.2.5]
            DerivedClass obj = new DerivedClass();
            obj.Display();
            */

            /* (XIII) [7.5.3]
            int num1 = 3;
            int num2 = 58;

            Helper.Swap(ref num1, ref num2);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            */

            /* (X) [7.5.9]
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative());
            Console.WriteLine(num1.GetPositive());
            Console.WriteLine(num2.GetNegative());
            Console.WriteLine(num2.GetPositive());
            Console.WriteLine(num3.GetNegative());
            Console.WriteLine(num3.GetPositive());
            */
        }
    }

    /* (I) [7.1.4]
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectKManager : Employee
    {
        public string ProjectName;
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage;
    }
    */

    /* (II) [7.1.5]
    class Food { }

    class Fruit : Food { }

    class Apple : Fruit { }

    class Banana : Fruit { }

    class Pear : Fruit { }

    class Vegetable : Food { }

    class Potato : Vegetable { }

    class Carrot : Vegetable { }
    */

    /* (III) [7.1.6]
    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }
    */

    /* (IV, V, VII) [7.1.10, 7.2.3, 7.2.5]
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
    */

    /* (VI) [7.2.4]
    class BaseClass
    {
        private int counter;
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        private int counter;

        public override int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                if (value >= 0)
                {
                    counter = value;
                }
            }
        }
    }
    */

    /* (VIII) [7.2.7]
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }

    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }

    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }

    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }
    */

    /* (IX) [7.2.12]
    class Obj
    {
        public int Value;

        public static Obj operator + (Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }

        public static Obj operator - (Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }
    */

    /* (X) [7.2.14]
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            private set
            {
                array[index] = value;
            }
        }
    }
    */

    /* (XI) [7.3.3]
    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work() { }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work() { }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work() { }
    }
    */

    /* (XII, IX) [7.5.2, 7.5.5]
    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
    */

    /* (XIII) [7.5.3]
    class Helper
    {
        public static void Swap(ref int num1, ref int num2)
        {
            int num3 = num2;
            num2 = num1;
            num1 = num3;
        }
    }
    */

    /* (XIV) [7.5.9]
    static class IntExtensions
    {
        public static int GetNegative(this int number)
        {
            if (number > 0)
            {
                return - number;
            }
            else
            {
                return number;
            }
        }

        public static int GetPositive(this int number)
        {
            if (number < 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }
    }
    */

    /* (XV, XVII, XVIII, XIX, XX) (7.6.2, 7.6.7, 7.6.9, 7.6.10, 7.6.12)
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }

    abstract class Engine { }

    abstract class CarPart { }

    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    */

    /* (XVI) (7.6.2)
    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }
    */

    //() ()

    //
}