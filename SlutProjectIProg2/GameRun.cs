using System;

public static class GameRun
{
    //håller koll om spelet körs
    public static bool GameShouldRun = true;
    public static void GameRuning()
    {
        Dialogue.StartDialogue();

        //skaper spelaren och skappar en Dictionary med items
        Shoper sh = new Shoper();
        Toolbox.RemoveAllItems();
        Toolbox.StartAddItems();

        // Det är ett lite intro till hur spelet fungerar men man kan bara lämna spelet här om man vill
        Dialogue.StartBuyItem(sh);
        if (GameShouldRun == false) { return; }

        //loopar spelet
        while (GameShouldRun == true)
        {
            Dialogue.Choice(sh);
            if (GameShouldRun == false) { return; }
        }
    }
}
