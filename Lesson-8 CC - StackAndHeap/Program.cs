using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_CC___StackAndHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack And Heap
            //Boxing From Stack To Heap
            int x = 10;
            object o = x;

            //Unboxing From Heap To Stack
            int y = (int)o;

            //Copy Reference To New Arr
            int[] arr1 = new int[3] { 13, 25, 5 };
            int[] arr2 = arr1;
            arr1[1] = 999;

            // Copy All Values To New Arr
            int[] arr21 = new int[arr1.Length];
            for (int i = 0; i < arr21.Length; i++)
            {
                int currentValue = arr1[i];
                arr21[i] = arr1[i];
            }

            //New Item In Stack
            CalcTwoNumbers();

            #endregion

            #region Method Overloading

            SuperConsole sc = new SuperConsole();
            Console.WriteLine(5);
            sc.WriteLine("Hackeru");
            sc.WriteLine("5");


            Calculator c = new Calculator();
            c.x = 10;
            Calculator c2 = new Calculator(c);
            c.CalcNumbers(3, 4);

            PrintInManyRows(3, 6);
            PrintInManyRows(true, true);
            PrintInManyRows("Or", "Ganon");
            PrintInManyRows("12", "Yossi", "Lior");
            #endregion

            #region Ctors Overloading

            DateTime dateTime = new DateTime(2020, 12, 10);
            DateTime dateTime1 = new DateTime(2019,11,4,10,10,12);

            #endregion

            #region Virtual And Override

            Dog d = new Dog();
            d.Eat();
            FatCat fCat = new FatCat();
            fCat.Eat();

            #endregion
        }

        // Program Functions
        #region Method Overloading

        public static void PrintInManyRows(string val1, string val2)
        {
            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }

        public static void PrintInManyRows(string val1, string val2, string val3)
        {
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            Console.WriteLine(val3);
        }

        public static void PrintInManyRows(int val1, int val2)
        {
            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }

        public static void PrintInManyRows(bool val1, bool val2)
        {
            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }

        #endregion
        
        #region Stack And Heap

        static int CalcTwoNumbers()
        {
            //New Item In Stack
            int num = GetNumberFromUser();

            //New Item In Stack
            int num2 = GetNumberFromUser();

            return num + num2;
        }

        static int GetNumberFromUser()
        {
            return int.Parse(Console.ReadLine());
        }

        #endregion
    }

    // Another Classes
    #region Method Overloading

    public class Calculator
    {
        public int x, y, z,r;

        public Calculator()
        {

        }
        public Calculator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Copy Constructor
        public Calculator(Calculator calc)
        {
            this.x = calc.x;
            this.y = calc.y;
            this.z = calc.z;
            this.r = calc.r;
        }
        public int CalcNumbers(int n1, int n2)
        {
            return n1 + n2;
        }


        public int CalcNumbers(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
    }

    class SuperConsole
    {

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public void WriteLine(int value)
        {
            Console.WriteLine(value);
        }
    }
    #endregion

    #region Virtual And Override

    class AnyThing //: Object
    {
        public void Move()
        {
            Console.WriteLine("New Place");
        }
    }
    class LivingThing : AnyThing
    {
        public void Move2()
        {
            Console.WriteLine("New Place2");
        }
    }

    class Animal : LivingThing
    {
        public int legs;

        public virtual void Eat()
        {
            Console.WriteLine("Yammi");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("how");
        }
    }

    class FatCat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("I Can't");
        }
    }

    #endregion
}
