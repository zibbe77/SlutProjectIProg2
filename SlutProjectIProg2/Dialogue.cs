using System;

public static class Dialogue
{
    //saker som händer en gång i början
    #region Start
    //kallas i starten för att förkalara spelet
    public static void StartDialogue()
    {
        DrawUi.DrawTextLine("Välkommen till Fantasy affären. Här kan du testa hur det är att gå till affären i en Fantasy värld. Om en rutta som den här kommer upp och det inte står något annat klickar man enter för att forsäta vidare.", true, true);
        DrawUi.ViewBox();
    }
    public static void IntroShop()
    {
        DrawUi.DrawTextLine("Ho Ho välkommen till min lilla affär här kan du köpa allt som du behöver för att kunna äventyra.");
        DrawUi.ViewBox();
    }

    public static void StartBuyItem()
    {
        DrawUi.DrawTextLine("Vill du se vad man kan köpa?", true, false);
        DrawUi.DrawTextLine("( När du ser en ruta som har / i sig så kan du välja mellan dom olika alternativen. Som du ser under. )", false, true);
        bool response = CheckResponse.CheckResponseYeNe();

        if (response == true)
        {
            WriteItems();
        }
        else
        {
            GameRun.GameShouldRun = false;
        }
    }

    #endregion

    // Dialog som spelaren kan köras flera gånger i en om gång
    #region LoopDialogue
    #endregion

    //kod som kommer kallas av annan kod
    #region Utility

    //skriver utt all saker som shopen säljer 
    private static void WriteItems()
    {
        DrawUi.DrawTextLine("↓↓↓ Föremål till salu ↓↓↓", true, false);
        foreach (KeyValuePair<string, Item> pair in Toolbox.ItemDictionary)
        {
            Console.WriteLine(pair.Key);
        }
        DrawUi.DrawTextLine("", false, true);
    }
    #endregion
}
