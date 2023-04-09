using System;

public class LongSword : Sword
{
    //överskriver värden för dena class
    public LongSword(string name)
    {
        Name = name;
        Value = SetValue(6);

        BladeMaterial = MateraialSelceter();
        BladeLength = 70;
        BladeWidth = 20;

        Range = 100;
        Dmg = 40;
        SwingSpeed = 30;
        Stabbspeed = 30;

        HandelMaterial = MateraialSelceter();
        HandelLength = 20;
    }
}
