using System;

public class Weapon : Item
{
    //Dmges numbers
    public int Range { get; set; }
    public int Dmg { get; set; }
    public int SwingSpeed { get; set; }
    public int Stabbspeed { get; set; }

    //Appearance values
    public string HandelMaterial { get; set; }
    public int HandelLength { get; set; }
}
