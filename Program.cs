using System;
using System.Collections;
using System.Collections.Generic;

class Point
{
    private double _xCoord;
    private double _yCoord;

    public Point(double xCoord, double yCoord)
    {
        this._xCoord = xCoord;
        this._yCoord = yCoord;
    }

    public double XCoord
    {
        get { return this._xCoord; }
        set { this._xCoord = value; }
    }

    public double YCoord
    {
        get { return this._yCoord; }
        set { this._yCoord = value; }
    }
}

class Circle
{
    private Point vPoint;
    private double iRadius;

    public Circle(Point tempPoint, double tempRadius)
    {
        this.vPoint = tempPoint;
        this.iRadius = tempRadius;
    }

    public Point Point
    {
        get { return this.vPoint; }
        set { this.vPoint = value; }
    }

    public double Radius
    {
        get { return this.iRadius; }
        set { this.iRadius = value; }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        classExercise01();
        
        void classExercise01()
        {
            Console.WriteLine("Class Exercise 1");
            char cInput;
            List<Circle> listCircles = new List<Circle>();
            listCircles.Cast<Circle>().ToList();
            do
            {
                Console.Write("Please enter the X-coordinate of the circle: ");
                double xCoord = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the Y-coordinate of the circle: ");
                double yCoord = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the radius of the circle: ");
                double dRadius = Convert.ToDouble(Console.ReadLine());

                Point vPoint = new Point(xCoord, yCoord);
                Circle vCircle = new Circle(vPoint, dRadius);

                listCircles.Add(vCircle);

                Console.Write("To Exit, enter \'X\', else enter any key: ");
                cInput = Console.ReadLine()[0];
            } while (cInput != 'X');


            Console.Write("Please enter the X-coordinate of the circle: ");
            double xInput = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the Y-coordinate of the circle: ");
            double yInput = Convert.ToDouble(Console.ReadLine());
            Point pointUser = new Point(xInput, yInput);

            for (int iLoop = 0; iLoop < listCircles.Count; iLoop++)
            {
                Point tempPoint = listCircles[iLoop].Point;
                double tempRadius = listCircles[iLoop].Radius;
                // Check if the user's point is within each circle by checking the value against the point + radius
                if (((xInput >= tempPoint.XCoord) && (xInput <= (tempPoint.XCoord + tempRadius))) && ((yInput >= tempPoint.YCoord) && (yInput <= (tempPoint.YCoord + tempRadius))))
                {
                    String strOutput = String.Format("The point ({0},{1}) is inside Circle {2}", xInput, yInput, iLoop + 1);
                    Console.WriteLine(strOutput);
                }
            }
        }
    }
}



