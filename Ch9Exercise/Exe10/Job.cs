using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Job
{
    private string description;
    private double hoursToComp;
    private double perHourRate;
    private double totalFee;

    public Job(string description, double hoursToComp, double perHourRate)
    {
        this.description = description;
        this.hoursToComp = hoursToComp;
        this.perHourRate = perHourRate;

        CalculateTotalFee();
    }
    public static Job operator +(Job job1, Job job2)
    {
        string combinedDescription = job1.description + " and " + job2.description;
        double combinedHours = job1.hoursToComp + job2.hoursToComp;
        double averageRate = (job1.perHourRate + job2.perHourRate) / 2;

        return new Job(combinedDescription, combinedHours, averageRate);
    }

    private void CalculateTotalFee()
    {
        totalFee = perHourRate * hoursToComp;
        
    }



    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public double HoursToComp
    {
        get { return hoursToComp; }
        set { hoursToComp = value; CalculateTotalFee(); }
    }

    public double PerHourRate
    {
        get { return perHourRate; }
        set { perHourRate = value; CalculateTotalFee(); }
    }
    public double TotalFee { get { return totalFee; } }

    public override string ToString()
    {
        return string.Format("{0,-30} {1,8:F2} hrs  @ ${2,6:F2}/hr  =  ${3,8:F2}",
            description, hoursToComp, perHourRate, totalFee);
    }
}

