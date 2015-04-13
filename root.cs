using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
 
class Program
{
    static IEnumerable<Complex> root(int degree)
    {
        return Enumerable
            .Range(0, degree)
            .Select(element => Complex.FromPolarCoordinates(1, 2 * Math.PI * element / degree));
    }
 
    static void Main()
    {
        var degree = 3;
        foreach (var root in root(degree))
        {
            Console.WriteLine(root);
        }
    }
}
