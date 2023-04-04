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

    //skriver ett intro
    private static void IntroShop()
    {
        DrawUi.DrawTextLine("Ho Ho välkommen till min lilla affär här kan du köpa allt som du behöver för att kunna äventyra.");
        DrawUi.ViewBox();
    }

    //skriver intritoner till hur man köpper saker
    public static void StartBuyItem(Shoper sh)
    {
        IntroShop();
        String qustion = "Vill du se vad man kan köpa?";
        DrawUi.DrawTextLine(qustion, true, false);
        DrawUi.DrawTextLine("( När du ser en ruta som har / i sig så kan du välja mellan dom olika alternativen. Som du ser under. )", false, true);
        bool response = CheckResponse.CheckResponseYeNe(qustion);

        if (response == true)
        {
            WriteItems();
            BuyItems(sh);
        }
        else
        {
            GameRun.GameShouldRun = false;
        }
    }

    #endregion

    // Dialog som spelaren kan köras flera gånger i en om gång
    #region LoopDialogue

    // ger dig tre val lämna spelet, go till backa till shoppen inspetera dina saker.
    public static void Choice(Shoper sh)
    {
        Console.Clear();
        DrawUi.DrawTextLine("Du har tre val. Lämna spelet, Gå till bakatill affären eller kolla dina saker", true, false);

        string qustion = "Skriv Lämna eller Affären eller Dina Saker";
        int response = CheckResponse.CheckAction(qustion);

        switch (response)
        {
            //lämmna
            case 1:
                GameRun.GameShouldRun = false;
                break;
            //afären 
            case 2:
                QueueToTheStore(sh);
                break;
            //dina saker
            case 3:
                ViewYourItems(sh);
                break;
        }
    }

    //genararar en queue fram till afären mellan 0 och 20
    private static void QueueToTheStore(Shoper sh)
    {
        //skapar queue 
        Random random = new Random();
        int queueLenght = random.Next(5, 20);
        string[] names = Toolbox.RandomName(queueLenght);

        Queue<string> queue = new Queue<string>();
        for (int i = 0; i < queueLenght; i++)
        {
            queue.Enqueue(names[i]);
        }

        // går igenom queue och skriver utt namn
        while (queue.Count > 0)
        {
            Console.Clear();
            DrawUi.DrawTextLine($"{queue.Peek()} handlar och det är {queue.Count} framför dig");

            Thread.Sleep(random.Next(2000, 5000));
            queue.Dequeue();
        }

        Console.Clear();

        //låter köpa saker
        WriteItems();
        BuyItems(sh);
    }

    #endregion

    //kod som kommer kallas av annan kod allt är private
    #region Utility

    //skriver utt all saker som shopen säljer 
    private static void WriteItems()
    {
        DrawUi.DrawTextLine("↓↓↓ Föremål till salu ↓↓↓", true, false);
        foreach (KeyValuePair<string, Item> pair in Toolbox.ItemDictionary)
        {
            Console.WriteLine(pair.Key);
        }
        DrawUi.DrawTextLine(" ", false, true);
    }

    //låter dig köppa saker och visar vad du ska köpa
    private static void BuyItems(Shoper sh)
    {
        //kollar vad du vill kolla på
        string qustion = "skriv vad du vill köppa";
        string response = CheckResponse.CheckItem(qustion);

        //kollar vissar vad du 
        Console.Clear();

        foreach (var prop in Toolbox.ItemDictionary[response].GetType().GetProperties())
        {
            Console.WriteLine($"{prop.Name} är {prop.GetValue(Toolbox.ItemDictionary[response])}");
        }

        //kollar om du vill köppa saken 
        qustion = $"Vill du köpa saken? den kostar {Toolbox.ItemDictionary[response].Value}";
        DrawUi.DrawTextLine(qustion);

        if (CheckResponse.CheckResponseYeNe(qustion))
        {
            if (sh.Gold > Toolbox.ItemDictionary[response].Value)
            {
                sh.Gold -= Toolbox.ItemDictionary[response].Value;
                sh.itemList.Add(Toolbox.ItemDictionary[response]);
                DrawUi.DrawTextLine($"Du köpte {response}");
                DrawUi.ViewBox();
            }
        }
        LevingShop();
    }

    //skriver att du lämnade affären
    private static void LevingShop()
    {
        Console.Clear();
        DrawUi.DrawTextLine("Du lämmnade affären");
        DrawUi.ViewBox();
    }

    //hanter att du kan kolla på dinna items 
    private static void ViewYourItems(Shoper sh)
    {
        Console.Clear();

        DrawUi.DrawTextLine("Dina saker", true, false);
        if (sh.itemList.Count > 0)
        {
            WriteItemsOnly(sh);

            string qustion = "vill du kolla närmare på en av dina saker";
            DrawUi.DrawTextLine(qustion);
            if (CheckResponse.CheckResponseYeNe(qustion))
            {
                Console.Clear();
                WriteItemsOnly(sh);

                qustion = "Skriv den saken du vill kola på";
                CheckResponse.CheckYourItems(qustion, sh);
            }
        }
        else
        {
            DrawUi.DrawTextLine("Här var det tomt =(");
        }
    }

    //skriver en lista på alla shoppers items
    private static void WriteItemsOnly(Shoper sh)
    {
        foreach (Item item in sh.itemList)
        {
            Console.WriteLine(item);
        }
    }

    #endregion
}
