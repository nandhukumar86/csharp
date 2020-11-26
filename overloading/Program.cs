using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Child gp = new GrandChild();

            gp.print();
            

            /*
            Points to be noted on: GrandParent gp = new GrandChild();
            
            1) virtial -> override -> override -> override: 
            
                This will print "From Grandchild"

            2) virtial -> override -> new -> override

                Compilation Error

            3) virtial -> override -> new -> new

                This will print "From Parent"

            4) ()* -> new -> new -> new

                This will print "From Grand Parent"


                approx: virtual* -> overide* -> new*

            */

        }
    }

    public class GrandParent
    {
        public void print()
        {
            System.Console.WriteLine("from Grand Parent");
        }
    }

    public class Parent : GrandParent
    {
        public new void print()
        {
            System.Console.WriteLine("from Parent");
        }
    }

    public class Child : Parent
    {
        public new void print()
        {
            System.Console.WriteLine("from Child");
        }
    }

    public class GrandChild : Child
    {
        public new void print()
        {
            System.Console.WriteLine("from Grand Child");
        }
    }
}
