using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharsConsole
{
    public abstract class Console17OOP
    {
        private string id = "";
        private string name = "";

        public string ID
        {
            get 
            {
                return id;
            }
            set
            { 
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public abstract void DisplayInfo();

       

    }

    public class DerivedClass : Console17OOP
    {
        public override void DisplayInfo()
        {
            Console.WriteLine(ID + " " + Name);
        }
    }

    //interface
    interface IMyInterface
    { 
        string ID{ get; set; }

        string Name { get; set; }

        void DisplayInfo();
    }

    class MyClass : IMyInterface
    {
        string id = "";
        string name = "";

        public string ID { get =>  id; set => id = value; } 
        public string Name { get => name; set => name = value; }

        public void DisplayInfo()
        {
           Console.WriteLine("ID\tName");
           Console.WriteLine(ID+"\t"+Name);
        }
    }

    //Multi derived from super interface 
    interface IPeople
    { 
        string Name { get; set; }
        string Gender { get; set; }

    }

    interface ITeaher : IPeople
    {
        void teach();
    }

    interface IStudent : IPeople
    { 
        void study();
    }

    class MultiDerived : IPeople, ITeaher, IStudent
    {
        string name = "";
        string gender = "";
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }

        public void study()
        {
            Console.WriteLine(name + " " + gender + " is studing");
        }

        public void teach()
        {
            Console.WriteLine(name + " " + gender +" is teaching");
        }
    }

    //explicit implemtation of interface function
    interface IExplicitImpl1
    {
        int Add();
    }

    interface IExplicitImpl2
    {
        int Add();
    }

    class ExplicitImpl : IExplicitImpl1, IExplicitImpl2
    {
        int IExplicitImpl1.Add()
        {
            int x = 1;
            int y = 2;
            return x + y;
        }

        int IExplicitImpl2.Add()
        {
            int x = 3;
            int y = 5;
            int z = 7;
            return x + y + z;
        }
    }

    //Sealed class cannot be derived, the virtual function of the sealed class is overrided in the child class
    public class VirtualSealedClass
    {
        public virtual void displayInfomation() { }
    }

    public sealed class SealedClass : VirtualSealedClass
    {
        private string id = "";
        private string name = "";

        public string ID
        { 
            get => id; set => id = value;
        }
        
        public string Name { get => name; set => name = value; }

        public sealed override void displayInfomation() 
        {
            Console.WriteLine(ID+ " "+Name );
        }
    }



    public class DelagateTest()
    { 
        public int Add(int x, int y){ return x + y; }
    }

    public delegate void RingEvent(int ringType);
    public class SchoolRing
    {
        public RingEvent onBellRinged;

        public void ring(int ringType)
        { 
            if (ringType == 1 || ringType == 2)
            {
                Console.WriteLine(ringType == 1 ? "Class begins" : "Class is over");
                if (onBellRinged != null)
                    onBellRinged(ringType);
            }  
            else
            {
                Console.WriteLine("Ring type is invalid");
            }
        }
      
    }

    public class Students
    {
        public void subscribeToRing(SchoolRing schoolRing)
        {
            schoolRing.onBellRinged += ringing;
        }

        public void ringing(int ringKind)
        {
            if (ringKind == 2)
                Console.WriteLine("Take a break");
            else if (ringKind == 1)
                Console.WriteLine("Study");
        }

        public void cancelSubscribe(SchoolRing schoolRing)
        {
            schoolRing.onBellRinged -= ringing;
            Console.WriteLine("Subsciption is cancelled");
        }
    }

    
    interface IRectangle
    { 
        int Width { get; set; }
        int Height { get; set; }
        int Area();
    }
    class Rectangle : IRectangle
    {
        int width = 0;
        int height = 0;
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public int Area()
        {
            return width * height;
        }
    }

    public abstract class AbsCircle
    { 
        private int r = 0;
        public int Radius
        { 
            get => r; set => r = value;
        }

        public abstract double Area();
    }

    public class Circle : AbsCircle
    {
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    //Generic interface
    public interface IGenericInterface<T>
    {
        T CreateInstance();
    }
    public class Factory<T, TI> : IGenericInterface<TI> where T : TI, new()
    {
        public TI CreateInstance()
        {
            return new T();
        }
    }

    public class Finder 
    
    {
        public static int checkItems<T>(T[] items, T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                    return i;
            }
            return -1;
        }

    }

    class GenericClass1<T>
    {
        public GenericClass1()
        {
            Console.WriteLine("This is the first generic class");
        } 
    }

    class GenericClass2<T> : GenericClass1<T>
    {
        public GenericClass2()
        {
            Console.WriteLine("This is the second generic class");
        }
    } 
}
