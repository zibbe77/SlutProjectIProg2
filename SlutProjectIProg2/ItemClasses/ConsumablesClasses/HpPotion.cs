using System;

public class HpPotion : Consumables
{
    //överskriver värden för dena class
    public HpPotion()
    {
        Name = "HpPostion";
        Value = SetValue(1);
        Effect = "Healar några små skador";
        Description = "En liten glass flaska";
    }
}
