using System;

public class CheckResponse
{
    //skapper en refercen till drawUi och skapare en instans av den
    DrawUi drawUi;
    public CheckResponse()
    {
        drawUi = new DrawUi();
    }

    //kolar efter om svaret var ja eller nej returnar en bool true eller false
    public bool CheckResponseYeNe(string qustion)
    {
        bool boolReturn = false;
        bool valid = false;


        while (valid == false)
        {
            drawUi.DrawTextLine("Ja / Nej", 8);
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
                drawUi.DrawTextLine("Du måste skriv Ja eller Nej. klicka enter om du förstår");
                drawUi.ViewBox();
            }
            drawUi.DrawTextLine(qustion);
        }
        Console.Clear();
        return boolReturn;
    }

    //kollar vilket item du vill kolla på
    public string CheckItem(string qustion)
    {
        string returnString = " ";
        bool valid = false;

        while (valid == false)
        {
            //skriver frågan och sparar svaret
            drawUi.DrawTextLine(qustion);

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
                drawUi.DrawTextLine("Du måste skriva en av sakerna");
            }
        }
        return returnString;
    }

    //kollar vom du väljer att gå till afären, lämna eller kola dina saker
    public int CheckAction(string qustion)
    {
        int returnInt = 0;

        while (returnInt == 0)
        {
            drawUi.DrawTextLine(qustion);
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
                    drawUi.DrawTextLine(qustion);
                    drawUi.ViewBox();
                    break;
            }
        }
        return returnInt;
    }

    //kollar vilket av dina saker du vill kola på
    public void CheckYourItems(string qustion, Shoper sh)
    {
        string returnString = " ";
        bool valid = false;

        while (valid == false)
        {
            //skriver frågan och sparar svaret
            drawUi.DrawTextLine(qustion);

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
                    drawUi.DrawTextLine("klicka enter för att forsäta");
                    drawUi.ViewBox();
                }
            }

            if (valid == false)
            {
                drawUi.DrawTextLine("Du måste skriva en av sakerna");
            }
        }
    }

    //kolla hur mycket du vill tippa
    public int CheckAmount()
    {
        int returnInt = 0;
        bool valid = false;

        while (!valid)
        {
            drawUi.DrawTextLine("Hur mycket vill du tippa?");
            string value = Console.ReadLine();

            valid = int.TryParse(value, out returnInt);
            if (valid == false)
            {
                Console.Clear();
                drawUi.DrawTextLine("Du måste skriva ett number");
                drawUi.ViewBox();
            }
        }
        return returnInt;
    }
}
