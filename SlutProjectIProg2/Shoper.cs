using System;

public class Shoper
{
    // public stuff
    public List<Item> itemList = new List<Item>();
    public int Gold { get; set; }

    //Konstruktor som skappar grundvärdet på guld 
    public Shoper()
    {
        Random generator = new Random();
        Gold = generator.Next(2000, 10000);
    }
}
