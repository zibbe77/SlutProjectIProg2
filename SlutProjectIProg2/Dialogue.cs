using System;

public class Dialogue
{
    //kallas i starten för att förkalara spelet
    public static void StartDialogue()
    {
        DrawUi.DrawTextLine("Välkommen till Fantasy affären. Här kan du testa hur det är att gå till affären i en Fantasy värld. Om en rutta som den här kommer upp och det inte står något annat klickar man enter för att forsäta vidare.");
        DrawUi.ViewBox();
    }
}
