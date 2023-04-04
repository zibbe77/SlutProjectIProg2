global using System;

//körs medans programet ska köras
bool Runing = true;
while (Runing == true)
{
    GameRun.GameShouldRun = true;
    GameRun.GameRuning();

    string qustion = "Vill du avsluta spelet";
    DrawUi.DrawTextLine(qustion);
    Runing = !CheckResponse.CheckResponseYeNe(qustion);
}