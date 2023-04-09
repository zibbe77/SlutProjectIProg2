using System;

public class Toolbox
{
    // lägger till alla items som fins 
    public static Dictionary<string, Item> ItemDictionary = new Dictionary<string, Item>();

    //tar bort alla saker ur dictionary (trode det skulle vara svårare)
    public void RemoveAllItems()
    {
        ItemDictionary.Clear();
    }

    //lägger till saker i en Dictionary
    public void StartAddItems()
    {
        HpPotion hpPotion = new HpPotion();
        ItemDictionary.Add("HpPotion", hpPotion);

        ManaPotion manaPotion = new ManaPotion();
        ItemDictionary.Add("ManaPotion", manaPotion);

        //vappen
        string[] name;

        name = RandomName(1);
        Spear spear = new Spear(name[0]);
        ItemDictionary.Add("Spear", spear);

        name = RandomName(1);
        ShortSword shortSword = new ShortSword(name[0]);
        ItemDictionary.Add("ShortSword", shortSword);

        name = RandomName(1);
        LongSword longSword = new LongSword(name[0]);
        ItemDictionary.Add("LongSword", longSword);
    }

    //slumpar namen från text fillen name
    public string[] RandomName(int namesCount)
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
