global using System;

bool Runing = true;
while (Runing == true)
{
    GameRun.GameRuning();
    DrawUi.DrawTextLine("Vill du avsluta spelet");
    Runing = !CheckResponse.CheckResponseYeNe();
}