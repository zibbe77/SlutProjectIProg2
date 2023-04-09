global using System;

//körs medans programet ska köras
bool Runing = true;
while (Runing == true)
{
    //skapar spelet
    GameRun.GameShouldRun = true;
    GameRun gameRun = new GameRun();
    gameRun.GameRuning();

    //kollar om pogramet ska avslutas
    string qustion = "Vill du avsluta spelet";
    DrawUi drawUi = new DrawUi();
    drawUi.DrawTextLine(qustion);

    CheckResponse checkResponse = new CheckResponse();

    Runing = !checkResponse.CheckResponseYeNe(qustion);
}