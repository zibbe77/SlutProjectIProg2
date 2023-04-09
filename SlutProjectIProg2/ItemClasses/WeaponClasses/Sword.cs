using System;

public abstract class Sword : Weapon
{
    //uttsende 
    public string BladeMaterial { get; protected set; }
    public int BladeLength { get; protected set; }
    public int BladeWidth { get; protected set; }
}
