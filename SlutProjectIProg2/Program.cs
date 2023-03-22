Dialogue.StartDialogue();

//skaper spelaren och skappar en Dictionary med items
Shoper sh = new Shoper();
Toolbox.StartAddItems();

foreach (KeyValuePair<string, Item> pair in Toolbox.ItemDictionary)
{
    Console.WriteLine(pair.Value.Name);
}

Console.ReadLine();

