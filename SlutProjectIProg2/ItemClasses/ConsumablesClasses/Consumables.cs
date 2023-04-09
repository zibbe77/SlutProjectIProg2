using System;

public abstract class Consumables : Item
{
    //varjablar som beskriver Consumables
    public string Effect { get; protected set; }
    public string Description { get; protected set; }
}
