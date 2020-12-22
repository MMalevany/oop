using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A(2, 1);
            Console.WriteLine("Значение поля с = " + classA.c);
            B classB = new B(5, 4, 10);
            Console.WriteLine("Свойство с2 = " + classB.c2);
        }
    }

    class A
    {
        public int a;
        public int b;
        public int c
        {
            get { return a *= (a + b); }
        }

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("A: a + b = " + (a + b));

        }
        public A() { }
    }

    class B : A
    {
        public int d;

        public int c2
        {
            get
            {
                while (d < 15)
                    d = d + a + b;
                return d;
            }
            set { c2 = value; }
        }

        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;
            Console.WriteLine("B: d = " + d);
            Console.WriteLine("B: a + b + d = " + (a + b + d));
        }

        public B() { }
    }
}