using System;
using System.Collections.Generic;
using System.Text;

class ClassifiedAds
{
    private string category;
    private int numberOfWords;
    private double price;
    public string Category 
    { 
        set
        {
            category = value;
        }
    }
    
    public int NumberOfWords
    {
        set
        {
            numberOfWords = value;
        }
    }
    
    public double Price
    {
        get
        {
            price = numberOfWords * 0.9;

            return price;
        }
    }
}
