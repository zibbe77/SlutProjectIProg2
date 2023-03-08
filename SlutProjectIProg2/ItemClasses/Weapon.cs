using System;

public class Weapon : Item
{
    //Dmges numbers
    public int range { get; set; }
    public int dmg { get; set; }
    public int swingSpeed { get; set; }
    public int stabbspeed { get; set; }

    //Appearance values
    public string handelMaterial { get; set; }
    public int handelLength { get; set; }
}
