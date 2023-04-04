using System;

public static class Toolbox
{
    // lägger till alla items som fins 
    public static Dictionary<string, Item> ItemDictionary = new Dictionary<string, Item>();

    public static void RemoveAllItems()
    {
        ItemDictionary.Clear();
    }

    //lägger till saker i en Dictionary
    public static void StartAddItems()
    {
        HpPotion hpPotion = new HpPotion();
        ItemDictionary.Add("HpPotion", hpPotion);

        ManaPotion manaPotion = new ManaPotion();
        ItemDictionary.Add("ManaPotion", manaPotion);

        Spear spear = new Spear();
        ItemDictionary.Add("Spear", spear);

        ShortSword shortSword = new ShortSword();
        ItemDictionary.Add("ShortSword", shortSword);

        LongSword longSword = new LongSword();
        ItemDictionary.Add("LongSword", longSword);
    }

    //slumpar namen från text fillen name
    public static string[] RandomName(int namesCount)
    {
        Random random = new Random();
        string[] contents = File.ReadAllLines(@"Names.txt");

        string[] returnString = new string[namesCount];

        for (int i = 0; i < namesCount; i++)
        {
            returnString[i] = contents[random.Next(0, 400)];
        }

        return returnString;
    }
}
