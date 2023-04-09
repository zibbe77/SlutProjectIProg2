using System;

public abstract class Weapon : Item
{
    //Dmges numbers
    public int Range { get; protected set; }
    public int Dmg { get; protected set; }
    public int SwingSpeed { get; protected set; }
    public int Stabbspeed { get; protected set; }

    //Appearance values
    public string HandelMaterial { get; protected set; }
    public int HandelLength { get; protected set; }

    //väljer ett matrial 
    protected string MateraialSelceter()
    {
        string[] materaial = { "Trä", "Stål", "Järn", "Härdat trä" };
        Random generator = new Random();
        int randomInt = generator.Next(0, 4);

        return (materaial[randomInt]);
    }
}
