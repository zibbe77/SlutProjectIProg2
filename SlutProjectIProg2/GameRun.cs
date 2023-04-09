using System;

public class GameRun
{
    //håller koll om spelet körs
    public static bool GameShouldRun = true;
    public void GameRuning()
    {
        //skapar en dialog instance
        Dialogue dialogue = new Dialogue();
        dialogue.StartDialogue();

        //skaper spelaren och skappar en Dictionary med items
        Shoper sh = new Shoper();

        Toolbox toolbox = new Toolbox();
        toolbox.RemoveAllItems();
        toolbox.StartAddItems();

        // Det är ett lite intro till hur spelet fungerar men man kan bara lämna spelet här om man vill
        dialogue.StartBuyItem(sh);
        if (GameShouldRun == false) { return; }

        //loopar spelet
        while (GameShouldRun == true)
        {
            dialogue.Choice(sh);
            if (GameShouldRun == false) { return; }
        }
    }
}
