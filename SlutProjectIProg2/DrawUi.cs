using System;

public class DrawUi
{
    public static void DrawTextLine(string line)
    {
        //kontrolerar längden på boxen
        int boxLength = 50;

        //hämtar boxen
        string box = CreatBox(boxLength);

        //skriver utt ui 
        Console.WriteLine(box);

        //om den är länger splita i felra rader
        if (line.Length < boxLength)
        {
            Console.WriteLine(line);
        }
        else if (line.Length > boxLength && line.Length < boxLength * 2)
        {
            string[] lineBack = LineBulider(line, 2);
            for (var i = 0; i < lineBack.Count(); i++)
            {
                Console.WriteLine(lineBack[i]);
            }
        }
        Console.WriteLine(box);
    }

    private static string CreatBox(int Length)
    {
        string box = "";

        for (int i = 0; i < Length; i++)
        {
            box += "-";
        }
        return box;
    }

    private static string[] LineBulider(string line, int rows)
    {
        //string[] lineArray = new string[rows];
        string[] lineArray = line.Split(" ");
        string[] returnLine = new string[rows];

        float splitNumber = MathF.Floor(lineArray.Count() / rows);

        //test
        Console.WriteLine(splitNumber);

        for (var rowI = 0; rowI < rows; rowI++)
        {
            for (var i = 0; i < splitNumber; i++)
            {
                try
                {
                    returnLine[rowI] = String.Join((splitNumber * rowI) + lineArray[i], (splitNumber * rowI) + lineArray[i + 1]);
                }
                catch (System.Exception) { }
            }
        }

        return returnLine;
    }
}
