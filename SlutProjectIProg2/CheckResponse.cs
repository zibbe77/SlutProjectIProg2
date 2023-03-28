using System;

public static class CheckResponse
{
    //kolar efter om svaret var ja eller nej returnar en bool true eller false
    public static bool CheckResponseYeNe()
    {
        bool boolReturn = false;
        bool valid = false;


        while (valid == false)
        {
            DrawUi.DrawTextLine("Ja / Nej", 8);
            string response = Console.ReadLine();
            response.ToLower();

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
                DrawUi.DrawTextLine("Du måste skriv Ja eller Nej klicka enter om du förstår");
                DrawUi.ViewBox();
            }
        }
        return boolReturn;
    }
}
