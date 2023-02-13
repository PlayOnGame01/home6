using System;

namespace Классы_в .NET_home_work6
{
    internal class Vector
    {
        private int x;
        private int y;
        private int z;
        private double vector;
        public Vector() { }
        public Vector(int x)
        {
            this.x = x;
        }
        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void EnterCoordinate()
        {
            Console.Write("Enter value of x: ");
            string str_x = Console.ReadLine();
            x = Convert.ToInt32(str_x);
            Console.Write("Enter value of y: ");
            string str_y = Console.ReadLine();
            y = Convert.ToInt32(str_y);
            Console.Write("Enter value of z: ");
            string str_z = Console.ReadLine();
            z = Convert.ToInt32(str_z);
        }
        public void PrintCoordinate()
        {
            Console.WriteLine($"\nCoordinate x = {x}");
            Console.WriteLine($"Coordinate y = {y}");
            Console.WriteLine($"Coordinate z = {z}");
        }
        public void PrintVector() => Console.WriteLine($"Vector = {vector}\n");
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public double Sum_of_vector
        {
            get { return vector; }
            set { vector = Math.Sqrt(x + y + z); }
        }
        public void Increase(int a)
        {
            a++;
        }
        public void Decrease(int a)
        {
            a--;
        }
        public void VectorAddition(double vector)
        {
            this.vector += vector;
            Console.WriteLine($"New vector = {this.vector}");
        }
        public void VectorSubtraction(double vector)
        {
            this.vector -= vector;
            Console.WriteLine($"New vector = {this.vector}");
        }
        public void VectorMultiplication(double vector)
        {
            this.vector *= vector;
            Console.WriteLine($"New vector = {this.vector}");
        }
        public void VectorEquality(double vector)
        {
            if (this.vector == vector) { Console.WriteLine("vector A == vector B"); }
            else { Console.WriteLine("vector A != vector B"); }
        }

    }
}