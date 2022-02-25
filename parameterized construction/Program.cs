using System;
namespace Demoproject
{
    class Parameterizedcondemo
    {
        int x;
        public Parameterizedcondemo(int i)
        {
            x = i;
            Console.WriteLine("Parameterized constructor is called:" + i);
        }
        public void display()
        {
            Console.Write("Value of x is:" +x);
        }
        static void Main()
        {
            Parameterizedcondemo cd1 = new Parameterizedcondemo(10);
            Parameterizedcondemo cd2 = new Parameterizedcondemo(15);
            Parameterizedcondemo cd3 = new Parameterizedcondemo(20);
            cd1.display();
            cd2.display();
            Console.ReadLine();
        }
    }
}
