using System;

public static class CheckResponse
{
    //kolar efter om svaret var ja eller nej returnar en bool true eller false
    public static bool CheckResponseYeNe(string qustion)
    {
        bool boolReturn = false;
        bool valid = false;


        while (valid == false)
        {
            DrawUi.DrawTextLine("Ja / Nej", 8);
            string response = Console.ReadLine().ToLower();

            if (response == "ja")
            {
                boolReturn = true;
                valid = true;
            }
            else if (response == "nej")
            {
                boolReturn = false;
                valid = true;
            }
            else
            {
                Console.Clear();
                DrawUi.DrawTextLine("Du måste skriv Ja eller Nej. klicka enter om du förstår");
                DrawUi.ViewBox();
            }
            DrawUi.DrawTextLine(qustion);
        }
        Console.Clear();
        return boolReturn;
    }

    //kollar vilket item du vill kolla på
    public static string CheckItem(string qustion)
    {
        string returnString = " ";
        bool valid = false;

        while (valid == false)
        {
            //skriver frågan och sparar svaret
            DrawUi.DrawTextLine(qustion);

            string response = Console.ReadLine().ToLower();

            //kollar svaret 
            foreach (KeyValuePair<string, Item> pair in Toolbox.ItemDictionary)
            {
                if (response.ToLower() == pair.Key.ToLower())
                {
                    returnString = pair.Key;
                    valid = true;
                }
            }
            if (valid == false)
            {
                DrawUi.DrawTextLine("Du måste skriva en av sakerna");
            }
        }
        return returnString;
    }

    //kollar vom du väljer att gå till afären, lämna eller kola dina saker
    public static int CheckAction(string qustion)
    {
        int returnInt = 0;

        while (returnInt == 0)
        {
            DrawUi.DrawTextLine(qustion);
            string response = Console.ReadLine().ToLower();

            switch (response.ToLower())
            {
                case "lämna":
                    returnInt = 1;
                    break;
                case "affären":
                    returnInt = 2;
                    break;
                case "dina saker":
                    returnInt = 3;
                    break;
                default:
                    DrawUi.DrawTextLine(qustion);
                    DrawUi.ViewBox();
                    break;
            }
        }
        return returnInt;
    }

    //kollar vilket av dina saker du vill kola på
    public static void CheckYourItems(string qustion, Shoper sh)
    {
        string returnString = " ";
        bool valid = false;

        while (valid == false)
        {
            //skriver frågan och sparar svaret
            DrawUi.DrawTextLine(qustion);

            string response = Console.ReadLine().ToLower();

            //kollar svaret 
            foreach (Item item in sh.itemList)
            {
                Console.WriteLine(item);

                if (response.ToLower() == item.ToString().ToLower())
                {
                    foreach (var prop in item.GetType().GetProperties())
                    {
                        Console.WriteLine($"{prop.Name} är {prop.GetValue(item)}");
                    }
                    valid = true;
                    DrawUi.DrawTextLine("klicka enter för att forsäta");
                    DrawUi.ViewBox();
                }
            }

            if (valid == false)
            {
                DrawUi.DrawTextLine("Du måste skriva en av sakerna");
            }
        }
    }
}
