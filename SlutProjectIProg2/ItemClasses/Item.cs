using System;

public class Item
{
    //generella varjablar 
    public string Name { get; protected set; }
    public int Value { get; protected set; }

    //slumpar ett number mellan 10 och 1000 men sen kan dom gränsana öka med modeifer som gångrar värdet
    protected int SetValue(int modefier)
    {
        Random generator = new Random();
        int randomInt = generator.Next(10, 1000);
        return randomInt * modefier;
    }
}
