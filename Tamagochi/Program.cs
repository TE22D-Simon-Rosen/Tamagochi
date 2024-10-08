Tamagochi tamagochi = new();

Console.WriteLine("Select a name for your tamagochi: ");
tamagochi.name = Console.ReadLine();

while (tamagochi.GetAlive() == true){
    Console.WriteLine("\nVad vill du göra? \n\nA) Lära ett nytt ord \nB) Hälsa \nC) Mata \nD) Ingenting \n\nSkriv motsvarande bokstav för att välja");
    string choice = Console.ReadLine().ToUpper();


    if (choice == "A"){
        Console.WriteLine("Vad vill du lära din tamagochi?");
        string i = Console.ReadLine();
        tamagochi.Teach(i);
    }
    else if (choice == "B"){
        tamagochi.Hi();
    }
    else if (choice == "C"){
        tamagochi.Feed();
    }
    else if (choice == "D"){
        Console.WriteLine($"\n{tamagochi.name}: ....");
    }
    else

    Console.ReadLine();

    tamagochi.Tick();
    tamagochi.PrintStats();
}

Console.WriteLine("Din tamagochi dog :/");
Console.ReadLine();