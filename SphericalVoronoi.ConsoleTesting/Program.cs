﻿using SphericalVoronoi.CoordinateSystems.Cartesian;
using SphericalVoronoi.CoordinateSystems.Spherical;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SphericalVoronoi.ConsoleTesting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var start1 = new SphereCoordinate(Math.PI / 2, 1.75 * Math.PI);
            Console.WriteLine((CartesianVector)start1);

            var end1 = new SphereCoordinate(Math.PI / 2, Math.PI / 4);
            Console.WriteLine((CartesianVector)end1);

            var start2 = new SphereCoordinate(Math.PI / 4, 0);
            Console.WriteLine((CartesianVector)start2);

            var end2 = new SphereCoordinate(0.75 * Math.PI, 0);
            Console.WriteLine((CartesianVector)end2);

            var arc1 = new GreatCircleSegment(start1, end1);
            var arc2 = new GreatCircleSegment(start2, end2);

            Console.WriteLine();
            Console.WriteLine(arc1.Midpoint);
            Console.WriteLine(new CartesianVector(0, 0, 2));
            Console.WriteLine((SphereCoordinate)arc1.Midpoint);
            Console.WriteLine((SphereCoordinate)new CartesianVector(0, 0, 2));
            Console.WriteLine((CartesianVector)(SphereCoordinate)arc1.Midpoint);
            Console.WriteLine();

            SphereCoordinate intersection;
            Console.WriteLine(arc1.Intersects(arc2, out intersection) + "   " + intersection + "   " + (CartesianVector)intersection);

            Console.WriteLine();
            var quarterSpherePoly = new Polygon(new SphereCoordinate(0, 0), new SphereCoordinate(0.5 * Math.PI, 0), new SphereCoordinate(0.5 * Math.PI, 0.5 * Math.PI), new SphereCoordinate(0.5 * Math.PI, Math.PI));
            Console.WriteLine("Size of quarter sphere Polygon: " + quarterSpherePoly.Area);
            Console.WriteLine("Area of whole sphere: " + 4 * Math.PI);
            Console.WriteLine("Area of quarter sphere: " + Math.PI);

            Console.ReadLine();
        }
    }
}