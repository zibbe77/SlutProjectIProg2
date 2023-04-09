using System;

public class ShortSword : Sword
{
    //överskriver värden för dena class
    public ShortSword(string name)
    {
        Name = name;
        Value = SetValue(3);

        BladeMaterial = MateraialSelceter();
        BladeLength = 25;
        BladeWidth = 10;

        Range = 50;
        Dmg = 10;
        SwingSpeed = 50;
        Stabbspeed = 60;

        HandelMaterial = MateraialSelceter();
        HandelLength = 10;
    }
}
