﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadedOps
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public override string ToString() => $"[{this.X}, {this.Y}]";

        // Overloaded operator +.
        public static Point operator + (Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);
        // Overloaded operator -.`
        public static Point operator - (Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);

        // More overloads
        public static Point operator +(Point p1, int change) => new Point(p1.X + change, p1.Y + change);
        public static Point operator +(int change, Point p1) => new Point(p1.X + change, p1.Y + change);

    }
}
