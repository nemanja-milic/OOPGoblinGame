// See https://aka.ms/new-console-template for more information
using OOPGoblinGame;

Console.WriteLine("==== ARENA BATTLE =====");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Choose your action");
Console.WriteLine("1. Attack");
Console.WriteLine("2. Heal");
Console.WriteLine("3. Show status");

GameController gameController = new GameController();

gameController.StartGame();