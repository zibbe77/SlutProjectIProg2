using System;

public class ManaPotion : Consumables
{
    //överskriver värden för dena class
    public ManaPotion()
    {
        Name = "ManaPostion";
        Value = SetValue(1);
        Effect = "Ger dig lite mana och får dig att käna dig piggare";
        Description = "En liten glass flaska";
    }
}
