using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_в.NET_homework_08._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector();
            vector.EnterCoordinate();
            vector.PrintCoordinate();
            vector.Sum_of_vector = 0;
            vector.PrintVector();

            vector.VectorAddition(0);

            vector.VectorAddition(10);
            vector.VectorEquality(8);

        }
    }
}