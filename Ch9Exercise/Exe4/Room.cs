using System;
using System.Collections.Generic;
using System.Text;

class Room
{
    private double length;
    private double width;
    private double height;
    private double area;
    private int numGallons;

    private const double coveragePerGallon = 350;

    public Room(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;

        // Wall area and gallons are computed internally by private methods
        area = CalcArea();
        numGallons = CalcGallons();
    }
    public double Length
    {
        get
        {
            return length;
        }
      
    }
    public double Width
    {
        get
        {
            return width;
        }
      
    }
    public double Height
    {
        get
        {
            return height;
        }
    }
    public double Area
    {
        get
        {
            return area;
        }
    }
    public int NumGallons
    {
        get
        {
            return numGallons;
        }
    }
    private double CalcArea()
    {
        double wall1 = 0;
        double wall2 = 0;
        
        wall1 = 2 * (height * width);
        wall2 = 2 * (height * length);
        double perimeter = wall1 + wall2;
        return perimeter;
    }

    private int CalcGallons()
    {
        int wholeGallons = (int)(area / coveragePerGallon);
        double remainder = area % coveragePerGallon;

        if (remainder > 0)
        {
            wholeGallons++;
        }

        return wholeGallons;



    }
}
