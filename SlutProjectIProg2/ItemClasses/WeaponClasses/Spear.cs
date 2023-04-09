using System;

public class Spear : Weapon
{
    //Appearance
    public string SpeartipMaterial { get; protected set; }
    public int SpeartipLenght { get; protected set; }
    public int SpeartipWidth { get; protected set; }

    //överskriver värden för dena class
    public Spear(string name)
    {
        Name = name;
        Value = SetValue(4);

        SpeartipMaterial = MateraialSelceter();
        SpeartipLenght = 10;
        SpeartipWidth = 5;

        Range = 250;
        Dmg = 20;
        SwingSpeed = 5;
        Stabbspeed = 20;

        HandelMaterial = MateraialSelceter();
        HandelLength = 250;
    }
}
