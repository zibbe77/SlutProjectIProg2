public class DrawUi
{
    // kan kallas och är huben för att skriva ut en string
    public static void DrawTextLine(string line, int boxLength = 50)
    {
        //hämtar boxen
        string box = CreatBox(boxLength);

        //skriver utt ui 
        Console.WriteLine(box);

        //om den är länger splita i felra rader
        if (line.Length < boxLength)
        {
            Console.WriteLine(line);
        }
        else
        {
            string[] lineBack = LineBulider(line, boxLength);
            for (var i = 0; i < lineBack.Count(); i++)
            {
                Console.WriteLine(lineBack[i]);
            }
        }
        Console.WriteLine(box);
    }

    //för att städa bort en box och vissa den
    public static void ViewBox()
    {
        Console.ReadLine();
        Console.Clear();
    }

    //skappar stringen som är boxen 
    private static string CreatBox(int Length)
    {
        string box = "";

        for (int i = 0; i < Length; i++)
        {
            box += "-";
        }
        return box;
    }

    //splitar strings så den får plats i en box
    private static string[] LineBulider(string line, float boxLength)
    {
        //räknar hur många rader det ska vara
        int rows = (int)MathF.Ceiling(line.Length / boxLength);

        string[] lineArray = line.Split(" ");
        string[] returnLine = new string[rows];

        float splitNumber = MathF.Floor(lineArray.Count() / rows);

        //sätter ihop springen
        for (int rowI = 0; rowI < rows; rowI++)
        {
            returnLine[rowI] = String.Join(" ", lineArray[((int)splitNumber * rowI)..((int)splitNumber * (rowI + 1))]);
        }
        return returnLine;
    }
}
